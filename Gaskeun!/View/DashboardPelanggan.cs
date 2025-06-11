using Gaskeun_.Controller;
using GasKeun.Helpers;
using Gaskeun_.Models;
using System.Drawing;
using System.Reflection;
using static Gaskeun_.View.Card;
using Gaskeun_.Helpers;

namespace Gaskeun_.View
{
    public partial class DashboardPelanggan : Form
    {
        KendaraanControl kendaraanControl = new KendaraanControl();

        private string jenisMobil = "Mobil";
        private string jenisMotor = "Motor";
        public DashboardPelanggan()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetFilterButtonActive(btnsemua);
            LoadDataKendaraan("Semua");
            UIHelper.MakeRoundedCorners(imgbanner, 40);
        }

        private void panelsearch_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.MakeRoundedCorners(sender as Panel, 35, e);
        }


        private void imglogout_Click(object sender, EventArgs e)
        {
            Gaskeun_.Helpers.Session.ClearSession();

            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
        }

        private void LoadDataKendaraan(string filter)
        {
            flowkendaraan.Controls.Clear();

            flowkendaraan.Controls.Add(imgbanner);
            flowkendaraan.Controls.Add(panelFilter);

            List<Kendaraan> kendaraanList;

            if (filter == "Semua")
            {
                var listMobil = kendaraanControl.ReadKendaraan(jenisMobil);
                var listMotor = kendaraanControl.ReadKendaraan(jenisMotor);

                kendaraanList = new List<Kendaraan>();
                kendaraanList.AddRange(listMotor);
                kendaraanList.AddRange(listMobil);
            }
            else
            {
                kendaraanList = kendaraanControl.ReadKendaraan(filter);
            }

            KendaraanLoader.LoadKendaraan(flowkendaraan, kendaraanList);
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textSearch.Text.Trim().ToLower();
            KendaraanFilter.FilterKendaraan(flowkendaraan, keyword);
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textSearch.Clear();
            }
        }

        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == "Search anything")
            {
                textSearch.Clear();
                textSearch.ForeColor = Color.Black;
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textSearch.Text))
            {
                textSearch.Text = "Search anything";
                textSearch.ForeColor = Color.FromArgb(172, 172, 172);
            }
            else
            {
                foreach (Control control in flowkendaraan.Controls)
                {
                    if (control is Card c)
                        c.Visible = true;
                }
            }
        }

        private void btnsemua_Click(object sender, EventArgs e)
        {
            SetFilterButtonActive(btnsemua);
            LoadDataKendaraan("Semua");
        }

        private void btnmobil_Click(object sender, EventArgs e)
        {
            SetFilterButtonActive(btnmobil);
            LoadDataKendaraan("Mobil");
        }

        private void btnmotor_Click(object sender, EventArgs e)
        {
            SetFilterButtonActive(btnmotor);
            LoadDataKendaraan("Motor");
        }

        private void SetFilterButtonActive(Button activeButton)
        {
            foreach (var control in panelFilter.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.LightGray;
                    btn.ForeColor = Color.Black;
                }
            }


            activeButton.BackColor = Color.SteelBlue;
            activeButton.ForeColor = Color.White;
        }

    }
}
