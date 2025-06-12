using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Model
{
    public class UserModel
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=Rental";

        public DataRow GetUser(int userId)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT * FROM akun WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("id", userId);

            using var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public void UpdatePassword(int userId, string newPassword)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand("UPDATE akun SET password = @p WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("p", newPassword);
            cmd.Parameters.AddWithValue("id", userId);
            cmd.ExecuteNonQuery();
        }

        public void UpdateUserImage(int userId, string imageUrl)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand("UPDATE akun SET foto = @img WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("img", imageUrl);
            cmd.Parameters.AddWithValue("id", userId);
            cmd.ExecuteNonQuery();
        }

        public DataTable GetHistoryTransaksi(int userId)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            string query = @"
        SELECT 
            k.nama_kendaraan AS ""NamaKendaraan"",
            k.jenis_kendaraan AS ""JenisKendaraan"",
            t.paket_sewa AS ""PaketSewa"",
            t.tanggal_sewa AS ""TanggalSewa"",
            t.tanggal_pengembalian AS ""TanggalPengembalian"",
            t.durasi AS ""Durasi"",
            t.harga AS ""Harga"",
            t.status AS ""Status""
        FROM transaksi t
        JOIN kendaraan k ON t.id_kendaraan = k.id_kendaraan
        WHERE t.id_pelanggan = @id
        ORDER BY t.tanggal_sewa DESC;
    ";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", userId);

            using var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


    }
}