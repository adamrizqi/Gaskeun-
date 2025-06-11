using Gaskeun_.View;
using GasKeun.Helpers;
using Gaskeun_.Models;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaskeun_.View
{
    public partial class Card : UserControl
    {
        public Kendaraan kendaraan;

        public Card()
        {
            InitializeComponent();

            this.Click += Card_Click;
            imgKendaraan.Click += Card_Click;
            lblnama.Click += Card_Click;
            lblharga.Click += Card_Click;
            lblketersediaan.Click += Card_Click;
            panel1.Click += Card_Click;

            imgKendaraan.Cursor = Cursors.Hand;
            lblnama.Cursor = Cursors.Hand;
            lblharga.Cursor = Cursors.Hand;
            lblketersediaan.Cursor = Cursors.Hand;
            panel1.Cursor = Cursors.Hand;
        }


        public async void SetKendaraan(Kendaraan kendaraan)
        {

            this.kendaraan = kendaraan;

            NamaKendaraan = kendaraan.NamaKendaraan;
            Harga = "Rp" + kendaraan.HargaHari.ToString("N0") + "/hari";
            Ketersediaan = kendaraan.Status;

            try
            {
                using var wc = new System.Net.WebClient();
                byte[] imageBytes = await wc.DownloadDataTaskAsync(kendaraan.Gambar);
                using var ms = new System.IO.MemoryStream(imageBytes);
                GambarKendaraan = Image.FromStream(ms);
            }
            catch
            {
                GambarKendaraan = null;
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            OnCardClicked();
        }

        public virtual void OnCardClicked()
        {
            if (kendaraan != null)
            {
                var detailForm = new DetailKendaraan(kendaraan);
                detailForm.Show();
            }
            else
            {
                MessageBox.Show("Data kendaraan belum di-set.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string NamaKendaraan
        {
            get { return lblnama.Text; }
            set { lblnama.Text = value; }
        }

        public string Harga
        {
            get { return lblharga.Text; }
            set { lblharga.Text = value; }
        }

        public string Ketersediaan
        {
            get { return lblketersediaan.Text; }
            set { lblketersediaan.Text = value; }
        }

        public Image GambarKendaraan
        {
            get { return imgKendaraan.Image; }
            set { imgKendaraan.Image = value; }
        }
    }
}
