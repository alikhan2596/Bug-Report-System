using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bug_Report
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        public static string con_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\kancha-sys.mdb";
        OleDbConnection conn = new OleDbConnection(con_str);
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_kancha_sysDataSet.AdminReport' table. You can move, or remove it, as needed.
            this.AdminReportTableAdapter.Fill(this._kancha_sysDataSet.AdminReport);
            // TODO: This line of code loads data into the '_kancha_sysDataSet3.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this._kancha_sysDataSet3.employee);
            // TODO: This line of code loads data into the '_kancha_sysDataSet2.complain' table. You can move, or remove it, as needed.
            this.complainTableAdapter.Fill(this._kancha_sysDataSet2.complain);
            // TODO: This line of code loads data into the '_kancha_sysDataSet1.complain' table. You can move, or remove it, as needed.
            this.complainTableAdapter.Fill(this._kancha_sysDataSet1.complain);
            // TODO: This line of code loads data into the '_kancha_sysDataSet.employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this._kancha_sysDataSet.employee);



            this.reportViewer1.RefreshReport();
            
        }

        private void btn_adminDashboard_Click(object sender, EventArgs e)
        {
            Panel_adminDashboard.Visible = true;
            panel_adminReport.Visible = false;
            btn_adminDashboard.selected = true;
            btn_adminReport.selected = false;
        }

        private void btn_adminReport_Click(object sender, EventArgs e)
        {
            panel_adminReport.Visible = true;
            Panel_adminDashboard.Visible = false;
            btn_adminDashboard.selected = false;
            btn_adminReport.selected = true;
            this.reportViewer1.RefreshReport();
        }

        private void btn_adminSignout_Click(object sender, EventArgs e)
        {
            panel_adminPortal.Visible = false;
            panel_adminLogin.Visible = true;
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            string ad = "select count(*) from admin where username = '" + txt_adminUsername.Text + "' and a_password='" + txt_adminPassword.Text + "'";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = ad,
                Connection = conn
            };
            

            if ((int)cmd.ExecuteScalar() == 1)
            {
                conn.Close();
                panel_adminPortal.Visible = true;
                panel_adminLogin.Visible = false;
            }
            else
            {
                conn.Close();
                Label_adminLoginError.Visible = true;
            }
            
        }
        
        private void btn_adminComplainUpdate_Click(object sender, EventArgs e)
        {
            string query1 = "select e_id from [employee] where e_fname='" + ComboBox_adminEmp.SelectedText + "'";
            string eid = "";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = query1,
                Connection = conn
            };
            
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eid = reader["e_id"].ToString();
            }
            MessageBox.Show("eid=" + eid);
            conn.Close();

            conn.Open();
            //OleDbCommand cmd = new OleDbCommand();
            string query = "insert into [job] ([a_id],[e_id],[u_id],[c_id]) values ('" + 1 + "','" + eid + "','" + txt_adminUID.Text + "','" + txt_adminCID.Text + "');";
            cmd.CommandText = query;
            cmd.Connection = conn;
            MessageBox.Show(query);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Job Assign Successfully");
                
            }

            conn.Close();
            MessageBox.Show("Updated....");
        }

        

        private void DataGrid_adminComplains_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DataGrid_adminComplains.Rows[index];
            txt_adminCID.Text = selectedRow.Cells[0].Value.ToString();
            txt_adminUID.Text = selectedRow.Cells[2].Value.ToString();
        }
    }
}
