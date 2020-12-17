using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace andrasnak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string source1 = @"\\fs\mindenki\it\invisible.vbs";
            string source2 = @"\\fs\mindenki\it\andras.bat";

            //string destination = System.Reflection.Assembly.GetEntryAssembly().Location;
            //string dirctory = Directory.GetCurrentDirectory();
            string dir = @"C:\Users\" + Environment.UserName + @"\Documents";

            if (!File.Exists(dir + "\\invisible.vbs"))
            {
                File.Copy(source1, dir + "\\invisible.vbs");
            }
            if (!File.Exists(dir + "\\andras.bat"))
            {
                File.Copy(source2, dir + "\\andras.bat");
            }


            this.Hide();
            //string command = "wscript.exe "+@"C:\Users\balindattila\Desktop\invisible.vbs "+@"C:\Users\balindattila\Desktop\andras.bat";
            string command2 = "wscript.exe " + dir + "\\invisible.vbs" + " " + dir + "\\andras.bat";
            Process proc = new Process();
            //proc.StartInfo.WorkingDirectory = "myWorkingDirectory";
            ////// proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
             proc.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
             proc.StartInfo.Arguments = "/c" + command2;
             proc.StartInfo.RedirectStandardOutput = true;
             proc.StartInfo.UseShellExecute = false;
            //// //proc.StartInfo.Arguments = @"tasklist /FI"+"'IMAGENAME eq POWERPNT.EXE'"+" 2>NUL | find /I /N "+"'POWERPNT.EXE'"+">NUL if NOT "+"'%ERRORLEVEL%'"+" == '0'"+" start"+"''"+"'C:\\Program Files\\Microsoft Office\\root\\Office16\\POWERPNT.EXE'";
             proc.Start();
             Environment.Exit(-1);
            

            

            //try
            //{
            //    Process.Start(command);
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.ToString());
            //}

        }
    }
}
