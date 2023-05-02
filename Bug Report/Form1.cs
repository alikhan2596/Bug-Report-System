using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Report
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70, 128, 128, 128);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            EmpForm ef = new EmpForm();
            ef.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.Show();
        }
    }
}
