using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bug_Report
{
    public partial class UserForm : MetroFramework.Forms.MetroForm
    {
        private static string con_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\kancha-sys.mdb";
        private readonly OleDbConnection Conn = new OleDbConnection(Con_str1);

        public static string Con_str { get => Con_str1; set => Con_str1 = value; }
        public static string Con_str1 { get => con_str; set => con_str = value; }

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_kancha_sysDataSet.UserComplain' table. You can move, or remove it, as needed.
            this.userComplainTableAdapter.Fill(this._kancha_sysDataSet.UserComplain);
            // TODO: This line of code loads data into the '_kancha_sysDataSet.complain' table. You can move, or remove it, as needed.
            //this.complainTableAdapter.Fill(this._kancha_sysDataSet.complain);
            panel_userLogin.Visible = true;
            this.reportViewer1.RefreshReport();
        }

        private void btn_userlogin_Click(object sender, EventArgs e)
        {
            string cst = "select count(*) from [user] where username = '" + txtlogin_username.Text + "' and u_password='" + txtlogin_password.Text + "'";
            Conn.Open();


            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = cst,
                Connection = Conn
        };
            

            if ((int)cmd.ExecuteScalar() == 1)
            {
                Conn.Close();
                panel_userPortal.Visible = true;
                panel_userLogin.Visible = false;
            }
            else
            {
                Conn.Close();
                label_loginError.Visible = true;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel_userBug.Visible = true;
            panel_existingIssue.Visible = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel_existingIssue.Visible = true;
            panel_userBug.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel_userLogin.Visible = true;
            panel_userPortal.Visible = false;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            //string check;
            string query0 = "select count(*) from [user] where username='" + txtsignup_uname.Text + "'";
            MessageBox.Show(query0);
            cmd.CommandText = query0;
            cmd.Connection = Conn;
            if ((int)cmd.ExecuteScalar() > 0)
            {
                label_signupError.Visible = true;
                Conn.Close();
            }

            else
            {
                Conn.Close();
                Conn.Open();
                //OleDbCommand cmd = new OleDbCommand();
                string query = "insert into [user] ([u_fname],[u_lname],[u_email],[u_password],[username]) values ('" + txtsignup_fname.Text + "','" + txtsignup_lname.Text + "','" + txtsignup_email.Text + "','" + txtsignup_pass.Text + "','" + txtsignup_uname.Text +  "');";
                cmd.CommandText = query;
                cmd.Connection = Conn;
                MessageBox.Show(query);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data inserted!");
                    txtlogin_username.Text = txtsignup_uname.Text;
                    txtlogin_password.Text = txtsignup_pass.Text;
                }

                Conn.Close();
            }
        }

        private void btn_bugSubmit_Click(object sender, EventArgs e)
        {
            string query1 = "select u_id from [user] where username='" + txtlogin_username.Text + "'";
            string uid = "";
            Conn.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                CommandText = query1,
                Connection = Conn
            };
            
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                uid = reader["u_id"].ToString();
            }
            MessageBox.Show("uid=" + uid);
            Conn.Close();

            Conn.Open();
            string query = "insert into [complain] ([c_description],[u_id],[c_status]) values ('" + txt_bugIssue.Text + "','" + uid + "','" + "Pending" + "')";
            cmd.CommandText = query;
            cmd.Connection = Conn;
            MessageBox.Show(query);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data inserted!");
            }

            Conn.Close();
        }

        private void txt_bugIssue_MouseEnter(object sender, EventArgs e)
        {
            if (txt_bugIssue.Text == "Write your complain here.")
            {
                txt_bugIssue.Text = "";
            }
           
        }

        private void txt_bugIssue_MouseLeave(object sender, EventArgs e)
        {
            if (txt_bugIssue.Text == "")
            {
                txt_bugIssue.Text = "Write your complain here.";
            }
        }
    }
}
