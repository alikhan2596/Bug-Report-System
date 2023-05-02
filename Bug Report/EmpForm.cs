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
    public partial class EmpForm : MetroFramework.Forms.MetroForm
    {
        public static string con_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\kancha-sys.mdb";
        OleDbConnection conn = new OleDbConnection(con_str);
        public EmpForm()
        {
            InitializeComponent();
        }
        
        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            string emp = "select count(*) from [employee] where username = '" + txt_empUsername.Text + "' and e_password='" + txt_empPassword.Text + "'";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = emp,
                Connection = conn
            };
            

            if ((int)cmd.ExecuteScalar() == 1)
            {
                conn.Close();
                panel_empPortal.Visible = true;
                panel_empLogin.Visible = false;
            }
            else
            {
                conn.Close();
                Label_empLoginError.Visible = true;
            }
        }
        
        private void Link_toSignup_Click(object sender, EventArgs e)
        {
            panel_empSignup.Visible = true;
        }

        private void link_toLogin_Click(object sender, EventArgs e)
        {
            panel_empSignup.Visible = false;
        }

        private void btn_EmpSignup_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            //string check;
            string query0 = "select count(*) from [employee] where username='" + txtSignup_uname.Text + "'";
            MessageBox.Show(query0);
            cmd.CommandText = query0;
            cmd.Connection = conn;
            if ((int)cmd.ExecuteScalar() > 0)
            {
                label_empSignupError.Visible = true;
                conn.Close();
            }

            else
            {
                conn.Close();
                conn.Open();
                //OleDbCommand cmd = new OleDbCommand();
                string query = "insert into [employee] ([e_fname],[e_lname],[e_email],[e_password],[username]) values ('" + txtSignup_fname.Text + "','" + txtSignup_lname.Text + "','" + txtSignup_email.Text + "','" + txtSignup_pass.Text + "','" + txtSignup_uname.Text + "');";
                cmd.CommandText = query;
                cmd.Connection = conn;
                MessageBox.Show(query);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data inserted!");
                    panel_empSignup.Visible = false;
                    panel_empLogin.Visible = true;
                }

                conn.Close();
            }
        }

        private void EmpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_kancha_sysDataSet1.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this._kancha_sysDataSet1.job);
            // TODO: This line of code loads data into the '_kancha_sysDataSet1.EmpTask' table. You can move, or remove it, as needed.
            this.empTaskTableAdapter.Fill(this._kancha_sysDataSet1.EmpTask);
            // TODO: This line of code loads data into the '_kancha_sysDataSet.complain' table. You can move, or remove it, as needed.
            this.complainTableAdapter.Fill(this._kancha_sysDataSet.complain);
            // TODO: This line of code loads data into the '_kancha_sysDataSet.AdminReport' table. You can move, or remove it, as needed.
            this.AdminReportTableAdapter.Fill(this._kancha_sysDataSet.AdminReport);
            // TODO: This line of code loads data into the '_kancha_sysDataSet.UserComplain' table. You can move, or remove it, as needed.
            this.UserComplainTableAdapter.Fill(this._kancha_sysDataSet.UserComplain);
            // TODO: This line of code loads data into the '_kancha_sysDataSet.complain' table. You can move, or remove it, as needed.
            //this.complainTableAdapter.Fill(this._kancha_sysDataSet.complain);
            // TODO: This line of code loads data into the '_kancha_sysDataSet.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this._kancha_sysDataSet.job);
            ComboBox_EmpJobStatus.Text = "Status";
            ComboBox_EmpJobStatus.ForeColor = Color.White;
            ComboBox_EmpJobStatus.Items.Add("Pending");
            ComboBox_EmpJobStatus.Items.Add("Process");
            ComboBox_EmpJobStatus.Items.Add("Completed");
            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txt_empCID.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void btn_empTasks_Click(object sender, EventArgs e)
        {
            panel_empReport.Visible = false;
            panel_empTasks.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            panel_empReport.Visible = true;
            panel_empTasks.Visible = false;
            btn_empTasks.selected = false;
            btn_empReport.selected = true;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel_empPortal.Visible = false;
            panel_empLogin.Visible = true;
        }

        private void btn_empComplainUpdate_Click(object sender, EventArgs e)
        {
           /* conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = "insert into [complain] ([c_id],[e_id],[u_id],[c_id]) values ('" + 1 + "','" + eid + "','" + txt_adminUID.Text + "','" + txt_adminCID.Text + "');";
            cmd.CommandText = query;
            cmd.Connection = conn;
            MessageBox.Show(query);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Job Assign Successfully");

            }

            conn.Close();
            MessageBox.Show("Updated....");*/



            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            string cid = txt_empCID.Text;
            string status = ComboBox_EmpJobStatus.SelectedItem.ToString();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE [complain] SET [c_status] = '" + status + "' WHERE c_id = " + cid;
            if (conn.State == ConnectionState.Open)
            {

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DATA UPDATED");
                    conn.Close();

                }
                catch (Exception expe)
                {
                    MessageBox.Show(expe.Source);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            dataGridView1.Refresh();
        }
    }
}
