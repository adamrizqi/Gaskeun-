using Gaskeun_.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class PelangganControl : Connection
    {
        private PelangganContext pelangganContext;

        public PelangganControl()
        {
            pelangganContext = new PelangganContext();
        }

        // ==== VALIDASI INPUT ====
        public (string pesan, string field) ValidasiInput(string username, string email, string noHp, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username))
                return ("Username tidak boleh kosong", "username");

            if (!email.EndsWith("@gmail.com"))
                return ("Email harus menggunakan domain @gmail.com", "email");

            if (!noHp.All(char.IsDigit))
                return ("Nomor HP hanya boleh berisi angka", "nohp");

            if (string.IsNullOrEmpty(password))
                return ("Password tidak boleh kosong!", "pw");

            if (password != confirmPassword)
                return ("Konfirmasi Password tidak sama", "confirm");

            return ("", "");
        }

        // ==== CRUD PELANGGAN ====
        public bool TambahPelanggan(Pelanggan pelanggan)
        {
            return pelangganContext.Insert(pelanggan);
        }

        public List<Pelanggan> GetAllPelanggan()
        {
            pelangganContext.Read();
            return pelangganContext.listPelanggan;
        }

        public bool UpdatePelanggan(Pelanggan pelanggan)
        {
            return pelangganContext.Update(pelanggan);
        }

        public bool DeletePelanggan(Pelanggan pelanggan)
        {
            return pelangganContext.Delete(pelanggan);
        }

        // ==== FUNGSI YANG DIGABUNG DARI USERCONTROLLER ====

        public Pelanggan LoadUser(int id)
        {
            return pelangganContext.GetUser(id);
        }

        public void UpdateUserImage(int userId, string imageUrl)
        {
            pelangganContext.UpdateUserImage(userId, imageUrl);
        }

        public DataTable GetHistoryTransaksi(int userId)
        {
            return pelangganContext.GetHistoryTransaksi(userId);
        }

        public string GetUserPhoto(int userId)
        {
            var user = pelangganContext.GetUser(userId);
            return user?.Foto;
        }

        public Pelanggan GetUser(int userId)
        {
            using var conn = GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT * FROM akun WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("id", userId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Pelanggan
                {
                    IdAkun = reader.GetInt32(reader.GetOrdinal("id_akun")),
                    Username = reader["username"].ToString(),
                    Email = reader["email"].ToString(),
                    NoHp = reader["no_hp"].ToString(),
                    Password = reader["password"].ToString(),
                    Status = reader["status"].ToString(),
                    Foto = reader["foto"] == DBNull.Value ? null : reader["foto"].ToString()
                };
            }

            return null;
        }

    }
}