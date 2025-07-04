﻿namespace Gaskeun_.View
{
    partial class MobilData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnUpload = new Button();
            btnChoose = new Button();
            image = new PictureBox();
            panel5 = new Panel();
            label5 = new Label();
            tbHari = new TextBox();
            label9 = new Label();
            tbMinggu = new TextBox();
            tbBulan = new TextBox();
            label10 = new Label();
            btnHapus = new Button();
            btnUpdate = new Button();
            panel4 = new Panel();
            label12 = new Label();
            tbCC = new TextBox();
            label11 = new Label();
            tbGambar = new TextBox();
            cbStatus = new ComboBox();
            label7 = new Label();
            tbBensin = new TextBox();
            label8 = new Label();
            btnTambah = new Button();
            panel3 = new Panel();
            tbPlat = new TextBox();
            label2 = new Label();
            tbTahun = new TextBox();
            label6 = new Label();
            label4 = new Label();
            tbMerk = new TextBox();
            tbNamaMobil = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Status = new DataGridViewTextBoxColumn();
            HargaBulan = new DataGridViewTextBoxColumn();
            HargaMinggu = new DataGridViewTextBoxColumn();
            HargaHari = new DataGridViewTextBoxColumn();
            Gambar = new DataGridViewTextBoxColumn();
            KapasitasBensin = new DataGridViewTextBoxColumn();
            CC = new DataGridViewTextBoxColumn();
            Tahun = new DataGridViewTextBoxColumn();
            Merk = new DataGridViewTextBoxColumn();
            NamaMobil = new DataGridViewTextBoxColumn();
            Plat = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(btnChoose);
            panel1.Controls.Add(image);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(panel3);
            panel1.Font = new Font("Tahoma", 12F);
            panel1.Location = new Point(29, 598);
            panel1.Name = "panel1";
            panel1.Size = new Size(1577, 397);
            panel1.TabIndex = 4;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(33, 52, 72);
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnUpload.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Arial Rounded MT Bold", 14F);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(1399, 288);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(142, 52);
            btnUpload.TabIndex = 34;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.FromArgb(33, 52, 72);
            btnChoose.Cursor = Cursors.Hand;
            btnChoose.FlatAppearance.BorderSize = 0;
            btnChoose.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnChoose.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnChoose.FlatStyle = FlatStyle.Flat;
            btnChoose.Font = new Font("Arial Rounded MT Bold", 14F);
            btnChoose.ForeColor = Color.White;
            btnChoose.Location = new Point(1234, 288);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(142, 52);
            btnChoose.TabIndex = 33;
            btnChoose.Text = "Choose";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // image
            // 
            image.BackColor = Color.Transparent;
            image.Location = new Point(1234, 41);
            image.Name = "image";
            image.Size = new Size(307, 223);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 31;
            image.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(tbHari);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(tbMinggu);
            panel5.Controls.Add(tbBulan);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(824, 20);
            panel5.Margin = new Padding(3, 20, 30, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(363, 224);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(49, 24);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 9;
            label5.Text = "Harga per Hari";
            // 
            // tbHari
            // 
            tbHari.BorderStyle = BorderStyle.FixedSingle;
            tbHari.Font = new Font("Tahoma", 12F);
            tbHari.Location = new Point(205, 21);
            tbHari.Multiline = true;
            tbHari.Name = "tbHari";
            tbHari.Size = new Size(139, 31);
            tbHari.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(20, 101);
            label9.Name = "label9";
            label9.Size = new Size(169, 24);
            label9.TabIndex = 20;
            label9.Text = "Harga per Minggu";
            // 
            // tbMinggu
            // 
            tbMinggu.BorderStyle = BorderStyle.FixedSingle;
            tbMinggu.Font = new Font("Tahoma", 12F);
            tbMinggu.Location = new Point(205, 98);
            tbMinggu.Multiline = true;
            tbMinggu.Name = "tbMinggu";
            tbMinggu.Size = new Size(139, 31);
            tbMinggu.TabIndex = 21;
            // 
            // tbBulan
            // 
            tbBulan.BorderStyle = BorderStyle.FixedSingle;
            tbBulan.Font = new Font("Tahoma", 12F);
            tbBulan.Location = new Point(205, 172);
            tbBulan.Multiline = true;
            tbBulan.Name = "tbBulan";
            tbBulan.Size = new Size(139, 31);
            tbBulan.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(36, 175);
            label10.Name = "label10";
            label10.Size = new Size(155, 24);
            label10.TabIndex = 22;
            label10.Text = "Harga per Bulan";
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(33, 52, 72);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Arial Rounded MT Bold", 14F);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(824, 288);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(125, 52);
            btnHapus.TabIndex = 25;
            btnHapus.Text = "Remove";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 52, 72);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 14F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(537, 288);
            btnUpdate.Margin = new Padding(190, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 52);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label12);
            panel4.Controls.Add(tbCC);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(tbGambar);
            panel4.Controls.Add(cbStatus);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(tbBensin);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(432, 20);
            panel4.Margin = new Padding(94, 20, 30, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 235);
            panel4.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(93, 28);
            label12.Name = "label12";
            label12.Size = new Size(34, 24);
            label12.TabIndex = 29;
            label12.Text = "CC";
            // 
            // tbCC
            // 
            tbCC.BorderStyle = BorderStyle.FixedSingle;
            tbCC.Font = new Font("Tahoma", 12F);
            tbCC.Location = new Point(148, 24);
            tbCC.Multiline = true;
            tbCC.Name = "tbCC";
            tbCC.Size = new Size(139, 31);
            tbCC.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(9, 138);
            label11.Name = "label11";
            label11.Size = new Size(121, 24);
            label11.TabIndex = 27;
            label11.Text = "URL Gambar";
            // 
            // tbGambar
            // 
            tbGambar.BorderStyle = BorderStyle.FixedSingle;
            tbGambar.Font = new Font("Tahoma", 12F);
            tbGambar.Location = new Point(148, 133);
            tbGambar.Multiline = true;
            tbGambar.Name = "tbGambar";
            tbGambar.Size = new Size(139, 31);
            tbGambar.TabIndex = 28;
            tbGambar.TextChanged += tbGambar_TextChanged;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Tersedia", "Disewa" });
            cbStatus.Location = new Point(148, 187);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(139, 36);
            cbStatus.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(63, 84);
            label7.Name = "label7";
            label7.Size = new Size(69, 24);
            label7.TabIndex = 16;
            label7.Text = "Bensin";
            // 
            // tbBensin
            // 
            tbBensin.BorderStyle = BorderStyle.FixedSingle;
            tbBensin.Font = new Font("Tahoma", 12F);
            tbBensin.Location = new Point(148, 79);
            tbBensin.Multiline = true;
            tbBensin.Name = "tbBensin";
            tbBensin.Size = new Size(139, 31);
            tbBensin.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(64, 194);
            label8.Name = "label8";
            label8.Size = new Size(66, 24);
            label8.TabIndex = 18;
            label8.Text = "Status";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(33, 52, 72);
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnTambah.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Arial Rounded MT Bold", 14F);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(253, 288);
            btnTambah.Margin = new Padding(420, 3, 3, 3);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(122, 52);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Add";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbPlat);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(tbTahun);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbMerk);
            panel3.Controls.Add(tbNamaMobil);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(33, 20);
            panel3.Margin = new Padding(180, 20, 30, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 235);
            panel3.TabIndex = 27;
            // 
            // tbPlat
            // 
            tbPlat.BorderStyle = BorderStyle.FixedSingle;
            tbPlat.Font = new Font("Tahoma", 12F);
            tbPlat.Location = new Point(150, 23);
            tbPlat.Multiline = true;
            tbPlat.Name = "tbPlat";
            tbPlat.Size = new Size(139, 31);
            tbPlat.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 85);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 0;
            label2.Text = "Nama Mobil";
            // 
            // tbTahun
            // 
            tbTahun.BorderStyle = BorderStyle.FixedSingle;
            tbTahun.Font = new Font("Tahoma", 12F);
            tbTahun.Location = new Point(150, 192);
            tbTahun.Multiline = true;
            tbTahun.Name = "tbTahun";
            tbTahun.Size = new Size(139, 31);
            tbTahun.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(89, 26);
            label6.Name = "label6";
            label6.Size = new Size(44, 24);
            label6.TabIndex = 14;
            label6.Text = "Plat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(67, 196);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 7;
            label4.Text = "Tahun";
            // 
            // tbMerk
            // 
            tbMerk.BorderStyle = BorderStyle.FixedSingle;
            tbMerk.Font = new Font("Tahoma", 12F);
            tbMerk.Location = new Point(150, 136);
            tbMerk.Multiline = true;
            tbMerk.Name = "tbMerk";
            tbMerk.Size = new Size(139, 31);
            tbMerk.TabIndex = 6;
            // 
            // tbNamaMobil
            // 
            tbNamaMobil.BorderStyle = BorderStyle.FixedSingle;
            tbNamaMobil.Font = new Font("Tahoma", 12F);
            tbNamaMobil.Location = new Point(150, 82);
            tbNamaMobil.Multiline = true;
            tbNamaMobil.Name = "tbNamaMobil";
            tbNamaMobil.Size = new Size(139, 31);
            tbNamaMobil.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(80, 138);
            label3.Name = "label3";
            label3.Size = new Size(53, 24);
            label3.TabIndex = 5;
            label3.Text = "Merk";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(29, 29);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(40, 65, 40, 40);
            panel2.Size = new Size(1577, 542);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 1;
            label1.Text = "Data Mobil";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // HargaBulan
            // 
            HargaBulan.DataPropertyName = "HargaBulan";
            HargaBulan.HeaderText = "Harga/Bulan";
            HargaBulan.MinimumWidth = 6;
            HargaBulan.Name = "HargaBulan";
            // 
            // HargaMinggu
            // 
            HargaMinggu.DataPropertyName = "HargaMinggu";
            HargaMinggu.HeaderText = "Harga/Minggu";
            HargaMinggu.MinimumWidth = 6;
            HargaMinggu.Name = "HargaMinggu";
            // 
            // HargaHari
            // 
            HargaHari.DataPropertyName = "HargaHari";
            HargaHari.HeaderText = "Harga/Hari";
            HargaHari.MinimumWidth = 6;
            HargaHari.Name = "HargaHari";
            // 
            // Gambar
            // 
            Gambar.DataPropertyName = "Gambar";
            Gambar.HeaderText = "URL Gambar";
            Gambar.MinimumWidth = 6;
            Gambar.Name = "Gambar";
            // 
            // KapasitasBensin
            // 
            KapasitasBensin.DataPropertyName = "KapasitasBensin";
            KapasitasBensin.HeaderText = "Bensin";
            KapasitasBensin.MinimumWidth = 6;
            KapasitasBensin.Name = "KapasitasBensin";
            // 
            // CC
            // 
            CC.DataPropertyName = "CC";
            CC.HeaderText = "CC";
            CC.MinimumWidth = 6;
            CC.Name = "CC";
            // 
            // Tahun
            // 
            Tahun.DataPropertyName = "Tahun";
            Tahun.HeaderText = "Tahun";
            Tahun.MinimumWidth = 6;
            Tahun.Name = "Tahun";
            // 
            // Merk
            // 
            Merk.DataPropertyName = "Merk";
            Merk.HeaderText = "Merk";
            Merk.MinimumWidth = 6;
            Merk.Name = "Merk";
            // 
            // NamaMobil
            // 
            NamaMobil.DataPropertyName = "NamaKendaraan";
            NamaMobil.HeaderText = "Nama Mobil";
            NamaMobil.MinimumWidth = 6;
            NamaMobil.Name = "NamaMobil";
            // 
            // Plat
            // 
            Plat.DataPropertyName = "Plat";
            Plat.HeaderText = "Plat";
            Plat.MinimumWidth = 6;
            Plat.Name = "Plat";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Plat, NamaMobil, Merk, Tahun, CC, KapasitasBensin, Gambar, HargaHari, HargaMinggu, HargaBulan, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(34, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1507, 444);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // MobilData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "MobilData";
            Size = new Size(1637, 1025);
            Load += MobilData_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbStatus;
        private Button btnHapus;
        private Button btnUpdate;
        private TextBox tbBulan;
        private Label label10;
        private TextBox tbMinggu;
        private Label label9;
        private Label label8;
        private TextBox tbBensin;
        private Label label7;
        private TextBox tbPlat;
        private Label label6;
        private Button btnTambah;
        private TextBox tbHari;
        private Label label5;
        private TextBox tbTahun;
        private Label label4;
        private TextBox tbMerk;
        private Label label3;
        private TextBox tbNamaMobil;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Label label11;
        private TextBox tbGambar;
        private PictureBox image;
        private Label label12;
        private TextBox tbCC;
        private Button btnUpload;
        private Button btnChoose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Plat;
        private DataGridViewTextBoxColumn NamaMobil;
        private DataGridViewTextBoxColumn Merk;
        private DataGridViewTextBoxColumn Tahun;
        private DataGridViewTextBoxColumn CC;
        private DataGridViewTextBoxColumn KapasitasBensin;
        private DataGridViewTextBoxColumn Gambar;
        private DataGridViewTextBoxColumn HargaHari;
        private DataGridViewTextBoxColumn HargaMinggu;
        private DataGridViewTextBoxColumn HargaBulan;
        private DataGridViewTextBoxColumn Status;
    }
}
