using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Gaskeun_.View
{
    partial class Card
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
            imgKendaraan = new PictureBox();
            lblnama = new Label();
            lblharga = new Label();
            lblketersediaan = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgKendaraan).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imgKendaraan
            // 
            imgKendaraan.Location = new Point(2, 42);
            imgKendaraan.Margin = new Padding(2);
            imgKendaraan.Name = "imgKendaraan";
            imgKendaraan.Size = new Size(249, 204);
            imgKendaraan.SizeMode = PictureBoxSizeMode.Zoom;
            imgKendaraan.TabIndex = 0;
            imgKendaraan.TabStop = false;
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnama.Location = new Point(22, 21);
            lblnama.Margin = new Padding(2, 0, 2, 0);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(51, 20);
            lblnama.TabIndex = 1;
            lblnama.Text = "label1";
            // 
            // lblharga
            // 
            lblharga.AutoSize = true;
            lblharga.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblharga.Location = new Point(26, 258);
            lblharga.Margin = new Padding(2, 0, 2, 0);
            lblharga.Name = "lblharga";
            lblharga.Size = new Size(50, 19);
            lblharga.TabIndex = 2;
            lblharga.Text = "label1";
            // 
            // lblketersediaan
            // 
            lblketersediaan.AutoSize = true;
            lblketersediaan.Font = new Font("Segoe UI", 8F);
            lblketersediaan.Location = new Point(157, 258);
            lblketersediaan.Margin = new Padding(2, 0, 2, 0);
            lblketersediaan.Name = "lblketersediaan";
            lblketersediaan.Size = new Size(45, 19);
            lblketersediaan.TabIndex = 3;
            lblketersediaan.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblnama);
            panel1.Controls.Add(lblketersediaan);
            panel1.Controls.Add(imgKendaraan);
            panel1.Controls.Add(lblharga);
            panel1.Location = new Point(14, 18);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 319);
            panel1.TabIndex = 4;
            panel1.TabStop = true;
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 249);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Card";
            Size = new Size(298, 358);
            ((System.ComponentModel.ISupportInitialize)imgKendaraan).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgKendaraan;
        private Label lblnama;
        private Label lblharga;
        private Label lblketersediaan;
        private Panel panel1;
    }
}
