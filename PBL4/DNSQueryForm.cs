using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace PBL4
{
    public partial class DNSQueryForm : Form
    {
        public DNSQueryForm()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            String hostString = ("youtube.com");
            try
            {
                // Get 'IPHostEntry' object containing information like host name, IP addresses, aliases for a host.
                /*IPHostEntry hostInfo = Dns.GetHostByName(hostString);
                tbdns.Text += ("Host name : " + hostInfo.HostName);
                tbdns.Text += Environment.NewLine;
                tbdns.Text += ("IP address List : ");
                tbdns.Text += Environment.NewLine;

                for (int index = 0; index < hostInfo.AddressList.Length; index++)
                {
                    tbdns.Text += (hostInfo.AddressList[index]);
                    tbdns.Text += Environment.NewLine;
                }
*/

                IPHostEntry hostInfo = Dns.Resolve(hostString);
                // Get the IP address list that resolves to the host names contained in the
                // Alias property.
                IPAddress[] address = hostInfo.AddressList;
                // Get the alias names of the addresses in the IP address list.
                String[] alias = hostInfo.Aliases;

                tbdns.Text += ("Host name : " + hostInfo.HostName);
                tbdns.Text += Environment.NewLine;
                tbdns.Text += ("\nAliases : ");
                tbdns.Text += Environment.NewLine;
                for (int index = 0; index < alias.Length; index++)
                {
                    tbdns.Text += (alias[index]);
                    tbdns.Text += Environment.NewLine;
                }
                tbdns.Text += ("\nIP Address list :");
                tbdns.Text += Environment.NewLine;
                for (int index = 0; index < address.Length; index++)
                {
                    tbdns.Text += (address[index]);
                    tbdns.Text += Environment.NewLine;
                }

            }
            catch (SocketException e0)
            {
                Console.WriteLine("SocketException caught!!!");
                Console.WriteLine("Source : " + e0.Source);
                Console.WriteLine("Message : " + e0.Message);
            }
            catch (ArgumentNullException e1)
            {
                Console.WriteLine("ArgumentNullException caught!!!");
                Console.WriteLine("Source : " + e1.Source);
                Console.WriteLine("Message : " + e1.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e2.Source);
                Console.WriteLine("Message : " + e2.Message);
            }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {

                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    tbdns.Text += adapter.Description;
                    tbdns.Text += Environment.NewLine;
                    foreach (IPAddress dns in dnsServers)
                    {
                        Console.WriteLine("  DNS Servers  : {0}",
                            dns.ToString());
                        tbdns.Text += "  DNS Servers  : " + dns.ToString();
                        tbdns.Text += Environment.NewLine;
                        
                        if (dns.ToString() == "fec0:0:0:ffff::1%1") continue;
                        if (dns.ToString() == "fec0:0:0:ffff::2%1") continue;
                        if (dns.ToString() == "fec0:0:0:ffff::3%1") continue;
                        if (dns.ToString() == "fe80::1%10") continue;

                        if (!IPAddress.TryParse(dns.ToString(), out IPAddress address))
                            throw new ArgumentException(string.Format("{0} is not a valid IP address.", dns.ToString()));
                        IPHostEntry entry = Dns.GetHostEntry(address);
                        tbdns.Text += (entry.HostName);
                        tbdns.Text += Environment.NewLine;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
