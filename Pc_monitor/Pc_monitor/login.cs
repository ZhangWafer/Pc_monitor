using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pc_monitor;

namespace Pc_monitor
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = textBox1.Text;
            string password = textBox2.Text;
            DataTable accountTable = SqlHelper.ExecuteDataTable("select * from Cater.PCStaff");

        }
    }
}
