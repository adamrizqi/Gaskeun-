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
                string sql = "SELECT id_akun FROM akun WHERE username = @username " +
                    "AND password = @password AND role = @role";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("role", "pelanggan");
                    var hasil = cmd.ExecuteScalar();
                    if (hasil != null && hasil != DBNull.Value)
                    {
                        idAkun = Convert.ToInt32(hasil);
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
                                VALUES(@role, @username, @email, @password, @no_hp, @status);";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@role", "pelanggan"));
                    cmd.Parameters.Add(new NpgsqlParameter("@username", pelanggan.Username));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", pelanggan.Email));
                    cmd.Parameters.Add(new NpgsqlParameter("@password", pelanggan.Password));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", pelanggan.NoHp));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", pelanggan.Status));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSucces = true;
                        this.listPelanggan.Add(pelanggan);
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
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listPelanggan.Clear();
                    while (reader.Read())
                    {
                        Pelanggan dataPelanggan = new Pelanggan
                        {
                            IdAkun = reader.GetInt32(reader.GetOrdinal("id_akun")),
                            Username = reader["username"].ToString(),
                            Email = reader["email"].ToString(),
                            NoHp = reader["no_hp"].ToString(),
                            Password = reader["password"].ToString(),
                            Status = reader["status"].ToString()
                        };
                        listPelanggan.Add(dataPelanggan);
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
                string query = @"UPDATE akun
                                SET username = @username, email = @email, no_hp = @no_hp, status = @status
                                WHERE no_hp = @no_hp";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@username", pelanggan.Username));
                    cmd.Parameters.Add(new NpgsqlParameter("@email", pelanggan.Email));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", pelanggan.NoHp));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", pelanggan.Status));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerupdate = cmd.ExecuteNonQuery();
                    if (jmlDataTerupdate > 0)
                    {
                        isSucces = true;
                        foreach (var temp in this.listPelanggan)
                        {
                            var t = temp as Pelanggan;
                            if (t != null && t.NoHp.Equals(pelanggan.NoHp))
                            {
                                t.Username = pelanggan.Username;
                                t.Email = pelanggan.Email;
                                t.NoHp = pelanggan.NoHp;
                                t.Password = pelanggan.Password;
                                t.Status = pelanggan.Status;
                            }
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
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", pelanggan.NoHp));
                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataDihapus = cmd.ExecuteNonQuery();
                    if (jmlDataDihapus > 0)
                    {
                        isSucces = true;
                        var itemToRemove = this.listPelanggan.Single(p => p.NoHp == pelanggan.NoHp);
                        this.listPelanggan.Remove(itemToRemove);
                    }
                }
            }
            return isSucces;
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

        public void UpdateUserImage(int userId, string imageUrl)
        {
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("UPDATE akun SET foto = @img WHERE id_akun = @id", conn);
            cmd.Parameters.AddWithValue("img", imageUrl);
            cmd.Parameters.AddWithValue("id", userId);
            cmd.ExecuteNonQuery();
        }

        public List<Transaksi> GetHistoryTransaksi(int userId)
        {
            var listTransaksi = new List<Transaksi>();

            using var conn = GetConnection();
            conn.Open();

            string query = @"SELECT k.nama_kendaraan, k.jenis_kendaraan, t.paket_sewa, t.tanggal_sewa, t.tanggal_pengembalian, t.alamat_pengambilan, t.durasi, 
                            t.metode_pembayaran, t.harga, t.status FROM transaksi t JOIN kendaraan k ON t.id_kendaraan = k.id_kendaraan WHERE t.id_pelanggan = @id 
                            ORDER BY t.tanggal_sewa DESC;";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var transaksi = new Transaksi
                {
                    NamaKendaraan = reader["nama_kendaraan"].ToString(),
                    JenisKendaraan = reader["jenis_kendaraan"].ToString(),
                    PaketSewa = reader["paket_sewa"].ToString(),
                    TanggalSewa = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("tanggal_sewa"))),
                    TanggalKembali = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("tanggal_pengembalian"))),
                    AlamatPengambilan = reader["alamat_pengambilan"].ToString(),
                    Durasi = reader.GetInt32(reader.GetOrdinal("durasi")),
                    MetodePembayaran = reader["metode_pembayaran"].ToString(),
                    Harga = reader.GetDecimal(reader.GetOrdinal("harga")),
                    Status = reader["status"].ToString()
                };

                listTransaksi.Add(transaksi);
            }

            return listTransaksi;
        }
    }
}