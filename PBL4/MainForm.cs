using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL4
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm = null;
        TracertForm tracertForm = new TracertForm();
        PingTool pingTool = new PingTool();
        Form1 form1 = new Form1();
        DNSQueryForm dNSQueryForm = new DNSQueryForm();

        public MainForm()
        {
            InitializeComponent();
            Control.SetIntial(this);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // open full-screen mode
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(94, 98, 107);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                //currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTotal.Controls.Add(childForm);
            panelTotal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(new DashBoard());
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(form1);
        }

        private void btnTracer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(tracertForm);
        }

        private void btnDNS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(dNSQueryForm);
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 163, 26));
            OpenChildForm(pingTool);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            Control.Minimize(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            Control.DoMaximize(this, btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control.DoFullscreen(this);
        }
    }
}