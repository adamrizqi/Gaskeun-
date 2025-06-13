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
            Header = new Panel();
            pictureBox1 = new PictureBox();
            imgprofil = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgprofil).BeginInit();
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
            lblnama.Location = new Point(223, 128);
            lblnama.Margin = new Padding(2, 0, 2, 0);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(83, 32);
            lblnama.TabIndex = 2;
            lblnama.Text = "label1";
            // 
            // imgKendaraan
            // 
            imgKendaraan.Location = new Point(158, 183);
            imgKendaraan.Margin = new Padding(2);
            imgKendaraan.Name = "imgKendaraan";
            imgKendaraan.Size = new Size(778, 490);
            imgKendaraan.SizeMode = PictureBoxSizeMode.Zoom;
            imgKendaraan.TabIndex = 3;
            imgKendaraan.TabStop = false;
            // 
            // lblharga
            // 
            lblharga.AutoSize = true;
            lblharga.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblharga.Location = new Point(801, 810);
            lblharga.Margin = new Padding(2, 0, 2, 0);
            lblharga.Name = "lblharga";
            lblharga.Size = new Size(65, 25);
            lblharga.TabIndex = 4;
            lblharga.Text = "label1";
            // 
            // lblketersediaan
            // 
            lblketersediaan.AutoSize = true;
            lblketersediaan.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblketersediaan.Location = new Point(322, 956);
            lblketersediaan.Margin = new Padding(2, 0, 2, 0);
            lblketersediaan.Name = "lblketersediaan";
            lblketersediaan.Size = new Size(65, 25);
            lblketersediaan.TabIndex = 5;
            lblketersediaan.Text = "label2";
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Controls.Add(pictureBox1);
            Header.Controls.Add(imgprofil);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(2);
            Header.Name = "Header";
            Header.Size = new Size(1920, 92);
            Header.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_back_100;
            pictureBox1.Location = new Point(25, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // imgprofil
            // 
            imgprofil.Cursor = Cursors.Hand;
            imgprofil.Image = Properties.Resources.user__1_;
            imgprofil.Location = new Point(1854, 30);
            imgprofil.Margin = new Padding(2);
            imgprofil.Name = "imgprofil";
            imgprofil.Size = new Size(36, 36);
            imgprofil.SizeMode = PictureBoxSizeMode.Zoom;
            imgprofil.TabIndex = 3;
            imgprofil.TabStop = false;
            imgprofil.Click += imgprofil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 128);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 7;
            label1.Text = "Sewa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 738);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 8;
            label2.Text = "Spesifikasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(596, 738);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 9;
            label3.Text = "Daftar Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 810);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 10;
            label4.Text = "Plat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(183, 845);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 11;
            label5.Text = "Tahun";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(183, 883);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 12;
            label6.Text = "Merk";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(183, 920);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 13;
            label7.Text = "Warna";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(183, 956);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 14;
            label8.Text = "Status";
            // 
            // lblplat
            // 
            lblplat.AutoSize = true;
            lblplat.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblplat.Location = new Point(322, 810);
            lblplat.Margin = new Padding(2, 0, 2, 0);
            lblplat.Name = "lblplat";
            lblplat.Size = new Size(46, 25);
            lblplat.TabIndex = 15;
            lblplat.Text = "Plat";
            // 
            // lbltahun
            // 
            lbltahun.AutoSize = true;
            lbltahun.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltahun.Location = new Point(322, 845);
            lbltahun.Margin = new Padding(2, 0, 2, 0);
            lbltahun.Name = "lbltahun";
            lbltahun.Size = new Size(66, 25);
            lbltahun.TabIndex = 16;
            lbltahun.Text = "Tahun";
            // 
            // lblmerk
            // 
            lblmerk.AutoSize = true;
            lblmerk.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmerk.Location = new Point(322, 883);
            lblmerk.Margin = new Padding(2, 0, 2, 0);
            lblmerk.Name = "lblmerk";
            lblmerk.Size = new Size(59, 25);
            lblmerk.TabIndex = 17;
            lblmerk.Text = "Merk";
            // 
            // lblwarna
            // 
            lblwarna.AutoSize = true;
            lblwarna.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwarna.Location = new Point(322, 920);
            lblwarna.Margin = new Padding(2, 0, 2, 0);
            lblwarna.Name = "lblwarna";
            lblwarna.Size = new Size(70, 25);
            lblwarna.TabIndex = 18;
            lblwarna.Text = "Warna";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(596, 810);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(124, 25);
            label13.TabIndex = 19;
            label13.Text = "Harga Harian";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(596, 845);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(155, 25);
            label14.TabIndex = 20;
            label14.Text = "Harga Mingguan";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(596, 883);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(137, 25);
            label15.TabIndex = 21;
            label15.Text = "Harga Bulanan";
            // 
            // lblhargamingguan
            // 
            lblhargamingguan.AutoSize = true;
            lblhargamingguan.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhargamingguan.Location = new Point(801, 845);
            lblhargamingguan.Margin = new Padding(2, 0, 2, 0);
            lblhargamingguan.Name = "lblhargamingguan";
            lblhargamingguan.Size = new Size(65, 25);
            lblhargamingguan.TabIndex = 22;
            lblhargamingguan.Text = "label1";
            // 
            // lblhargabulanan
            // 
            lblhargabulanan.AutoSize = true;
            lblhargabulanan.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhargabulanan.Location = new Point(801, 883);
            lblhargabulanan.Margin = new Padding(2, 0, 2, 0);
            lblhargabulanan.Name = "lblhargabulanan";
            lblhargabulanan.Size = new Size(65, 25);
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
            panel1.Location = new Point(1152, 147);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 851);
            panel1.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(button1);
            panel6.Location = new Point(414, 784);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(151, 42);
            panel6.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(158, 143, 177);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 1);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 27;
            button1.Text = "Bayar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtTotalHarga);
            panel4.Location = new Point(56, 703);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(511, 38);
            panel4.TabIndex = 25;
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.BackColor = Color.FromArgb(158, 143, 177);
            txtTotalHarga.BorderStyle = BorderStyle.FixedSingle;
            txtTotalHarga.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalHarga.ForeColor = Color.White;
            txtTotalHarga.Location = new Point(3, 3);
            txtTotalHarga.Margin = new Padding(2);
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(507, 34);
            txtTotalHarga.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(55, 646);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(141, 32);
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
            cmboxmetode.Location = new Point(55, 585);
            cmboxmetode.Margin = new Padding(2);
            cmboxmetode.Name = "cmboxmetode";
            cmboxmetode.Size = new Size(509, 36);
            cmboxmetode.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(55, 536);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(241, 32);
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
            cmboxpaketsewa.Location = new Point(285, 472);
            cmboxpaketsewa.Margin = new Padding(2);
            cmboxpaketsewa.Name = "cmboxpaketsewa";
            cmboxpaketsewa.Size = new Size(149, 36);
            cmboxpaketsewa.TabIndex = 21;
            cmboxpaketsewa.SelectedIndexChanged += cmboxpaketsewa_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(285, 424);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(139, 32);
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
            cmboxdurasi.Location = new Point(56, 472);
            cmboxdurasi.Margin = new Padding(2);
            cmboxdurasi.MaxDropDownItems = 5;
            cmboxdurasi.Name = "cmboxdurasi";
            cmboxdurasi.Size = new Size(149, 36);
            cmboxdurasi.TabIndex = 19;
            cmboxdurasi.SelectedIndexChanged += cmboxdurasi_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(56, 424);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(83, 32);
            label17.TabIndex = 18;
            label17.Text = "Durasi";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(cmboxjaminan);
            panel5.Location = new Point(52, 360);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(511, 38);
            panel5.TabIndex = 17;
            // 
            // cmboxjaminan
            // 
            cmboxjaminan.BackColor = Color.FromArgb(158, 143, 177);
            cmboxjaminan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmboxjaminan.ForeColor = Color.White;
            cmboxjaminan.FormattingEnabled = true;
            cmboxjaminan.Items.AddRange(new object[] { "KTP", "Paspor" });
            cmboxjaminan.Location = new Point(3, 2);
            cmboxjaminan.Margin = new Padding(2);
            cmboxjaminan.Name = "cmboxjaminan";
            cmboxjaminan.Size = new Size(509, 36);
            cmboxjaminan.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(52, 316);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(105, 32);
            label16.TabIndex = 14;
            label16.Text = "Jaminan";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(datetglsewa);
            panel3.Location = new Point(52, 253);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 38);
            panel3.TabIndex = 13;
            // 
            // datetglsewa
            // 
            datetglsewa.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetglsewa.CalendarForeColor = Color.White;
            datetglsewa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetglsewa.Location = new Point(4, 4);
            datetglsewa.Margin = new Padding(2);
            datetglsewa.Name = "datetglsewa";
            datetglsewa.Size = new Size(214, 34);
            datetglsewa.TabIndex = 12;
            datetglsewa.ValueChanged += datetglsewa_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(52, 197);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(229, 32);
            label12.TabIndex = 11;
            label12.Text = "Tanggal Penyewaan";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtboxpengambilan);
            panel2.Location = new Point(52, 141);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 38);
            panel2.TabIndex = 5;
            // 
            // txtboxpengambilan
            // 
            txtboxpengambilan.BackColor = Color.FromArgb(158, 143, 177);
            txtboxpengambilan.BorderStyle = BorderStyle.FixedSingle;
            txtboxpengambilan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtboxpengambilan.ForeColor = Color.White;
            txtboxpengambilan.Location = new Point(3, 3);
            txtboxpengambilan.Margin = new Padding(2);
            txtboxpengambilan.Name = "txtboxpengambilan";
            txtboxpengambilan.PlaceholderText = "Optional";
            txtboxpengambilan.Size = new Size(507, 34);
            txtboxpengambilan.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(52, 100);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(240, 32);
            label11.TabIndex = 3;
            label11.Text = "Alamat Pengambilan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(55, 36);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 32);
            label10.TabIndex = 0;
            label10.Text = "Sewa";
            // 
            // lbljenis
            // 
            lbljenis.AutoSize = true;
            lbljenis.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljenis.ForeColor = Color.White;
            lbljenis.Location = new Point(119, 36);
            lbljenis.Margin = new Padding(2, 0, 2, 0);
            lbljenis.Name = "lbljenis";
            lbljenis.Size = new Size(86, 32);
            lbljenis.TabIndex = 1;
            lbljenis.Text = "Motor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(198, 36);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(119, 32);
            label9.TabIndex = 10;
            label9.Text = "Sekarang";
            // 
            // DetailKendaraan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1055);
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
            Margin = new Padding(2);
            Name = "DetailKendaraan";
            Text = "DetailKendaraan";
            WindowState = FormWindowState.Maximized;
            Load += DetailKendaraan_Load;
            ((System.ComponentModel.ISupportInitialize)imgKendaraan).EndInit();
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgprofil).EndInit();
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
        private Panel Header;
        private PictureBox imgprofil;
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
        private PictureBox pictureBox1;
    }
}