using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class TransaksiContext : Connection
    {
        public List<Transaksi> listTransaksi = new List<Transaksi>();
        public List<Transaksi> Read()
        {
            using (var conn = GetConnection())
            {
                string query = @"SELECT t.id_transaksi, a.username, k.nama_kendaraan, t.tanggal_sewa, t.tanggal_pengembalian, t.tanggal_keterlambatan, t.jaminan, t.paket_sewa, t.durasi, t.denda, t.metode_pembayaran, t.harga, t.status
                                FROM transaksi t 
                                JOIN akun a ON t.id_pelanggan = a.id_akun 
                                JOIN kendaraan k ON t.id_kendaraan = k.id_kendaraan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listTransaksi.Clear();
                    while (reader.Read())
                    {
                        Transaksi dataTransaksi = new Transaksi();
                        dataTransaksi.IdTransaksi = (int)reader["id_transaksi"];
                        dataTransaksi.Username = (string)reader["username"];
                        dataTransaksi.NamaKendaraan = (string)reader["nama_kendaraan"];
                        dataTransaksi.TanggalSewa = DateOnly.FromDateTime((DateTime)reader["tanggal_sewa"]);
                        dataTransaksi.TanggalKembali = DateOnly.FromDateTime((DateTime)reader["tanggal_pengembalian"]);
                        dataTransaksi.TanggalKeterlambatan = reader["tanggal_keterlambatan"] != DBNull.Value ? DateOnly.FromDateTime((DateTime)reader["tanggal_keterlambatan"]) : DateOnly.MinValue;
                        dataTransaksi.Jaminan = (string)reader["jaminan"];
                        dataTransaksi.PaketSewa = (string)reader["paket_sewa"];
                        dataTransaksi.Durasi = (int)reader["durasi"];
                        dataTransaksi.Denda = (decimal)reader["denda"];
                        dataTransaksi.MetodePembayaran = (string)reader["metode_pembayaran"];
                        dataTransaksi.Harga = (decimal)reader["harga"];
                        dataTransaksi.Status = (string)reader["status"];
                        listTransaksi.Add(dataTransaksi);
                    }
                }
            }
            return listTransaksi;
        }
        public bool Update(Transaksi transaksi)
        {
            bool isSuccess = false;
            using (var conn = GetConnection())
            {
                string query = @"UPDATE transaksi SET tanggal_keterlambatan = @tanggal_keterlambatan, denda = @denda, harga = @harga, status = @status
                        WHERE id_transaksi = @id_transaksi;";
                conn.Open();
                using (Npgsql.NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@id_transaksi", transaksi.IdTransaksi));
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal_keterlambatan", transaksi.TanggalKeterlambatan.ToDateTime(TimeOnly.MinValue)));
                    cmd.Parameters.Add(new NpgsqlParameter("@denda", transaksi.Denda));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga", transaksi.Harga));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", transaksi.Status));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataTerupdate = cmd.ExecuteNonQuery();
                    if (jmlDataTerupdate > 0)
                    {
                        isSuccess = true;
                        foreach (var temp in this.listTransaksi)
                        {
                            var t = temp as Transaksi;
                            if (t != null && t.IdTransaksi.Equals(transaksi.IdTransaksi))
                            {
                                t.TanggalKeterlambatan = transaksi.TanggalKeterlambatan;
                                t.Denda = transaksi.Denda;
                                t.Harga = transaksi.Harga;
                                t.Status = transaksi.Status;
                            }
                        }
                    }
                }
                return isSuccess;
            }
        }
        public bool Insert(Transaksi transaksi)
        {
            bool isSuccess = false;
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"INSERT INTO transaksi 
                        (id_pelanggan, id_kendaraan, tanggal_sewa, tanggal_pengembalian, alamat_pengambilan, jaminan, paket_sewa, durasi, denda, metode_pembayaran, harga, status)
                        VALUES 
                        (@id_pelanggan, @id_kendaraan, @tanggal_sewa, @tanggal_pengembalian, @alamat_pengambilan, @jaminan, @paket_sewa, @durasi, @denda, @metode_pembayaran, @harga, @status);";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Transaction = transaction;

                            cmd.Parameters.AddWithValue("@id_pelanggan", transaksi.IdPelanggan);
                            cmd.Parameters.AddWithValue("@id_kendaraan", transaksi.IdKendaraan);
                            cmd.Parameters.AddWithValue("@tanggal_sewa", transaksi.TanggalSewa);
                            cmd.Parameters.AddWithValue("@tanggal_pengembalian", transaksi.TanggalKembali);
                            cmd.Parameters.AddWithValue("@alamat_pengambilan", transaksi.AlamatPengambilan ?? "-");
                            cmd.Parameters.AddWithValue("@jaminan", transaksi.Jaminan);
                            cmd.Parameters.AddWithValue("@paket_sewa", transaksi.PaketSewa);
                            cmd.Parameters.AddWithValue("@durasi", transaksi.Durasi);
                            cmd.Parameters.AddWithValue("@denda", transaksi.Denda);
                            cmd.Parameters.AddWithValue("@metode_pembayaran", transaksi.MetodePembayaran);
                            cmd.Parameters.AddWithValue("@harga", transaksi.Harga);
                            cmd.Parameters.AddWithValue("@status", transaksi.Status);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                transaction.Commit();
                                isSuccess = true;
                                listTransaksi.Add(transaksi);
                            }
                            else
                            {
                                transaction.Rollback();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Insert transaksi gagal:\n" + ex.ToString());
                    }
                }
            }
            return isSuccess;
        }
    }
}
