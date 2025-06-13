using Gaskeun_.Models;
using GasKeun.Helpers;
using Gaskeun_.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using Gaskeun_.Controller;
using System.Globalization;

namespace Gaskeun_.View
{
    public partial class DetailKendaraan : Form
    {
        public int IdKendaraan { get; set; }
        private Kendaraan kendaraan;
        PelangganControl pelangganControl = new PelangganControl();

        public DetailKendaraan(Kendaraan kendaraan)
        {
            InitializeComponent();
            this.kendaraan = kendaraan;
            _ = LoadKendaraanDetailAsync();
        }

        private void DetailKendaraan_Load(object sender, EventArgs e)
        {
            datetglsewa.Format = DateTimePickerFormat.Custom;
            datetglsewa.CustomFormat = " ";

            string fotoUrl = pelangganControl.GetUserPhoto(Session.CurrentUserId);
            if (!string.IsNullOrEmpty(fotoUrl))
            {
                try
                {
                    imgprofil.Load(fotoUrl);
                }
                catch
                {
                    imgprofil.Image = Properties.Resources.user__1_;
                }
            }
            else
            {
                imgprofil.Image = Properties.Resources.user__1_;
            }
        }

        private async Task LoadKendaraanDetailAsync()
        {
            if (kendaraan == null) return;

            lblnama.Text = kendaraan.NamaKendaraan;
            try
            {
                using var wc = new System.Net.WebClient();
                byte[] imageBytes = await wc.DownloadDataTaskAsync(kendaraan.Gambar);
                using var ms = new System.IO.MemoryStream(imageBytes);
                imgKendaraan.Image = Image.FromStream(ms);
            }
            catch
            {
                imgKendaraan.Image = null;
            }
            lblplat.Text = kendaraan.Plat;
            lbltahun.Text = kendaraan.Tahun;
            lblmerk.Text = kendaraan.Merk;
            lblketersediaan.Text = kendaraan.Status;
            lbljenis.Text = kendaraan.JenisKendaraan;

            lblharga.Text = $"Rp{kendaraan.HargaHari:N0}/hari";
            lblhargamingguan.Text = $"Rp{kendaraan.HargaMinggu:N0}/minggu";
            lblhargabulanan.Text = $"Rp{kendaraan.HargaBulan:N0}/bulan";
        }

        private void datetglsewa_ValueChanged(object sender, EventArgs e)
        {
            {
                datetglsewa.Format = DateTimePickerFormat.Custom;
                datetglsewa.CustomFormat = "dd MMM yyyy  HH:mm";
            }
        }

        private void cmboxdurasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotalHarga();
        }

        private void cmboxpaketsewa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotalHarga();
        }
        private void HitungTotalHarga()
        {
            if (kendaraan == null) return;
            if (cmboxdurasi.SelectedItem == null || cmboxpaketsewa.SelectedItem == null)
            {
                txtTotalHarga.Text = "0";
                return;
            }

            int durasi;
            if (!int.TryParse(cmboxdurasi.SelectedItem.ToString(), out durasi))
            {
                txtTotalHarga.Text = "0";
                return;
            }

            string paket = cmboxpaketsewa.SelectedItem.ToString();

            decimal hargaPerHari = 0;
            decimal hargaPerMinggu = 0;
            decimal hargaPerBulan = 0;

            hargaPerHari = kendaraan.HargaHari;
            hargaPerMinggu = kendaraan.HargaMinggu;
            hargaPerBulan = kendaraan.HargaBulan;

            decimal totalHarga = 0;

            switch (paket.ToLower())
            {
                case "hari":
                    totalHarga = hargaPerHari * durasi;
                    break;
                case "minggu":
                    totalHarga = hargaPerMinggu * durasi;
                    break;
                case "bulan":
                    totalHarga = hargaPerBulan * durasi;
                    break;
                default:
                    totalHarga = hargaPerHari * durasi;
                    break;
            }

            txtTotalHarga.Text = totalHarga.ToString("N0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (datetglsewa.Value == DateTimePicker.MinimumDateTime || datetglsewa.CustomFormat == " ")
                {
                    MessageBox.Show("Tanggal Penyewaan belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmboxjaminan.SelectedItem == null)
                {
                    MessageBox.Show("Jaminan belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmboxdurasi.SelectedItem == null)
                {
                    MessageBox.Show("Durasi belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmboxpaketsewa.SelectedItem == null)
                {
                    MessageBox.Show("Paket Sewa belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmboxmetode.SelectedItem == null)
                {
                    MessageBox.Show("Metode Pembayaran belum dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPelanggan = Session.CurrentUserId;

                this.IdKendaraan = kendaraan.IdKendaraan;

                string alamatPengambilan = txtboxpengambilan.Text.Trim();
                DateTime tanggalSewaDateTime = datetglsewa.Value;
                DateOnly tanggalSewa = DateOnly.FromDateTime(tanggalSewaDateTime);

                int durasi = int.Parse(cmboxdurasi.SelectedItem.ToString());
                string paketSewa = cmboxpaketsewa.SelectedItem.ToString();

                DateOnly tanggalKembali;
                switch (paketSewa.ToLower())
                {
                    case "hari":
                        tanggalKembali = tanggalSewa.AddDays(durasi);
                        break;
                    case "minggu":
                        tanggalKembali = tanggalSewa.AddDays(durasi * 7);
                        break;
                    case "bulan":
                        tanggalKembali = tanggalSewa.AddMonths(durasi);
                        break;
                    default:
                        tanggalKembali = tanggalSewa.AddDays(durasi); // Default ke harian
                        break;
                }

                string jaminan = cmboxjaminan.SelectedItem.ToString();
                string metodePembayaran = cmboxmetode.SelectedItem.ToString();

                decimal totalHarga = decimal.Parse(txtTotalHarga.Text, NumberStyles.AllowThousands, CultureInfo.CurrentCulture);

                Transaksi transaksi = new Transaksi
                {
                    IdPelanggan = idPelanggan,
                    IdKendaraan = IdKendaraan,
                    AlamatPengambilan = alamatPengambilan,
                    TanggalSewa = tanggalSewa,
                    TanggalKembali = tanggalKembali,
                    Jaminan = jaminan,
                    PaketSewa = paketSewa,
                    Durasi = durasi,
                    Harga = totalHarga,
                    MetodePembayaran = metodePembayaran,
                    Status = "Proses",
                    Denda = 0M
                };

                TransaksiControl transaksiControl = new TransaksiControl();
                bool success = transaksiControl.AddTransaksi(transaksi);

                if (success)
                {
                    MessageBox.Show("Transaksi berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan transaksi. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message);
            }
        }

        private void Judul_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgprofil_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(Session.CurrentUserId);
            profileForm.ShowDialog();
            this.Show();
        }
    }
}
