using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Gaskeun_.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaskeun_.View
{
    public partial class ProfileForm : Form
    {
        private int currentUserId;
        private UserController controller = new UserController();
        public Cloudinary cloudinary;
        public const string CLOUD_NAME = "dqsnhqpta";
        public const string API_KEY = "415453362647782";
        public const string API_SECRET = "2eO5TB3MKkx_M-AyaA7NOQ9PV_Q";
        public string imagePath;
        public string imageUrl;

        public ProfileForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            this.Load += ProfileForm_Load;
            btnSave.Click += btnSave_Click;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            var data = controller.LoadUser(currentUserId);
            if (data != null)
            {
                lblUsername.Text = data["username"].ToString();
                lblEmail.Text = data["email"].ToString();
                lblNoHp.Text = data["no_hp"].ToString();
                txtPassword.Text = data["password"].ToString();

                
                if (data["foto"] != DBNull.Value && !string.IsNullOrEmpty(data["foto"].ToString()))
                {
                    image.Load(data["foto"].ToString());
                }
            }
            dataGridHistory.DataSource = controller.GetHistoryTransaksi(currentUserId);

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password harus minimal 6 karakter.");
                return;
            }

            controller.ChangePassword(currentUserId, txtPassword.Text);
            MessageBox.Show("Password berhasil diperbarui.");
        }

        private void InitCloudinary()
        {
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            cloudinary = new Cloudinary(account);
        }

        private async Task<string> UploadImageAsync(string path)
        {
            return await Task.Run(() =>
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(path)
                };

                var uploadResult = cloudinary.Upload(uploadParams);
                return uploadResult.SecureUrl.ToString();
            });
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image |*.jpg;*.jpeg;*.png";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                image.Image = new Bitmap(dlg.FileName);
                imagePath = dlg.FileName;
            }
        }

        private async void btnUpload_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Silakan pilih gambar terlebih dahulu.");
                return;
            }

            try
            {
                InitCloudinary();
                imageUrl = await UploadImageAsync(imagePath);

                controller.UpdateUserImage(currentUserId, imageUrl);
                image.Load(imageUrl);

                MessageBox.Show("Gambar berhasil diupload dan disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat upload: " + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
