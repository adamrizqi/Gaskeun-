using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class PelangganContext : Connection
    {
        public List<Pelanggan> listPelanggan = new List<Pelanggan>();

        public int CekPelanggan(string username, string password)
        {
            int idAkun = 0;
            using (NpgsqlConnection conn = GetConnection())
            {
                string sql = "SELECT id_akun FROM akun WHERE username = @username AND password = @password AND role = @role";
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("role", "pelanggan");

                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idAkun = Convert.ToInt32(result);
                    }
                }
            }
            return idAkun;
        }

        public bool Insert(Pelanggan pelanggan)
        {
            bool isSucces = false;
            using (var conn = GetConnection())
            {
                string sql = @"INSERT INTO akun(role, username, email, password, no_hp, status)
                               VALUES(@role, @username, @email, @password, @no_hp, @status)";
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("role", "pelanggan");
                    cmd.Parameters.AddWithValue("username", pelanggan.Username);
                    cmd.Parameters.AddWithValue("email", pelanggan.Email);
                    cmd.Parameters.AddWithValue("password", pelanggan.Password);
                    cmd.Parameters.AddWithValue("no_hp", pelanggan.NoHp);
                    cmd.Parameters.AddWithValue("status", pelanggan.Status);

                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSucces = true;
                        listPelanggan.Add(pelanggan);
                    }
                }
            }
            return isSucces;
        }

        public List<Pelanggan> Read()
        {
            using (var conn = GetConnection())
            {
                string query = "SELECT id_akun, username, email, password, no_hp, status FROM akun WHERE role = 'pelanggan'";
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    listPelanggan.Clear();
                    while (reader.Read())
                    {
                        Pelanggan p = new Pelanggan
                        {
                            IdAkun = reader.GetInt32(reader.GetOrdinal("id_akun")),
                            Username = reader["username"].ToString(),
                            Email = reader["email"].ToString(),
                            Password = reader["password"].ToString(),
                            NoHp = reader["no_hp"].ToString(),
                            Status = reader["status"].ToString()
                        };
                        listPelanggan.Add(p);
                    }
                }
            }
            return listPelanggan;
        }

        public bool Update(Pelanggan pelanggan)
        {
            bool isSucces = false;
            using (var conn = GetConnection())
            {
                string query = @"UPDATE akun SET username = @username, email = @email, no_hp = @no_hp, status = @status
                                 WHERE no_hp = @no_hp";
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", pelanggan.Username);
                    cmd.Parameters.AddWithValue("email", pelanggan.Email);
                    cmd.Parameters.AddWithValue("no_hp", pelanggan.NoHp);
                    cmd.Parameters.AddWithValue("status", pelanggan.Status);

                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        isSucces = true;
                        var data = listPelanggan.SingleOrDefault(p => p.NoHp == pelanggan.NoHp);
                        if (data != null)
                        {
                            data.Username = pelanggan.Username;
                            data.Email = pelanggan.Email;
                            data.Status = pelanggan.Status;
                        }
                    }
                }
            }
            return isSucces;
        }

        public bool Delete(Pelanggan pelanggan)
        {
            bool isSucces = false;
            using (var conn = GetConnection())
            {
                string query = @"DELETE FROM akun WHERE no_hp = @no_hp";
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("no_hp", pelanggan.NoHp);
                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        var item = listPelanggan.SingleOrDefault(p => p.NoHp == pelanggan.NoHp);
                        if (item != null)
                            listPelanggan.Remove(item);
                        isSucces = true;
                    }
                }
            }
            return isSucces;
        }

        // === FUNGSI DARI USER CONTEXT YANG DIGABUNGKAN ===

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

        public void UpdateUserImage(int userId, string imageUrl)
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("UPDATE akun SET foto = @img WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("img", imageUrl);
            cmd.Parameters.AddWithValue("id", userId);
            cmd.ExecuteNonQuery();
        }

        public DataTable GetHistoryTransaksi(int userId)
        {
            using var conn = GetConnection();
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