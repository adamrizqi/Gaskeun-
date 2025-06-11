namespace Gaskeun_.View
{
    partial class TransaksiPelanggan
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dashboardBindingSource = new BindingSource(components);
            dashboardBindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            label3 = new Label();
            dtTglKeterlambatan = new DateTimePicker();
            cbStatus = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            tbHarga = new TextBox();
            btnUpdate = new Button();
            label12 = new Label();
            tbDenda = new TextBox();
            IdTransaksi = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            NamaKendaraan = new DataGridViewTextBoxColumn();
            TanggalSewa = new DataGridViewTextBoxColumn();
            TanggalKembali = new DataGridViewTextBoxColumn();
            TanggalKeterlambatan = new DataGridViewTextBoxColumn();
            Jaminan = new DataGridViewTextBoxColumn();
            PaketSewa = new DataGridViewTextBoxColumn();
            Durasi = new DataGridViewTextBoxColumn();
            Denda = new DataGridViewTextBoxColumn();
            MetodePembayaran = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(28, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1583, 724);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(240, 30);
            label1.TabIndex = 3;
            label1.Text = "Transaksi Pelanggan";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdTransaksi, Username, NamaKendaraan, TanggalSewa, TanggalKembali, TanggalKeterlambatan, Jaminan, PaketSewa, Durasi, Denda, MetodePembayaran, Harga, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(32, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1518, 628);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtTglKeterlambatan);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbHarga);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(tbDenda);
            panel2.Location = new Point(28, 783);
            panel2.Name = "panel2";
            panel2.Size = new Size(1583, 215);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(288, 35);
            label3.Name = "label3";
            label3.Size = new Size(220, 24);
            label3.TabIndex = 39;
            label3.Text = "Tanggal Keterlambatan";
            // 
            // dtTglKeterlambatan
            // 
            dtTglKeterlambatan.CalendarFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtTglKeterlambatan.Location = new Point(272, 77);
            dtTglKeterlambatan.Name = "dtTglKeterlambatan";
            dtTglKeterlambatan.Size = new Size(250, 27);
            dtTglKeterlambatan.TabIndex = 38;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Selesai", "Proses" });
            cbStatus.Location = new Point(1054, 68);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(139, 36);
            cbStatus.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(1088, 35);
            label8.Name = "label8";
            label8.Size = new Size(66, 24);
            label8.TabIndex = 36;
            label8.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(842, 35);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 34;
            label2.Text = "Total Harga";
            // 
            // tbHarga
            // 
            tbHarga.BorderStyle = BorderStyle.FixedSingle;
            tbHarga.Font = new Font("Tahoma", 12F);
            tbHarga.Location = new Point(831, 72);
            tbHarga.Multiline = true;
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(139, 31);
            tbHarga.TabIndex = 35;
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
            btnUpdate.Location = new Point(728, 139);
            btnUpdate.Margin = new Padding(190, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 52);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(645, 35);
            label12.Name = "label12";
            label12.Size = new Size(68, 24);
            label12.TabIndex = 32;
            label12.Text = "Denda";
            // 
            // tbDenda
            // 
            tbDenda.BorderStyle = BorderStyle.FixedSingle;
            tbDenda.Font = new Font("Tahoma", 12F);
            tbDenda.Location = new Point(609, 72);
            tbDenda.Multiline = true;
            tbDenda.Name = "tbDenda";
            tbDenda.Size = new Size(139, 31);
            tbDenda.TabIndex = 33;
            // 
            // IdTransaksi
            // 
            IdTransaksi.DataPropertyName = "IdTransaksi";
            IdTransaksi.HeaderText = "ID Transakasi";
            IdTransaksi.MinimumWidth = 6;
            IdTransaksi.Name = "IdTransaksi";
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // NamaKendaraan
            // 
            NamaKendaraan.DataPropertyName = "NamaKendaraan";
            NamaKendaraan.HeaderText = "Kendaraan";
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
            // TanggalKembali
            // 
            TanggalKembali.DataPropertyName = "TanggalKembali";
            TanggalKembali.HeaderText = "Tanggal Kembali";
            TanggalKembali.MinimumWidth = 6;
            TanggalKembali.Name = "TanggalKembali";
            // 
            // TanggalKeterlambatan
            // 
            TanggalKeterlambatan.DataPropertyName = "TanggalKeterlambatan";
            TanggalKeterlambatan.HeaderText = "Tanggal Keterlambatan";
            TanggalKeterlambatan.MinimumWidth = 6;
            TanggalKeterlambatan.Name = "TanggalKeterlambatan";
            // 
            // Jaminan
            // 
            Jaminan.DataPropertyName = "Jaminan";
            Jaminan.HeaderText = "Jaminan";
            Jaminan.MinimumWidth = 6;
            Jaminan.Name = "Jaminan";
            // 
            // PaketSewa
            // 
            PaketSewa.DataPropertyName = "PaketSewa";
            PaketSewa.HeaderText = "Paket Sewa";
            PaketSewa.MinimumWidth = 6;
            PaketSewa.Name = "PaketSewa";
            // 
            // Durasi
            // 
            Durasi.DataPropertyName = "Durasi";
            Durasi.HeaderText = "Durasi";
            Durasi.MinimumWidth = 6;
            Durasi.Name = "Durasi";
            // 
            // Denda
            // 
            Denda.DataPropertyName = "Denda";
            Denda.HeaderText = "Denda";
            Denda.MinimumWidth = 6;
            Denda.Name = "Denda";
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
            // TransaksiPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TransaksiPelanggan";
            Size = new Size(1637, 1025);
            Load += TransaksiPelanggan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource dashboardBindingSource;
        private BindingSource dashboardBindingSource1;
        private Panel panel2;
        private Button btnUpdate;
        private Label label12;
        private TextBox tbDenda;
        private Label label2;
        private TextBox tbHarga;
        private Label label3;
        private DateTimePicker dtTglKeterlambatan;
        private ComboBox cbStatus;
        private Label label8;
        private DataGridViewTextBoxColumn IdTransaksi;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn NamaKendaraan;
        private DataGridViewTextBoxColumn TanggalSewa;
        private DataGridViewTextBoxColumn TanggalKembali;
        private DataGridViewTextBoxColumn TanggalKeterlambatan;
        private DataGridViewTextBoxColumn Jaminan;
        private DataGridViewTextBoxColumn PaketSewa;
        private DataGridViewTextBoxColumn Durasi;
        private DataGridViewTextBoxColumn Denda;
        private DataGridViewTextBoxColumn MetodePembayaran;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Status;
    }
}
