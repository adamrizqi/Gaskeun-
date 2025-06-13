using Gaskeun_.Controller;
using Gaskeun_.Models;
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
    public partial class TransaksiPelanggan : UserControl
    {
        Transaksi dataTransaksi = new Transaksi();
        TransaksiControl transaksiControl;
        public TransaksiPelanggan()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            transaksiControl = new TransaksiControl();
            dataGridView1.DataSource = transaksiControl.ReadTransaksi();
            dtTglKeterlambatan.ShowCheckBox = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbDenda.Text = row.Cells[9].Value.ToString();
                tbHarga.Text = row.Cells[11].Value.ToString();
                cbStatus.Text = row.Cells[12].Value.ToString();

                var cellValue = row.Cells[4].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    DateTime dateToSet;

                    if (cellValue is DateOnly dateOnlyValue)
                    {
                        dateToSet = dateOnlyValue.ToDateTime(TimeOnly.MinValue);
                    }
                    else if (cellValue is DateTime dateTimeValue)
                    {
                        dateToSet = dateTimeValue;
                    }
                    else
                    {
                        dateToSet = DateTime.MinValue;
                    }

                    if (dateToSet < dtTglKeterlambatan.MinDate || dateToSet > dtTglKeterlambatan.MaxDate)
                    {
                        dtTglKeterlambatan.Checked = false;
                    }
                    else
                    {
                        dtTglKeterlambatan.Value = dateToSet;
                        dtTglKeterlambatan.Checked = true;
                    }
                }
                else
                {
                    dtTglKeterlambatan.Checked = false;
                }
            }
        }
        public Transaksi GetTransaksi()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris dulu cuy!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            dataTransaksi.IdTransaksi = Convert.ToInt32(selectedRow.Cells[0].Value);

            if (dtTglKeterlambatan.Checked)
            {
                dataTransaksi.TanggalKeterlambatan = DateOnly.FromDateTime(dtTglKeterlambatan.Value);
            }
            else
            {
                dataTransaksi.TanggalKeterlambatan = DateOnly.MinValue; // 01/01/0001
            }
            dataTransaksi.Denda = Convert.ToDecimal(tbDenda.Text); 
            dataTransaksi.Harga = Convert.ToDecimal(tbHarga.Text);
            dataTransaksi.Status = cbStatus.SelectedItem?.ToString();
            return dataTransaksi;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (GetTransaksi() == null)
            {
                return;
            }

            if (transaksiControl.UpdateTransaksi(GetTransaksi()))
            {
                MessageBox.Show("Data transaksi berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = transaksiControl.ReadTransaksi();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data transaksi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
