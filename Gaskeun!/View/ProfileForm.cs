﻿using CloudinaryDotNet;
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
        private PelangganControl pelangganControl = new PelangganControl();
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
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            var data = pelangganControl.LoadUser(currentUserId);
            if (data != null)
            {
                lblUsername.Text = data.Username;
                lblEmail.Text = data.Email;
                lblNoHp.Text = data.NoHp;

                if (!string.IsNullOrEmpty(data.Foto))
                {
                    image.Load(data.Foto);
                }
            }
            dataGridHistory.DataSource = pelangganControl.GetHistoryTransaksi(currentUserId);

            dataGridHistory.Columns["IdTransaksi"].Visible = false;
            dataGridHistory.Columns["IdPelanggan"].Visible = false;
            dataGridHistory.Columns["IdKendaraan"].Visible = false;
            dataGridHistory.Columns["Username"].Visible = false;
            dataGridHistory.Columns["TanggalKeterlambatan"].Visible = false;
            dataGridHistory.Columns["Denda"].Visible = false;
            dataGridHistory.Columns["MetodePembayaran"].Visible = false;
            dataGridHistory.Columns["Jaminan"].Visible = false;
        }

        private void cloudinaryStorage()
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

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Silakan pilih gambar terlebih dahulu");
                return;
            }

            try
            {
                cloudinaryStorage();
                imageUrl = await UploadImageAsync(imagePath);

                pelangganControl.UpdateUserImage(currentUserId, imageUrl);
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
