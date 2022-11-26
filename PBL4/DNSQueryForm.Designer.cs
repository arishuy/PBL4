namespace PBL4
{
    partial class DNSQueryForm
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbdns = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.tbdns);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.button3);
            this.guna2GradientPanel1.Controls.Add(this.txtDomainName);
            this.guna2GradientPanel1.Controls.Add(this.button2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Gray;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Input domain:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Scan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(143, 51);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(173, 22);
            this.txtDomainName.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbdns
            // 
            this.tbdns.BackColor = System.Drawing.Color.Transparent;
            this.tbdns.BorderRadius = 15;
            this.tbdns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbdns.DefaultText = "";
            this.tbdns.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbdns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbdns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbdns.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbdns.FillColor = System.Drawing.Color.Silver;
            this.tbdns.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbdns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbdns.ForeColor = System.Drawing.Color.Black;
            this.tbdns.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbdns.Location = new System.Drawing.Point(411, 24);
            this.tbdns.Multiline = true;
            this.tbdns.Name = "tbdns";
            this.tbdns.PasswordChar = '\0';
            this.tbdns.PlaceholderText = "";
            this.tbdns.ReadOnly = true;
            this.tbdns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbdns.SelectedText = "";
            this.tbdns.Size = new System.Drawing.Size(320, 389);
            this.tbdns.TabIndex = 14;
            // 
            // DNSQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "DNSQueryForm";
            this.Text = "DNSQueryForm";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2TextBox tbdns;
    }
}