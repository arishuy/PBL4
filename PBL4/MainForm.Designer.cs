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
            FontAwesome.Sharp.IconButton btnTrangchu;
            FontAwesome.Sharp.IconButton btnScan;
            FontAwesome.Sharp.IconButton btnTracer;
            FontAwesome.Sharp.IconButton btnDNS;
            FontAwesome.Sharp.IconButton btnPing;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            btnTrangchu = new FontAwesome.Sharp.IconButton();
            btnScan = new FontAwesome.Sharp.IconButton();
            btnTracer = new FontAwesome.Sharp.IconButton();
            btnDNS = new FontAwesome.Sharp.IconButton();
            btnPing = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrangchu
            // 
            btnTrangchu.FlatAppearance.BorderSize = 0;
            btnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTrangchu.ForeColor = System.Drawing.SystemColors.Control;
            btnTrangchu.IconChar = FontAwesome.Sharp.IconChar.Home;
            btnTrangchu.IconColor = System.Drawing.Color.White;
            btnTrangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrangchu.IconSize = 36;
            btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTrangchu.Location = new System.Drawing.Point(0, 74);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnTrangchu.Size = new System.Drawing.Size(200, 60);
            btnTrangchu.TabIndex = 6;
            btnTrangchu.Text = "Dash Board";
            btnTrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTrangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTrangchu.UseVisualStyleBackColor = true;
            btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // btnScan
            // 
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnScan.ForeColor = System.Drawing.SystemColors.Control;
            btnScan.IconChar = FontAwesome.Sharp.IconChar.GaugeSimpleHigh;
            btnScan.IconColor = System.Drawing.Color.White;
            btnScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScan.IconSize = 36;
            btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnScan.Location = new System.Drawing.Point(0, 143);
            btnScan.Name = "btnScan";
            btnScan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnScan.Size = new System.Drawing.Size(200, 60);
            btnScan.TabIndex = 7;
            btnScan.Text = "Scan IP";
            btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnTracer
            // 
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
            btnTracer.Location = new System.Drawing.Point(0, 209);
            btnTracer.Name = "btnTracer";
            btnTracer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnTracer.Size = new System.Drawing.Size(200, 60);
            btnTracer.TabIndex = 7;
            btnTracer.Text = "IP Tracer";
            btnTracer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTracer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTracer.UseVisualStyleBackColor = true;
            btnTracer.Click += new System.EventHandler(this.btnTracer_Click);
            // 
            // btnDNS
            // 
            btnDNS.FlatAppearance.BorderSize = 0;
            btnDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDNS.ForeColor = System.Drawing.SystemColors.Control;
            btnDNS.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            btnDNS.IconColor = System.Drawing.Color.White;
            btnDNS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDNS.IconSize = 36;
            btnDNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDNS.Location = new System.Drawing.Point(0, 265);
            btnDNS.Name = "btnDNS";
            btnDNS.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnDNS.Size = new System.Drawing.Size(200, 60);
            btnDNS.TabIndex = 7;
            btnDNS.Text = "DNS Query";
            btnDNS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDNS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDNS.UseVisualStyleBackColor = true;
            btnDNS.Click += new System.EventHandler(this.btnDNS_Click);
            // 
            // btnPing
            // 
            btnPing.FlatAppearance.BorderSize = 0;
            btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPing.ForeColor = System.Drawing.SystemColors.Control;
            btnPing.IconChar = FontAwesome.Sharp.IconChar.WifiStrong;
            btnPing.IconColor = System.Drawing.Color.White;
            btnPing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPing.IconSize = 36;
            btnPing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPing.Location = new System.Drawing.Point(0, 331);
            btnPing.Name = "btnPing";
            btnPing.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnPing.Size = new System.Drawing.Size(200, 60);
            btnPing.TabIndex = 8;
            btnPing.Text = "Ping Tool";
            btnPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(199)))), ((int)(((byte)(136)))));
            this.panelDesktop.Controls.Add(this.panel3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1010, 616);
            this.panelDesktop.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 74);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basic Network Tool";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnQuit);
            this.panelMenu.Controls.Add(btnPing);
            this.panelMenu.Controls.Add(btnDNS);
            this.panelMenu.Controls.Add(btnTracer);
            this.panelMenu.Controls.Add(btnScan);
            this.panelMenu.Controls.Add(btnTrangchu);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 616);
            this.panelMenu.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuit.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnQuit.IconColor = System.Drawing.Color.White;
            this.btnQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuit.IconSize = 36;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(0, 397);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnQuit.Size = new System.Drawing.Size(200, 60);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTl
            // 
            this.panelTl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTl.Controls.Add(this.label1);
            this.panelTl.Location = new System.Drawing.Point(0, 0);
            this.panelTl.Name = "panelTl";
            this.panelTl.Size = new System.Drawing.Size(991, 74);
            this.panelTl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 616);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelDesktop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTl.ResumeLayout(false);
            this.panelTl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}