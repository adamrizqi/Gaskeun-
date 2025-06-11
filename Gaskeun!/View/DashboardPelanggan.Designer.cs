using System.Reflection;

namespace Gaskeun_.View;

partial class DashboardPelanggan
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Header = new Panel();
        imglogout = new PictureBox();
        imgprofil = new PictureBox();
        imgRiwayat = new PictureBox();
        panelsearch = new Panel();
        textSearch = new TextBox();
        ikonsearch = new PictureBox();
        Judul = new Label();
        panelFilter = new Panel();
        btnmotor = new Button();
        btnmobil = new Button();
        btnsemua = new Button();
        imgbanner = new PictureBox();
        flowkendaraan = new FlowLayoutPanel();
        Header.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)imglogout).BeginInit();
        ((System.ComponentModel.ISupportInitialize)imgprofil).BeginInit();
        ((System.ComponentModel.ISupportInitialize)imgRiwayat).BeginInit();
        panelsearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ikonsearch).BeginInit();
        panelFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)imgbanner).BeginInit();
        flowkendaraan.SuspendLayout();
        SuspendLayout();
        // 
        // Header
        // 
        Header.BackColor = Color.White;
        Header.Controls.Add(imglogout);
        Header.Controls.Add(imgprofil);
        Header.Controls.Add(imgRiwayat);
        Header.Controls.Add(panelsearch);
        Header.Controls.Add(Judul);
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Name = "Header";
        Header.Size = new Size(2910, 147);
        Header.TabIndex = 0;
        // 
        // imglogout
        // 
        imglogout.Cursor = Cursors.Hand;
        imglogout.Image = Properties.Resources.logout;
        imglogout.Location = new Point(2592, 58);
        imglogout.Name = "imglogout";
        imglogout.Size = new Size(41, 40);
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
        imgRiwayat.Location = new Point(2680, 58);
        imgRiwayat.Name = "imgRiwayat";
        imgRiwayat.Size = new Size(41, 40);
        imgRiwayat.SizeMode = PictureBoxSizeMode.Zoom;
        imgRiwayat.TabIndex = 2;
        imgRiwayat.TabStop = false;
        // 
        // panelsearch
        // 
        panelsearch.Controls.Add(textSearch);
        panelsearch.Controls.Add(ikonsearch);
        panelsearch.Location = new Point(322, 35);
        panelsearch.Name = "panelsearch";
        panelsearch.Size = new Size(1211, 70);
        panelsearch.TabIndex = 1;
        panelsearch.Paint += panelsearch_Paint;
        // 
        // textSearch
        // 
        textSearch.BorderStyle = BorderStyle.None;
        textSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        textSearch.ForeColor = Color.FromArgb(172, 172, 172);
        textSearch.Location = new Point(94, 19);
        textSearch.Multiline = true;
        textSearch.Name = "textSearch";
        textSearch.Size = new Size(595, 48);
        textSearch.TabIndex = 99;
        textSearch.TabStop = false;
        textSearch.Text = "Search anything";
        textSearch.TextChanged += textSearch_TextChanged;
        textSearch.Enter += textSearch_Enter;
        textSearch.KeyDown += textSearch_KeyDown;
        textSearch.Leave += textSearch_Leave;
        // 
        // ikonsearch
        // 
        ikonsearch.Image = Properties.Resources.zoom_tool__1_;
        ikonsearch.Location = new Point(23, 10);
        ikonsearch.Name = "ikonsearch";
        ikonsearch.Size = new Size(54, 54);
        ikonsearch.SizeMode = PictureBoxSizeMode.Zoom;
        ikonsearch.TabIndex = 0;
        ikonsearch.TabStop = false;
        // 
        // Judul
        // 
        Judul.AutoSize = true;
        Judul.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Judul.ForeColor = Color.FromArgb(110, 91, 208);
        Judul.Location = new Point(52, 48);
        Judul.Name = "Judul";
        Judul.Size = new Size(184, 50);
        Judul.TabIndex = 0;
        Judul.Text = "GasKeun!";
        // 
        // panelFilter
        // 
        panelFilter.Controls.Add(btnmotor);
        panelFilter.Controls.Add(btnmobil);
        panelFilter.Controls.Add(btnsemua);
        panelFilter.Location = new Point(72, 1310);
        panelFilter.Name = "panelFilter";
        panelFilter.Size = new Size(2693, 102);
        panelFilter.TabIndex = 2;
        // 
        // btnmotor
        // 
        btnmotor.FlatStyle = FlatStyle.Flat;
        btnmotor.Location = new Point(458, 29);
        btnmotor.Name = "btnmotor";
        btnmotor.Size = new Size(150, 46);
        btnmotor.TabIndex = 2;
        btnmotor.Text = "Motor";
        btnmotor.UseVisualStyleBackColor = true;
        btnmotor.Click += btnmotor_Click;
        // 
        // btnmobil
        // 
        btnmobil.FlatStyle = FlatStyle.Flat;
        btnmobil.Location = new Point(270, 29);
        btnmobil.Name = "btnmobil";
        btnmobil.Size = new Size(150, 46);
        btnmobil.TabIndex = 1;
        btnmobil.Text = "Mobil";
        btnmobil.UseVisualStyleBackColor = true;
        btnmobil.Click += btnmobil_Click;
        // 
        // btnsemua
        // 
        btnsemua.FlatStyle = FlatStyle.Flat;
        btnsemua.Location = new Point(76, 29);
        btnsemua.Name = "btnsemua";
        btnsemua.Size = new Size(150, 46);
        btnsemua.TabIndex = 0;
        btnsemua.Text = "Semua";
        btnsemua.UseVisualStyleBackColor = true;
        btnsemua.Click += btnsemua_Click;
        // 
        // imgbanner
        // 
        imgbanner.Image = Properties.Resources.Screenshot_2025_05_17_124451;
        imgbanner.Location = new Point(3, 3);
        imgbanner.Name = "imgbanner";
        imgbanner.Size = new Size(2693, 1125);
        imgbanner.SizeMode = PictureBoxSizeMode.StretchImage;
        imgbanner.TabIndex = 1;
        imgbanner.TabStop = false;
        // 
        // flowkendaraan
        // 
        flowkendaraan.AutoScroll = true;
        flowkendaraan.Controls.Add(imgbanner);
        flowkendaraan.Location = new Point(72, 179);
        flowkendaraan.Name = "flowkendaraan";
        flowkendaraan.Size = new Size(2797, 1608);
        flowkendaraan.TabIndex = 2;
        // 
        // DashboardPelanggan
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 249);
        ClientSize = new Size(2910, 1830);
        Controls.Add(panelFilter);
        Controls.Add(Header);
        Controls.Add(flowkendaraan);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "DashboardPelanggan";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard";
        WindowState = FormWindowState.Maximized;
        Load += Dashboard_Load;
        Header.ResumeLayout(false);
        Header.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)imglogout).EndInit();
        ((System.ComponentModel.ISupportInitialize)imgprofil).EndInit();
        ((System.ComponentModel.ISupportInitialize)imgRiwayat).EndInit();
        panelsearch.ResumeLayout(false);
        panelsearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)ikonsearch).EndInit();
        panelFilter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)imgbanner).EndInit();
        flowkendaraan.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel Header;
    private Label Judul;
    private Panel panelsearch;
    private TextBox textSearch;
    private PictureBox ikonsearch;
    private PictureBox imgRiwayat;
    private PictureBox imgprofil;
    private PictureBox imglogout;
    private Panel panelFilter;
    private PictureBox imgbanner;
    private FlowLayoutPanel flowkendaraan;
    private Button btnmotor;
    private Button btnmobil;
    private Button btnsemua;
}
