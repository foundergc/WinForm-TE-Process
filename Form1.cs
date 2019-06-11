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

            //Process.Start(@"C:\Users");

             

            try
            {
                //Process.Start(@"g:\Users");

                //Process.Start(@"C:\Users");
                Process.Start(@"C:\Users\Administrator\AppData\Local\Google\Chrome\Application\chrome.exe");
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                throw;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //object[] myarray;
                //myarray = Process.GetProcesses();
                //DataTable dt1 = new DataTable();
                //DataSet ds1 = new DataSet();
                //Array ay1 = new Array();
                //dt1= (myarray as DataSet);
                //ds1 = (myarray as DataSet);
                //dt1 = myarray.ToArray();
                //DataGridView dg1 = new DataGridView();
                //dg1.DataSource = myarray;
                //DataTable dt2 = dg1.DataSource as DataTable;
                //dataGridView1.DataSource = dt2.Rows[10];


                Process[] P1;
                P1 = Process.GetProcesses();

                //取前100条数据
                dataGridView1.DataSource = P1.Take(100).ToArray();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            //Process.GetProcessesByName();
           //process.Dispose();



        }

        //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowIndex >= 0)
        //    {
        //        e.Row.Cells[0].Text = Convert.ToString(e.Row.DataItemIndex + 1);
        //    }
        //}


        //Process.

    }
}
