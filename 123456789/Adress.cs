using System;
using System.ServiceProcess;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace _123456789
{
    public partial class Adress : Form
    {
        public Adress()
        {
            InitializeComponent();
        }

        private void Adress_Load(object sender, EventArgs e)
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();
            int establishedConnections = 0;

            foreach (TcpConnectionInformation t in connections)
            {
                if (t.State == TcpState.Established)
                {
                    establishedConnections++;
                }
                listBox1.Items.Add(t.RemoteEndPoint.Address);

            }
            listBox1.Items.Add("There are {0} established TCP connections.");
            listBox1.Items.Add(establishedConnections);
        }
    }
}
