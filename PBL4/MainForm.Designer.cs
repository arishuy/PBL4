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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelTotal = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnPing = new FontAwesome.Sharp.IconButton();
            btnDNS = new FontAwesome.Sharp.IconButton();
            btnTracer = new FontAwesome.Sharp.IconButton();
            btnScan = new FontAwesome.Sharp.IconButton();
            btnTrangchu = new FontAwesome.Sharp.IconButton();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
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
            btnTracer.Text = "IP Tracert";
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
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.Controls.Add(this.guna2Button1);
            this.guna2GradientPanel2.Controls.Add(this.guna2Button2);
            this.guna2GradientPanel2.Controls.Add(this.guna2Button3);
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Controls.Add(this.guna2GradientPanel1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1159, 74);
            this.guna2GradientPanel2.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1029, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(37, 36);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "-";
            this.guna2Button1.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.FocusedColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Webdings", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1072, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(45, 36);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "1";
            this.guna2Button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.FocusedColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(1123, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(36, 36);
            this.guna2Button3.TabIndex = 9;
            this.guna2Button3.Text = "X";
            this.guna2Button3.TextFormatNoPrefix = true;
            this.guna2Button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic Network Tool";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 74);
            this.guna2GradientPanel1.TabIndex = 0;
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
            // panelMenu
            // 
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1159, 562);
            this.Controls.Add(this.panelTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMenu;
        private Guna.UI2.WinForms.Guna2GradientPanel panelTotal;
        private Guna.UI2.WinForms.Guna2GradientPanel panelDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}