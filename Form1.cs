using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct PROCESS_INFO
        {
            public uint Fields;
            public string bstrFileName;
            public string bstrBaseName;
            public string bstrTitle;
            //public AD_PROCESS_ID ProcessId;
            public uint dwSessionId;
            public string bstrAttachedSessionName;
            //public FILETIME CreationTime;
            public uint Flags;
        };


        private void Button1_Click(object sender, EventArgs e)
        {
            //关闭应用程序
            //打开CHROME
            //PATH: C: \Users\Administrator\AppData\Local\Google\Chrome\Application\chrome.exe
            //CreateProcess

            Process.Start(@"C:\Users");
            Process.Start(@"C:\Users");
            Process.






        }
    }
}
