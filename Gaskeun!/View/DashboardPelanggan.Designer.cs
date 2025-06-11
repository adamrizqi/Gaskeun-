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
        Header.Margin = new Padding(2);
        Header.Name = "Header";
        Header.Size = new Size(1920, 92);
        Header.TabIndex = 0;
        // 
        // imglogout
        // 
        imglogout.Cursor = Cursors.Hand;
        imglogout.Image = Properties.Resources.logout;
        imglogout.Location = new Point(1749, 34);
        imglogout.Margin = new Padding(2);
        imglogout.Name = "imglogout";
        imglogout.Size = new Size(25, 25);
        imglogout.SizeMode = PictureBoxSizeMode.Zoom;
        imglogout.TabIndex = 4;
        imglogout.TabStop = false;
        imglogout.Click += imglogout_Click;
        // 
        // imgprofil
        // 
        imgprofil.Image = Properties.Resources.user__1_;
        imgprofil.Location = new Point(1852, 28);
        imgprofil.Margin = new Padding(2);
        imgprofil.Name = "imgprofil";
        imgprofil.Size = new Size(36, 36);
        imgprofil.SizeMode = PictureBoxSizeMode.Zoom;
        imgprofil.TabIndex = 3;
        imgprofil.TabStop = false;
        // 
        // imgRiwayat
        // 
        imgRiwayat.Image = Properties.Resources.history;
        imgRiwayat.Location = new Point(1803, 34);
        imgRiwayat.Margin = new Padding(2);
        imgRiwayat.Name = "imgRiwayat";
        imgRiwayat.Size = new Size(25, 25);
        imgRiwayat.SizeMode = PictureBoxSizeMode.Zoom;
        imgRiwayat.TabIndex = 2;
        imgRiwayat.TabStop = false;
        // 
        // panelsearch
        // 
        panelsearch.Controls.Add(textSearch);
        panelsearch.Controls.Add(ikonsearch);
        panelsearch.Location = new Point(198, 22);
        panelsearch.Margin = new Padding(2);
        panelsearch.Name = "panelsearch";
        panelsearch.Size = new Size(745, 44);
        panelsearch.TabIndex = 1;
        panelsearch.Paint += panelsearch_Paint;
        // 
        // textSearch
        // 
        textSearch.BorderStyle = BorderStyle.None;
        textSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        textSearch.ForeColor = Color.FromArgb(172, 172, 172);
        textSearch.Location = new Point(58, 12);
        textSearch.Margin = new Padding(2);
        textSearch.Multiline = true;
        textSearch.Name = "textSearch";
        textSearch.Size = new Size(366, 30);
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
        ikonsearch.Location = new Point(14, 6);
        ikonsearch.Margin = new Padding(2);
        ikonsearch.Name = "ikonsearch";
        ikonsearch.Size = new Size(33, 34);
        ikonsearch.SizeMode = PictureBoxSizeMode.Zoom;
        ikonsearch.TabIndex = 0;
        ikonsearch.TabStop = false;
        // 
        // Judul
        // 
        Judul.AutoSize = true;
        Judul.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Judul.ForeColor = Color.FromArgb(110, 91, 208);
        Judul.Location = new Point(32, 30);
        Judul.Margin = new Padding(2, 0, 2, 0);
        Judul.Name = "Judul";
        Judul.Size = new Size(122, 32);
        Judul.TabIndex = 0;
        Judul.Text = "GasKeun!";
        // 
        // panelFilter
        // 
        panelFilter.Controls.Add(btnmotor);
        panelFilter.Controls.Add(btnmobil);
        panelFilter.Controls.Add(btnsemua);
        panelFilter.Location = new Point(44, 819);
        panelFilter.Margin = new Padding(2);
        panelFilter.Name = "panelFilter";
        panelFilter.Size = new Size(1831, 64);
        panelFilter.TabIndex = 2;
        // 
        // btnmotor
        // 
        btnmotor.FlatStyle = FlatStyle.Flat;
        btnmotor.Location = new Point(282, 18);
        btnmotor.Margin = new Padding(2);
        btnmotor.Name = "btnmotor";
        btnmotor.Size = new Size(92, 29);
        btnmotor.TabIndex = 2;
        btnmotor.Text = "Motor";
        btnmotor.UseVisualStyleBackColor = true;
        btnmotor.Click += btnmotor_Click;
        // 
        // btnmobil
        // 
        btnmobil.FlatStyle = FlatStyle.Flat;
        btnmobil.Location = new Point(166, 18);
        btnmobil.Margin = new Padding(2);
        btnmobil.Name = "btnmobil";
        btnmobil.Size = new Size(92, 29);
        btnmobil.TabIndex = 1;
        btnmobil.Text = "Mobil";
        btnmobil.UseVisualStyleBackColor = true;
        btnmobil.Click += btnmobil_Click;
        // 
        // btnsemua
        // 
        btnsemua.FlatStyle = FlatStyle.Flat;
        btnsemua.Location = new Point(47, 18);
        btnsemua.Margin = new Padding(2);
        btnsemua.Name = "btnsemua";
        btnsemua.Size = new Size(92, 29);
        btnsemua.TabIndex = 0;
        btnsemua.Text = "Semua";
        btnsemua.UseVisualStyleBackColor = true;
        btnsemua.Click += btnsemua_Click;
        // 
        // imgbanner
        // 
        imgbanner.Image = Properties.Resources.Screenshot_2025_05_17_124451;
        imgbanner.Location = new Point(2, 2);
        imgbanner.Margin = new Padding(2);
        imgbanner.Name = "imgbanner";
        imgbanner.Size = new Size(1812, 703);
        imgbanner.SizeMode = PictureBoxSizeMode.StretchImage;
        imgbanner.TabIndex = 1;
        imgbanner.TabStop = false;
        // 
        // flowkendaraan
        // 
        flowkendaraan.AutoScroll = true;
        flowkendaraan.Controls.Add(imgbanner);
        flowkendaraan.Location = new Point(44, 112);
        flowkendaraan.Margin = new Padding(2);
        flowkendaraan.Name = "flowkendaraan";
        flowkendaraan.Size = new Size(1876, 1005);
        flowkendaraan.TabIndex = 2;
        // 
        // DashboardPelanggan
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 249);
        ClientSize = new Size(1920, 1055);
        Controls.Add(panelFilter);
        Controls.Add(Header);
        Controls.Add(flowkendaraan);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(2);
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
