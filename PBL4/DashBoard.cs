using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Management;
using Microsoft.Win32;

namespace PBL4
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        private string GetMacAddress()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up)
                {
                    addr += n.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return addr;
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            label3.Text = Dns.GetHostName().ToString();
            labelMac.Text = GetMacAddress();
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipCombo.Items.Add(ip.ToString());
                }
            }
            ipCombo.SelectedIndex = 0;
            lbInfo.Text = getOperatingSystemInfo();
            label7.Text = getProcessorInfo();
            label8.Text = getRamInfo();
        }
        public static string getOperatingSystemInfo()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["Caption"] != null)
                {
                    if (managementObject["OSArchitecture"] != null)
                        return managementObject["Caption"].ToString() + " " + managementObject["OSArchitecture"].ToString();   //Display operating system caption
                    else
                        return managementObject["Caption"].ToString();
                }
            }
            return "Unknown";
        }

        public static string getProcessorInfo()
        {
            string processorName = "";
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    processorName = processor_name.GetValue("ProcessorNameString").ToString();  //Display processor ingo.
                }
            }
            return processorName;
        }
        public static string getRamInfo()
        {
            string memoryDevice = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["TotalPhysicalMemory"] != null)
                {
                    double a = Convert.ToDouble(managementObject["TotalPhysicalMemory"].ToString());
                    double b = a / 1024 / 1024 / 1024;
                    b = Math.Ceiling(b);
                    memoryDevice = b.ToString() + " GB";  //Display processor ingo.
                }
            }
            return memoryDevice;
        }
    }
}
