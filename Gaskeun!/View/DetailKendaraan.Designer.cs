namespace Gaskeun_.View
{
    partial class DetailKendaraan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblnama = new Label();
            imgKendaraan = new PictureBox();
            lblharga = new Label();
            lblketersediaan = new Label();
            Judul = new Label();
            Header = new Panel();
            imglogout = new PictureBox();
            imgprofil = new PictureBox();
            imgRiwayat = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblplat = new Label();
            lbltahun = new Label();
            lblmerk = new Label();
            lblwarna = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            lblhargamingguan = new Label();
            lblhargabulanan = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            txtTotalHarga = new TextBox();
            label20 = new Label();
            cmboxmetode = new ComboBox();
            label19 = new Label();
            cmboxpaketsewa = new ComboBox();
            label18 = new Label();
            cmboxdurasi = new ComboBox();
            label17 = new Label();
            panel5 = new Panel();
            cmboxjaminan = new ComboBox();
            label16 = new Label();
            panel3 = new Panel();
            datetglsewa = new DateTimePicker();
            label12 = new Label();
            panel2 = new Panel();
            txtboxpengambilan = new TextBox();
            label11 = new Label();
            label10 = new Label();
            lbljenis = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgKendaraan).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imglogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgprofil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgRiwayat).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnama.Location = new Point(362, 205);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(128, 50);
            lblnama.TabIndex = 2;
            lblnama.Text = "label1";
            // 
            // imgKendaraan
            // 
            imgKendaraan.Location = new Point(123, 293);
            imgKendaraan.Name = "imgKendaraan";
            imgKendaraan.Size = new Size(1265, 784);
            imgKendaraan.SizeMode = PictureBoxSizeMode.Zoom;
            imgKendaraan.TabIndex = 3;
            imgKendaraan.TabStop = false;
            // 
            // lblharga
            // 
            lblharga.AutoSize = true;
            lblharga.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblharga.Location = new Point(1218, 1301);
            lblharga.Name = "lblharga";
            lblharga.Size = new Size(100, 40);
            lblharga.TabIndex = 4;
            lblharga.Text = "label1";
            // 
            // lblketersediaan
            // 
            lblketersediaan.AutoSize = true;
            lblketersediaan.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblketersediaan.Location = new Point(441, 1535);
            lblketersediaan.Name = "lblketersediaan";
            lblketersediaan.Size = new Size(100, 40);
            lblketersediaan.TabIndex = 5;
            lblketersediaan.Text = "label2";
            // 
            // Judul
            // 
            Judul.AutoSize = true;
            Judul.Cursor = Cursors.Hand;
            Judul.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Judul.ForeColor = Color.FromArgb(110, 91, 208);
            Judul.Location = new Point(52, 48);
            Judul.Name = "Judul";
            Judul.Size = new Size(184, 50);
            Judul.TabIndex = 0;
            Judul.Text = "GasKeun!";
            Judul.Click += Judul_Click;
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Controls.Add(imglogout);
            Header.Controls.Add(imgprofil);
            Header.Controls.Add(imgRiwayat);
            Header.Controls.Add(Judul);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(2854, 148);
            Header.TabIndex = 6;
            // 
            // imglogout
            // 
            imglogout.Cursor = Cursors.Hand;
            imglogout.Image = Properties.Resources.logout;
            imglogout.Location = new Point(2592, 58);
            imglogout.Name = "imglogout";
            imglogout.Size = new Size(40, 40);
            imglogout.SizeMode = PictureBoxSizeMode.Zoom;
            imglogout.TabIndex = 4;
            imglogout.TabStop = false;
            imglogout.Click += imglogout_Click;
            // 
            // imgprofil
            // 
            imgprofil.Image = Properties.Resources.user__1_;
            imgprofil.Location = new Point(2759, 48);
            imgprofil.Name = "imgprofil";
            imgprofil.Size = new Size(58, 58);
            imgprofil.SizeMode = PictureBoxSizeMode.Zoom;
            imgprofil.TabIndex = 3;
            imgprofil.TabStop = false;
            // 
            // imgRiwayat
            // 
            imgRiwayat.Image = Properties.Resources.history;
            imgRiwayat.Location = new Point(2679, 58);
            imgRiwayat.Name = "imgRiwayat";
            imgRiwayat.Size = new Size(40, 40);
            imgRiwayat.SizeMode = PictureBoxSizeMode.Zoom;
            imgRiwayat.TabIndex = 2;
            imgRiwayat.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 205);
            label1.Name = "label1";
            label1.Size = new Size(113, 50);
            label1.TabIndex = 7;
            label1.Text = "Sewa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 1185);
            label2.Name = "label2";
            label2.Size = new Size(160, 40);
            label2.TabIndex = 8;
            label2.Text = "Spesifikasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(885, 1185);
            label3.Name = "label3";
            label3.Size = new Size(197, 40);
            label3.TabIndex = 9;
            label3.Text = "Daftar Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(215, 1301);
            label4.Name = "label4";
            label4.Size = new Size(65, 40);
            label4.TabIndex = 10;
            label4.Text = "Plat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(215, 1357);
            label5.Name = "label5";
            label5.Size = new Size(92, 40);
            label5.TabIndex = 11;
            label5.Text = "Tahun";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(215, 1418);
            label6.Name = "label6";
            label6.Size = new Size(82, 40);
            label6.TabIndex = 12;
            label6.Text = "Merk";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(215, 1477);
            label7.Name = "label7";
            label7.Size = new Size(99, 40);
            label7.TabIndex = 13;
            label7.Text = "Warna";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(215, 1535);
            label8.Name = "label8";
            label8.Size = new Size(94, 40);
            label8.TabIndex = 14;
            label8.Text = "Status";
            // 
            // lblplat
            // 
            lblplat.AutoSize = true;
            lblplat.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplat.Location = new Point(441, 1301);
            lblplat.Name = "lblplat";
            lblplat.Size = new Size(70, 40);
            lblplat.TabIndex = 15;
            lblplat.Text = "Plat";
            // 
            // lbltahun
            // 
            lbltahun.AutoSize = true;
            lbltahun.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltahun.Location = new Point(441, 1357);
            lbltahun.Name = "lbltahun";
            lbltahun.Size = new Size(101, 40);
            lbltahun.TabIndex = 16;
            lbltahun.Text = "Tahun";
            // 
            // lblmerk
            // 
            lblmerk.AutoSize = true;
            lblmerk.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmerk.Location = new Point(441, 1418);
            lblmerk.Name = "lblmerk";
            lblmerk.Size = new Size(89, 40);
            lblmerk.TabIndex = 17;
            lblmerk.Text = "Merk";
            // 
            // lblwarna
            // 
            lblwarna.AutoSize = true;
            lblwarna.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwarna.Location = new Point(441, 1477);
            lblwarna.Name = "lblwarna";
            lblwarna.Size = new Size(107, 40);
            lblwarna.TabIndex = 18;
            lblwarna.Text = "Warna";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(885, 1301);
            label13.Name = "label13";
            label13.Size = new Size(187, 40);
            label13.TabIndex = 19;
            label13.Text = "Harga Harian";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(885, 1357);
            label14.Name = "label14";
            label14.Size = new Size(233, 40);
            label14.TabIndex = 20;
            label14.Text = "Harga Mingguan";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(885, 1418);
            label15.Name = "label15";
            label15.Size = new Size(205, 40);
            label15.TabIndex = 21;
            label15.Text = "Harga Bulanan";
            // 
            // lblhargamingguan
            // 
            lblhargamingguan.AutoSize = true;
            lblhargamingguan.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhargamingguan.Location = new Point(1218, 1357);
            lblhargamingguan.Name = "lblhargamingguan";
            lblhargamingguan.Size = new Size(100, 40);
            lblhargamingguan.TabIndex = 22;
            lblhargamingguan.Text = "label1";
            // 
            // lblhargabulanan
            // 
            lblhargabulanan.AutoSize = true;
            lblhargabulanan.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhargabulanan.Location = new Point(1218, 1418);
            lblhargabulanan.Name = "lblhargabulanan";
            lblhargabulanan.Size = new Size(100, 40);
            lblhargabulanan.TabIndex = 23;
            lblhargabulanan.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(158, 143, 177);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(cmboxmetode);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(cmboxpaketsewa);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(cmboxdurasi);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lbljenis);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1765, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 1362);
            panel1.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(button1);
            panel6.Location = new Point(673, 1255);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 67);
            panel6.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(158, 143, 177);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 2);
            button1.Name = "button1";
            button1.Size = new Size(244, 64);
            button1.TabIndex = 27;
            button1.Text = "Bayar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtTotalHarga);
            panel4.Location = new Point(91, 1125);
            panel4.Name = "panel4";
            panel4.Size = new Size(831, 60);
            panel4.TabIndex = 25;
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.BackColor = Color.FromArgb(158, 143, 177);
            txtTotalHarga.BorderStyle = BorderStyle.FixedSingle;
            txtTotalHarga.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalHarga.ForeColor = Color.White;
            txtTotalHarga.Location = new Point(5, 5);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(822, 50);
            txtTotalHarga.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(89, 1034);
            label20.Name = "label20";
            label20.Size = new Size(213, 50);
            label20.TabIndex = 24;
            label20.Text = "Total Harga";
            // 
            // cmboxmetode
            // 
            cmboxmetode.BackColor = Color.FromArgb(158, 143, 177);
            cmboxmetode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmboxmetode.ForeColor = Color.White;
            cmboxmetode.FormattingEnabled = true;
            cmboxmetode.Items.AddRange(new object[] { "BRI", "BCA", "Mandiri", "BSI", "Dana", "OVO", "ShoopePay" });
            cmboxmetode.Location = new Point(90, 936);
            cmboxmetode.Name = "cmboxmetode";
            cmboxmetode.Size = new Size(824, 53);
            cmboxmetode.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(90, 857);
            label19.Name = "label19";
            label19.Size = new Size(371, 50);
            label19.TabIndex = 22;
            label19.Text = "Metode Pembayaran";
            // 
            // cmboxpaketsewa
            // 
            cmboxpaketsewa.BackColor = Color.FromArgb(158, 143, 177);
            cmboxpaketsewa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmboxpaketsewa.ForeColor = Color.White;
            cmboxpaketsewa.FormattingEnabled = true;
            cmboxpaketsewa.Items.AddRange(new object[] { "Hari", "Minggu", "Bulan" });
            cmboxpaketsewa.Location = new Point(463, 756);
            cmboxpaketsewa.Name = "cmboxpaketsewa";
            cmboxpaketsewa.Size = new Size(239, 53);
            cmboxpaketsewa.TabIndex = 21;
            cmboxpaketsewa.SelectedIndexChanged += cmboxpaketsewa_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(463, 678);
            label18.Name = "label18";
            label18.Size = new Size(210, 50);
            label18.TabIndex = 20;
            label18.Text = "Paket Sewa";
            // 
            // cmboxdurasi
            // 
            cmboxdurasi.BackColor = Color.FromArgb(158, 143, 177);
            cmboxdurasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxdurasi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmboxdurasi.ForeColor = Color.White;
            cmboxdurasi.FormattingEnabled = true;
            cmboxdurasi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cmboxdurasi.Location = new Point(91, 756);
            cmboxdurasi.MaxDropDownItems = 5;
            cmboxdurasi.Name = "cmboxdurasi";
            cmboxdurasi.Size = new Size(239, 53);
            cmboxdurasi.TabIndex = 19;
            cmboxdurasi.SelectedIndexChanged += cmboxdurasi_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(91, 678);
            label17.Name = "label17";
            label17.Size = new Size(130, 50);
            label17.TabIndex = 18;
            label17.Text = "Durasi";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(cmboxjaminan);
            panel5.Location = new Point(84, 576);
            panel5.Name = "panel5";
            panel5.Size = new Size(831, 60);
            panel5.TabIndex = 17;
            // 
            // cmboxjaminan
            // 
            cmboxjaminan.BackColor = Color.FromArgb(158, 143, 177);
            cmboxjaminan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmboxjaminan.ForeColor = Color.White;
            cmboxjaminan.FormattingEnabled = true;
            cmboxjaminan.Items.AddRange(new object[] { "KTP", "Paspor" });
            cmboxjaminan.Location = new Point(5, 3);
            cmboxjaminan.Name = "cmboxjaminan";
            cmboxjaminan.Size = new Size(824, 53);
            cmboxjaminan.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(84, 506);
            label16.Name = "label16";
            label16.Size = new Size(162, 50);
            label16.TabIndex = 14;
            label16.Text = "Jaminan";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(datetglsewa);
            panel3.Location = new Point(84, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 60);
            panel3.TabIndex = 13;
            // 
            // datetglsewa
            // 
            datetglsewa.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetglsewa.CalendarForeColor = Color.White;
            datetglsewa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetglsewa.Location = new Point(7, 6);
            datetglsewa.Name = "datetglsewa";
            datetglsewa.Size = new Size(345, 50);
            datetglsewa.TabIndex = 12;
            datetglsewa.ValueChanged += datetglsewa_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(84, 315);
            label12.Name = "label12";
            label12.Size = new Size(352, 50);
            label12.TabIndex = 11;
            label12.Text = "Tanggal Penyewaan";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtboxpengambilan);
            panel2.Location = new Point(84, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 60);
            panel2.TabIndex = 5;
            // 
            // txtboxpengambilan
            // 
            txtboxpengambilan.BackColor = Color.FromArgb(158, 143, 177);
            txtboxpengambilan.BorderStyle = BorderStyle.FixedSingle;
            txtboxpengambilan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtboxpengambilan.ForeColor = Color.White;
            txtboxpengambilan.Location = new Point(5, 5);
            txtboxpengambilan.Name = "txtboxpengambilan";
            txtboxpengambilan.Size = new Size(822, 50);
            txtboxpengambilan.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(84, 160);
            label11.Name = "label11";
            label11.Size = new Size(371, 50);
            label11.TabIndex = 3;
            label11.Text = "Alamat Pengambilan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(90, 57);
            label10.Name = "label10";
            label10.Size = new Size(113, 50);
            label10.TabIndex = 0;
            label10.Text = "Sewa";
            // 
            // lbljenis
            // 
            lbljenis.AutoSize = true;
            lbljenis.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljenis.ForeColor = Color.White;
            lbljenis.Location = new Point(192, 57);
            lbljenis.Name = "lbljenis";
            lbljenis.Size = new Size(132, 50);
            lbljenis.TabIndex = 1;
            lbljenis.Text = "Motor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(313, 57);
            label9.Name = "label9";
            label9.Size = new Size(184, 50);
            label9.TabIndex = 10;
            label9.Text = "Sekarang";
            // 
            // DetailKendaraan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2854, 1729);
            Controls.Add(panel1);
            Controls.Add(lblhargabulanan);
            Controls.Add(lblhargamingguan);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(lblwarna);
            Controls.Add(lblmerk);
            Controls.Add(lbltahun);
            Controls.Add(lblplat);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Header);
            Controls.Add(lblketersediaan);
            Controls.Add(lblharga);
            Controls.Add(imgKendaraan);
            Controls.Add(lblnama);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetailKendaraan";
            Text = "DetailKendaraan";
            WindowState = FormWindowState.Maximized;
            Load += DetailKendaraan_Load;
            ((System.ComponentModel.ISupportInitialize)imgKendaraan).EndInit();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imglogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgprofil).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgRiwayat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnama;
        private PictureBox imgKendaraan;
        private Label lblharga;
        private Label lblketersediaan;
        private Label Judul;
        private Panel Header;
        private PictureBox imglogout;
        private PictureBox imgprofil;
        private PictureBox imgRiwayat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblplat;
        private Label lbltahun;
        private Label lblmerk;
        private Label lblwarna;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label lblhargamingguan;
        private Label lblhargabulanan;
        private Panel panel1;
        private TextBox txtboxpengambilan;
        private Label label11;
        private Label label10;
        private Label lbljenis;
        private Label label9;
        private Panel panel2;
        private Label label12;
        private DateTimePicker datetglsewa;
        private Panel panel3;
        private Label label16;
        private ComboBox cmboxjaminan;
        private Panel panel5;
        private ComboBox cmboxdurasi;
        private Label label17;
        private Label label20;
        private ComboBox cmboxmetode;
        private Label label19;
        private ComboBox cmboxpaketsewa;
        private Label label18;
        private Panel panel6;
        private Panel panel4;
        private TextBox txtTotalHarga;
        private Button button1;
    }
}