namespace Gaskeun_.View
{
    partial class ProfileForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblUsername = new Label();
            lblEmail = new Label();
            lblNoHp = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnUpload = new Button();
            btnChoose = new Button();
            image = new PictureBox();
            dataGridHistory = new DataGridView();
            JenisKendaraan = new DataGridViewTextBoxColumn();
            NamaKendaraan = new DataGridViewTextBoxColumn();
            TanggalSewa = new DataGridViewTextBoxColumn();
            TanggalPengembalian = new DataGridViewTextBoxColumn();
            AlamatPengambilan = new DataGridViewTextBoxColumn();
            Durasi = new DataGridViewTextBoxColumn();
            PaketSewa = new DataGridViewTextBoxColumn();
            MetodePembayaran = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(752, 115);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(79, 29);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(752, 199);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 29);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "label2";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoHp.Location = new Point(752, 289);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(79, 29);
            lblNoHp.TabIndex = 7;
            lblNoHp.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 115);
            label1.Name = "label1";
            label1.Size = new Size(124, 29);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(479, 199);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 12;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(479, 289);
            label3.Name = "label3";
            label3.Size = new Size(84, 29);
            label3.TabIndex = 13;
            label3.Text = "No HP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(670, 115);
            label6.Name = "label6";
            label6.Size = new Size(20, 29);
            label6.TabIndex = 16;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(670, 289);
            label7.Name = "label7";
            label7.Size = new Size(20, 29);
            label7.TabIndex = 17;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(670, 199);
            label8.Name = "label8";
            label8.Size = new Size(20, 29);
            label8.TabIndex = 18;
            label8.Text = ":";
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(33, 52, 72);
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnUpload.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Microsoft Sans Serif", 14F);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(231, 342);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(142, 52);
            btnUpload.TabIndex = 37;
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
            btnChoose.Font = new Font("Microsoft Sans Serif", 14F);
            btnChoose.ForeColor = Color.White;
            btnChoose.Location = new Point(66, 342);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(142, 52);
            btnChoose.TabIndex = 36;
            btnChoose.Text = "Choose";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click_1;
            // 
            // image
            // 
            image.BackColor = Color.Transparent;
            image.Location = new Point(66, 95);
            image.Name = "image";
            image.Size = new Size(307, 223);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 35;
            image.TabStop = false;
            // 
            // dataGridHistory
            // 
            dataGridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridHistory.ColumnHeadersHeight = 40;
            dataGridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridHistory.Columns.AddRange(new DataGridViewColumn[] { JenisKendaraan, NamaKendaraan, TanggalSewa, TanggalPengembalian, AlamatPengambilan, Durasi, PaketSewa, MetodePembayaran, Harga, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridHistory.EnableHeadersVisualStyles = false;
            dataGridHistory.Location = new Point(54, 461);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.RowHeadersWidth = 60;
            dataGridHistory.RowTemplate.Height = 40;
            dataGridHistory.Size = new Size(1811, 576);
            dataGridHistory.TabIndex = 38;
            // 
            // JenisKendaraan
            // 
            JenisKendaraan.DataPropertyName = "JenisKendaraan";
            JenisKendaraan.HeaderText = "Jenis Kendaraan";
            JenisKendaraan.MinimumWidth = 6;
            JenisKendaraan.Name = "JenisKendaraan";
            // 
            // NamaKendaraan
            // 
            NamaKendaraan.DataPropertyName = "NamaKendaraan";
            NamaKendaraan.HeaderText = "Nama Kendaraan";
            NamaKendaraan.MinimumWidth = 6;
            NamaKendaraan.Name = "NamaKendaraan";
            // 
            // TanggalSewa
            // 
            TanggalSewa.DataPropertyName = "TanggalSewa";
            TanggalSewa.HeaderText = "Tanggal Sewa";
            TanggalSewa.MinimumWidth = 6;
            TanggalSewa.Name = "TanggalSewa";
            // 
            // TanggalPengembalian
            // 
            TanggalPengembalian.DataPropertyName = "TanggalKembali";
            TanggalPengembalian.HeaderText = "Tanggal Pengembalian";
            TanggalPengembalian.MinimumWidth = 6;
            TanggalPengembalian.Name = "TanggalPengembalian";
            // 
            // AlamatPengambilan
            // 
            AlamatPengambilan.DataPropertyName = "AlamatPengambilan";
            AlamatPengambilan.HeaderText = "Alamat Pengambilan";
            AlamatPengambilan.MinimumWidth = 6;
            AlamatPengambilan.Name = "AlamatPengambilan";
            // 
            // Durasi
            // 
            Durasi.DataPropertyName = "Durasi";
            Durasi.HeaderText = "Durasi";
            Durasi.MinimumWidth = 6;
            Durasi.Name = "Durasi";
            // 
            // PaketSewa
            // 
            PaketSewa.DataPropertyName = "PaketSewa";
            PaketSewa.HeaderText = "Paket Sewa";
            PaketSewa.MinimumWidth = 6;
            PaketSewa.Name = "PaketSewa";
            // 
            // MetodePembayaran
            // 
            MetodePembayaran.DataPropertyName = "MetodePembayaran";
            MetodePembayaran.HeaderText = "Metode Pembayaran";
            MetodePembayaran.MinimumWidth = 6;
            MetodePembayaran.Name = "MetodePembayaran";
            // 
            // Harga
            // 
            Harga.DataPropertyName = "Harga";
            Harga.HeaderText = "Total Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_back_100;
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridHistory);
            Controls.Add(btnUpload);
            Controls.Add(btnChoose);
            Controls.Add(image);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNoHp);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "Form3";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private Label lblEmail;
        private Label lblNoHp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnUpload;
        private Button btnChoose;
        private PictureBox image;
        private DataGridView dataGridHistory;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn JenisKendaraan;
        private DataGridViewTextBoxColumn NamaKendaraan;
        private DataGridViewTextBoxColumn TanggalSewa;
        private DataGridViewTextBoxColumn TanggalPengembalian;
        private DataGridViewTextBoxColumn AlamatPengambilan;
        private DataGridViewTextBoxColumn Durasi;
        private DataGridViewTextBoxColumn PaketSewa;
        private DataGridViewTextBoxColumn MetodePembayaran;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}