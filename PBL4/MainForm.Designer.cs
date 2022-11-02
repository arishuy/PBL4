namespace PBL4
{
    partial class MainForm
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
            FontAwesome.Sharp.IconButton btnPing;
            FontAwesome.Sharp.IconButton btnDNS;
            FontAwesome.Sharp.IconButton btnTracer;
            FontAwesome.Sharp.IconButton btnScan;
            FontAwesome.Sharp.IconButton btnTrangchu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelTotal = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnPing = new FontAwesome.Sharp.IconButton();
            btnDNS = new FontAwesome.Sharp.IconButton();
            btnTracer = new FontAwesome.Sharp.IconButton();
            btnScan = new FontAwesome.Sharp.IconButton();
            btnTrangchu = new FontAwesome.Sharp.IconButton();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Controls.Add(this.guna2GradientPanel1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1159, 74);
            this.guna2GradientPanel2.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 74);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnQuit);
            this.panelMenu.Controls.Add(btnPing);
            this.panelMenu.Controls.Add(btnDNS);
            this.panelMenu.Controls.Add(btnTracer);
            this.panelMenu.Controls.Add(btnScan);
            this.panelMenu.Controls.Add(btnTrangchu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.Transparent;
            this.panelMenu.FillColor2 = System.Drawing.Color.Transparent;
            this.panelMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelMenu.Location = new System.Drawing.Point(0, 74);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 488);
            this.panelMenu.TabIndex = 2;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Transparent;
            this.panelTotal.Controls.Add(this.panelDesktop);
            this.panelTotal.Controls.Add(this.panelMenu);
            this.panelTotal.Controls.Add(this.guna2GradientPanel2);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotal.FillColor = System.Drawing.Color.Gray;
            this.panelTotal.FillColor2 = System.Drawing.Color.Black;
            this.panelTotal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(1159, 562);
            this.panelTotal.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(959, 488);
            this.panelDesktop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic Network Tool";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuit.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnQuit.IconColor = System.Drawing.Color.White;
            this.btnQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuit.IconSize = 36;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(0, 330);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnQuit.Size = new System.Drawing.Size(200, 60);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPing
            // 
            btnPing.BackColor = System.Drawing.Color.Transparent;
            btnPing.FlatAppearance.BorderSize = 0;
            btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPing.ForeColor = System.Drawing.SystemColors.Control;
            btnPing.IconChar = FontAwesome.Sharp.IconChar.WifiStrong;
            btnPing.IconColor = System.Drawing.Color.White;
            btnPing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPing.IconSize = 36;
            btnPing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPing.Location = new System.Drawing.Point(0, 264);
            btnPing.Name = "btnPing";
            btnPing.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnPing.Size = new System.Drawing.Size(200, 60);
            btnPing.TabIndex = 15;
            btnPing.Text = "Ping Tool";
            btnPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPing.UseVisualStyleBackColor = false;
            btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnDNS
            // 
            btnDNS.BackColor = System.Drawing.Color.Transparent;
            btnDNS.FlatAppearance.BorderSize = 0;
            btnDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDNS.ForeColor = System.Drawing.SystemColors.Control;
            btnDNS.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            btnDNS.IconColor = System.Drawing.Color.White;
            btnDNS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDNS.IconSize = 36;
            btnDNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDNS.Location = new System.Drawing.Point(0, 198);
            btnDNS.Name = "btnDNS";
            btnDNS.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnDNS.Size = new System.Drawing.Size(200, 60);
            btnDNS.TabIndex = 12;
            btnDNS.Text = "DNS Query";
            btnDNS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDNS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDNS.UseVisualStyleBackColor = false;
            btnDNS.Click += new System.EventHandler(this.btnDNS_Click);
            // 
            // btnTracer
            // 
            btnTracer.BackColor = System.Drawing.Color.Transparent;
            btnTracer.Cursor = System.Windows.Forms.Cursors.Arrow;
            btnTracer.FlatAppearance.BorderSize = 0;
            btnTracer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTracer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTracer.ForeColor = System.Drawing.SystemColors.Control;
            btnTracer.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnTracer.IconColor = System.Drawing.Color.White;
            btnTracer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTracer.IconSize = 36;
            btnTracer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTracer.Location = new System.Drawing.Point(0, 132);
            btnTracer.Name = "btnTracer";
            btnTracer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnTracer.Size = new System.Drawing.Size(200, 60);
            btnTracer.TabIndex = 13;
            btnTracer.Text = "IP Tracer";
            btnTracer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTracer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTracer.UseVisualStyleBackColor = false;
            btnTracer.Click += new System.EventHandler(this.btnTracer_Click);
            // 
            // btnScan
            // 
            btnScan.BackColor = System.Drawing.Color.Transparent;
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnScan.ForeColor = System.Drawing.SystemColors.Control;
            btnScan.IconChar = FontAwesome.Sharp.IconChar.GaugeSimpleHigh;
            btnScan.IconColor = System.Drawing.Color.White;
            btnScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScan.IconSize = 36;
            btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnScan.Location = new System.Drawing.Point(0, 66);
            btnScan.Name = "btnScan";
            btnScan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnScan.Size = new System.Drawing.Size(200, 60);
            btnScan.TabIndex = 14;
            btnScan.Text = "Scan IP";
            btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnTrangchu
            // 
            btnTrangchu.BackColor = System.Drawing.Color.Transparent;
            btnTrangchu.FlatAppearance.BorderSize = 0;
            btnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTrangchu.ForeColor = System.Drawing.SystemColors.Control;
            btnTrangchu.IconChar = FontAwesome.Sharp.IconChar.Home;
            btnTrangchu.IconColor = System.Drawing.Color.White;
            btnTrangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrangchu.IconSize = 36;
            btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTrangchu.Location = new System.Drawing.Point(0, 0);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnTrangchu.Size = new System.Drawing.Size(200, 60);
            btnTrangchu.TabIndex = 11;
            btnTrangchu.Text = "Dash Board";
            btnTrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTrangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTrangchu.UseVisualStyleBackColor = false;
            btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL4.Properties.Resources.favpng_computer_network_button_download;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 562);
            this.Controls.Add(this.panelTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMenu;
        private FontAwesome.Sharp.IconButton btnQuit;
        private Guna.UI2.WinForms.Guna2GradientPanel panelTotal;
        private Guna.UI2.WinForms.Guna2GradientPanel panelDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}