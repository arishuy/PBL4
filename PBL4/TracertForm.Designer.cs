namespace PBL4
{
    partial class TracertForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.HopID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReplyTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReplyStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HopID,
            this.Address,
            this.HostName,
            this.ReplyTime,
            this.ReplyStatus});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 299);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // HopID
            // 
            this.HopID.Text = "HopID";
            this.HopID.Width = 70;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 141;
            // 
            // HostName
            // 
            this.HostName.Text = "HostName";
            this.HostName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HostName.Width = 165;
            // 
            // ReplyTime
            // 
            this.ReplyTime.Text = "ReplyTime";
            this.ReplyTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReplyTime.Width = 168;
            // 
            // ReplyStatus
            // 
            this.ReplyStatus.Text = "ReplyStatus";
            this.ReplyStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReplyStatus.Width = 210;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 2;
            // 
            // TracertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(872, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "TracertForm";
            this.Text = "Tracert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader HopID;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader HostName;
        private System.Windows.Forms.ColumnHeader ReplyTime;
        private System.Windows.Forms.ColumnHeader ReplyStatus;
    }
}