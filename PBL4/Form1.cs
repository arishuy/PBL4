﻿using BrightIdeasSoftware;
using System;
using System.Drawing;
using System.IO.Pipes;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
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
            if (myping == "")
            {
                MessageBox.Show("Please enter a valid IP address");
            }
            else
            {
                Ping p1 = new Ping();
                PingReply PR = p1.Send(myping);
                if (PR.Status == IPStatus.Success)
                {
                    label2.ForeColor = Color.Green;
                    label2.Text = "Ping to " + myping + " was successful";
                }
                else
                {
                label2.ForeColor = Color.Red;

                    label2.Text = "Ping to " + myping + " was unsuccessful";
                }
                p1.Dispose();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subnet = txtIP.Text.Substring(0, txtIP.Text.LastIndexOf("."));
            progressBar.Maximum = 254;
            progressBar.Value = 0;
            lvResult.Items.Clear();
            lbStatus.ForeColor = Color.Blue;
            lbStatus.Text = "Scanning...";
            Task.Factory.StartNew(new Action(() =>
            {
                Parallel.For(2, 255, (i) =>
                //for (int i = 2; i < 255; i++)
                {
                    int timeout = 500;
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingOptions pingOptions = new PingOptions(1, true);
                    PingReply reply = ping.Send(ip, timeout, new byte[] { 0 }, pingOptions);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {

                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                lvResult.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Active" }));
                            }
                            catch (SocketException ex)
                            {
                                lvResult.Items.Add(new ListViewItem(new String[] { ip, "Unknown", "Active" }));
                            }
                            progressBar.Value += 1;

                            if (progressBar.Value == 253)
                            {
                                lbStatus.ForeColor = Color.Green;
                                lbStatus.Text = "Finished";
                            }

                        }));
                    }
                    else
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {
                            progressBar.Value += 1;

                            //lvResult.Items.Add(new ListViewItem(new String[] { ip, "", "Down" }));
                            if (progressBar.Value == 253)
                            {
                                lbStatus.ForeColor = Color.Green;
                                lbStatus.Text = "Finished";
                                progressBar.Value = 0;
                            }
                        }));
                    }
                });
            }));
        }
        private void button3_Click(object sender, EventArgs e)
        {

            tbdns.Text = "";
            //throw new InvalidOperationException("Unable to find DNS Address");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    tbdns.Text+=adapter.Description;
                    tbdns.Text += Environment.NewLine;
                    foreach (IPAddress dns in dnsServers)
                    {
                        Console.WriteLine("  DNS Servers  : {0}",
                            dns.ToString());
                        tbdns.Text += "  DNS Servers  : " + dns.ToString();
                        tbdns.Text += Environment.NewLine;
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

        private void button4_Click(object sender, EventArgs e)
        {
            TracertForm tracert = new TracertForm();
            tracert.Show();
        }
    }
}