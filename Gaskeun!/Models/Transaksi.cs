using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public int IdPelanggan { get; set; }
        public int IdKendaraan { get; set; }
        public string Username { get; set; }
        public string JenisKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public DateOnly TanggalSewa { get; set; }
        public DateOnly TanggalKembali { get; set; }
        public DateOnly TanggalKeterlambatan { get; set; }
        public string AlamatPengambilan { get; set; }
        public string Jaminan { get; set; }
        public int Durasi { get; set; }
        public string PaketSewa { get; set; }
        public decimal Denda { get; set; }
        public string MetodePembayaran { get; set; }
        public decimal Harga { get; set; }
        public string Status { get; set; }
    }
}
