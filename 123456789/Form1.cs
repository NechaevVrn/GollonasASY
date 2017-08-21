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
    public partial class Form1 : Form
    {
        DateTime dataserver;

        public Form1()
        {
            InitializeComponent();
        }

        private void WriteLog(string line)
        {
            string path = "/../../123.txt";
            FileInfo fi1 = new FileInfo(path);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(line);
            }
        }

       
        


private void Form1_Load(object sender, EventArgs e)
{
}


private void timer1_Tick(object sender, EventArgs e)
{
    ///получение списка процессов; 
    ServiceController server = new ServiceController("FirebirdServerDefaultInstance");
    ServiceController guard = new ServiceController("FirebirdGuardianDefaultInstance");
            FSDstatus.Text = Convert.ToString(server.Status);
            WriteLog(Convert.ToString(server.Status));
            if (server.Status == ServiceControllerStatus.Running)
            FSDstatus.ForeColor = Color.Green;
            else FSDstatus.ForeColor = Color.Red;
            

            FGDstatus.Text = Convert.ToString(guard.Status);
            if (guard.Status == ServiceControllerStatus.Running)  
            FGDstatus.ForeColor = Color.Green;
            else FGDstatus.ForeColor = Color.Red;

            Process[] processList = Process.GetProcesses();
            for (int i = 0; i < processList.Length; i++)
            {
               
            }

}


private void FSDstatus_DoubleClick_1(object sender, EventArgs e)
{
    ServiceController server = new ServiceController("FirebirdServerDefaultInstance");
    if (server.Status == ServiceControllerStatus.Running)
        server.Stop();
    else server.Start();
}
private void FGDstatus_DoubleClick(object sender, EventArgs e)
{
    ServiceController guard = new ServiceController("FirebirdGuardianDefaultInstance");
    if (guard.Status == ServiceControllerStatus.Running)
        guard.Stop();
    else guard.Start();
}

private void логированиеToolStripMenuItem_Click(object sender, EventArgs e)
{
    
}

private void timer1_Tick_1(object sender, EventArgs e)
{
    DateTime lastChanged1 = File.GetLastAccessTime(@"C:\SCAT\Workbin\DB\PROJECTS.FDB");
    DataProject.Text = Convert.ToString(lastChanged1);
    DateTime lastChanged2 = File.GetLastAccessTime(@"C:\SCAT\Workbin\DB\DATA.FDB");
    DataDATA.Text = Convert.ToString(lastChanged2);
}

private void label3_Click(object sender, EventArgs e)
{

}

private void groupBox3_Enter(object sender, EventArgs e)
{

}

private void listBox1_Click(object sender, EventArgs e)
{

}

private void ListenButton_Click(object sender, EventArgs e)
{
    Adress newAdress = new Adress();
    newAdress.Show();
}




    }
}
