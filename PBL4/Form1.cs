using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
namespace PBL4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            String myping = textBox1.Text;
            Ping p1 = new Ping();
            PingReply PR = p1.Send(myping);
            label2.Text = PR.Status.ToString();
            p1.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subnet = txtIP.Text.Substring(0, txtIP.Text.LastIndexOf("."));
            progressBar.Maximum = 254;
            progressBar.Value = 0;
            lvResult.Items.Clear();

            Task.Factory.StartNew(new Action(() =>
            {
                for (int i = 2; i < 255; i++)
                {
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                lvResult.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Up" }));
                            }
                            catch
                            {
                            }
                            progressBar.Value += 1;
                            lblStatus.ForeColor = Color.Blue;
                            lblStatus.Text = $"Scanning: {ip}";
                            if (progressBar.Value == 253)
                                lblStatus.Text = "Finished";
                        }));
                    }
                    else
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {
                            progressBar.Value += 1;
                            lblStatus.ForeColor = Color.DarkGray;
                            lblStatus.Text = $"Scanning: {ip}";
                            //lvResult.Items.Add(new ListViewItem(new String[] { ip, "", "Down" }));
                            if (progressBar.Value == 253)
                            {
                                lblStatus.Text = "Finished";
                                progressBar.Value = 0;
                            }
                        }));
                    }
                }
            }));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            

            //throw new InvalidOperationException("Unable to find DNS Address");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    Console.WriteLine(adapter.Description);
                    foreach (IPAddress dns in dnsServers)
                    {
                        Console.WriteLine("  DNS Servers ............................. : {0}",
                            dns.ToString());
                    }
                    Console.WriteLine();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                    txtIP.Text = ip.ToString();
                }
                }
            }
        }
    }