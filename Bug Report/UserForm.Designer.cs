namespace Bug_Report
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.userComplainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._kancha_sysDataSet = new Bug_Report._kancha_sysDataSet();
            this.panel_userLogin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label_signupError = new System.Windows.Forms.Label();
            this.label_loginError = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_signup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtsignup_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsignup_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsignup_uname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsignup_lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsignup_fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_userlogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtlogin_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtlogin_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_userPortal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel_userBug = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txt_bugIssue = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_bugSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_existingIssue = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_userside = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_userSignout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_existingIssue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_userBug = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userComplainTableAdapter = new Bug_Report._kancha_sysDataSetTableAdapters.UserComplainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userComplainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet)).BeginInit();
            this.panel_userLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_userPortal.SuspendLayout();
            this.panel_userBug.SuspendLayout();
            this.panel_existingIssue.SuspendLayout();
            this.panel_userside.SuspendLayout();
            this.SuspendLayout();
            // 
            // userComplainBindingSource
            // 
            this.userComplainBindingSource.DataMember = "UserComplain";
            this.userComplainBindingSource.DataSource = this._kancha_sysDataSet;
            // 
            // _kancha_sysDataSet
            // 
            this._kancha_sysDataSet.DataSetName = "_kancha_sysDataSet";
            this._kancha_sysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_userLogin
            // 
            this.panel_userLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_userLogin.BackgroundImage")));
            this.panel_userLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_userLogin.Controls.Add(this.label_signupError);
            this.panel_userLogin.Controls.Add(this.label_loginError);
            this.panel_userLogin.Controls.Add(this.bunifuCustomLabel1);
            this.panel_userLogin.Controls.Add(this.btn_signup);
            this.panel_userLogin.Controls.Add(this.txtsignup_pass);
            this.panel_userLogin.Controls.Add(this.txtsignup_email);
            this.panel_userLogin.Controls.Add(this.txtsignup_uname);
            this.panel_userLogin.Controls.Add(this.txtsignup_lname);
            this.panel_userLogin.Controls.Add(this.txtsignup_fname);
            this.panel_userLogin.Controls.Add(this.btn_userlogin);
            this.panel_userLogin.Controls.Add(this.txtlogin_password);
            this.panel_userLogin.Controls.Add(this.txtlogin_username);
            this.panel_userLogin.Controls.Add(this.pictureBox1);
            this.panel_userLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_userLogin.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_userLogin.GradientBottomRight = System.Drawing.Color.White;
            this.panel_userLogin.GradientTopLeft = System.Drawing.Color.White;
            this.panel_userLogin.GradientTopRight = System.Drawing.Color.White;
            this.panel_userLogin.Location = new System.Drawing.Point(20, 60);
            this.panel_userLogin.Name = "panel_userLogin";
            this.panel_userLogin.Quality = 10;
            this.panel_userLogin.Size = new System.Drawing.Size(740, 440);
            this.panel_userLogin.TabIndex = 0;
            this.panel_userLogin.Visible = false;
            // 
            // label_signupError
            // 
            this.label_signupError.AutoSize = true;
            this.label_signupError.ForeColor = System.Drawing.Color.Red;
            this.label_signupError.Location = new System.Drawing.Point(393, 363);
            this.label_signupError.Name = "label_signupError";
            this.label_signupError.Size = new System.Drawing.Size(116, 13);
            this.label_signupError.TabIndex = 29;
            this.label_signupError.Text = "Username already exist";
            this.label_signupError.Visible = false;
            // 
            // label_loginError
            // 
            this.label_loginError.AutoSize = true;
            this.label_loginError.ForeColor = System.Drawing.Color.Red;
            this.label_loginError.Location = new System.Drawing.Point(312, 62);
            this.label_loginError.Name = "label_loginError";
            this.label_loginError.Size = new System.Drawing.Size(171, 13);
            this.label_loginError.TabIndex = 28;
            this.label_loginError.Text = "Username or Password is Incorrect";
            this.label_loginError.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(502, 109);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 28);
            this.bunifuCustomLabel1.TabIndex = 27;
            this.bunifuCustomLabel1.Text = "SIGN UP";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_signup
            // 
            this.btn_signup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_signup.BackColor = System.Drawing.Color.Teal;
            this.btn_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signup.BorderRadius = 5;
            this.btn_signup.ButtonText = "Sign Up";
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.DisabledColor = System.Drawing.Color.Gray;
            this.btn_signup.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_signup.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_signup.Iconimage")));
            this.btn_signup.Iconimage_right = null;
            this.btn_signup.Iconimage_right_Selected = null;
            this.btn_signup.Iconimage_Selected = null;
            this.btn_signup.IconMarginLeft = 0;
            this.btn_signup.IconMarginRight = 0;
            this.btn_signup.IconRightVisible = true;
            this.btn_signup.IconRightZoom = 0D;
            this.btn_signup.IconVisible = false;
            this.btn_signup.IconZoom = 90D;
            this.btn_signup.IsTab = false;
            this.btn_signup.Location = new System.Drawing.Point(495, 311);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Normalcolor = System.Drawing.Color.Teal;
            this.btn_signup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_signup.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_signup.selected = false;
            this.btn_signup.Size = new System.Drawing.Size(105, 34);
            this.btn_signup.TabIndex = 26;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_signup.Textcolor = System.Drawing.Color.White;
            this.btn_signup.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // txtsignup_pass
            // 
            this.txtsignup_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignup_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignup_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_pass.HintForeColor = System.Drawing.Color.Empty;
            this.txtsignup_pass.HintText = "Password";
            this.txtsignup_pass.isPassword = true;
            this.txtsignup_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_pass.LineIdleColor = System.Drawing.Color.Teal;
            this.txtsignup_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_pass.LineThickness = 3;
            this.txtsignup_pass.Location = new System.Drawing.Point(396, 264);
            this.txtsignup_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignup_pass.Name = "txtsignup_pass";
            this.txtsignup_pass.Size = new System.Drawing.Size(293, 33);
            this.txtsignup_pass.TabIndex = 25;
            this.txtsignup_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsignup_email
            // 
            this.txtsignup_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignup_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignup_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_email.HintForeColor = System.Drawing.Color.Empty;
            this.txtsignup_email.HintText = "Email";
            this.txtsignup_email.isPassword = false;
            this.txtsignup_email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_email.LineIdleColor = System.Drawing.Color.Teal;
            this.txtsignup_email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_email.LineThickness = 3;
            this.txtsignup_email.Location = new System.Drawing.Point(396, 223);
            this.txtsignup_email.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignup_email.Name = "txtsignup_email";
            this.txtsignup_email.Size = new System.Drawing.Size(293, 33);
            this.txtsignup_email.TabIndex = 24;
            this.txtsignup_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsignup_uname
            // 
            this.txtsignup_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignup_uname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignup_uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_uname.HintForeColor = System.Drawing.Color.Empty;
            this.txtsignup_uname.HintText = "Username";
            this.txtsignup_uname.isPassword = false;
            this.txtsignup_uname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_uname.LineIdleColor = System.Drawing.Color.Teal;
            this.txtsignup_uname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_uname.LineThickness = 3;
            this.txtsignup_uname.Location = new System.Drawing.Point(396, 182);
            this.txtsignup_uname.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignup_uname.Name = "txtsignup_uname";
            this.txtsignup_uname.Size = new System.Drawing.Size(293, 33);
            this.txtsignup_uname.TabIndex = 23;
            this.txtsignup_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsignup_lname
            // 
            this.txtsignup_lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignup_lname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignup_lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_lname.HintForeColor = System.Drawing.Color.Empty;
            this.txtsignup_lname.HintText = "Last Name";
            this.txtsignup_lname.isPassword = false;
            this.txtsignup_lname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_lname.LineIdleColor = System.Drawing.Color.Teal;
            this.txtsignup_lname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_lname.LineThickness = 3;
            this.txtsignup_lname.Location = new System.Drawing.Point(555, 141);
            this.txtsignup_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignup_lname.Name = "txtsignup_lname";
            this.txtsignup_lname.Size = new System.Drawing.Size(134, 33);
            this.txtsignup_lname.TabIndex = 22;
            this.txtsignup_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsignup_fname
            // 
            this.txtsignup_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsignup_fname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsignup_fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_fname.HintForeColor = System.Drawing.Color.Empty;
            this.txtsignup_fname.HintText = "First Name";
            this.txtsignup_fname.isPassword = false;
            this.txtsignup_fname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_fname.LineIdleColor = System.Drawing.Color.Teal;
            this.txtsignup_fname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsignup_fname.LineThickness = 3;
            this.txtsignup_fname.Location = new System.Drawing.Point(396, 141);
            this.txtsignup_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txtsignup_fname.Name = "txtsignup_fname";
            this.txtsignup_fname.Size = new System.Drawing.Size(134, 33);
            this.txtsignup_fname.TabIndex = 21;
            this.txtsignup_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_userlogin
            // 
            this.btn_userlogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_userlogin.BackColor = System.Drawing.Color.Teal;
            this.btn_userlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_userlogin.BorderRadius = 5;
            this.btn_userlogin.ButtonText = "Login";
            this.btn_userlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userlogin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_userlogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_userlogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_userlogin.Iconimage")));
            this.btn_userlogin.Iconimage_right = null;
            this.btn_userlogin.Iconimage_right_Selected = null;
            this.btn_userlogin.Iconimage_Selected = null;
            this.btn_userlogin.IconMarginLeft = 0;
            this.btn_userlogin.IconMarginRight = 0;
            this.btn_userlogin.IconRightVisible = true;
            this.btn_userlogin.IconRightZoom = 0D;
            this.btn_userlogin.IconVisible = false;
            this.btn_userlogin.IconZoom = 90D;
            this.btn_userlogin.IsTab = false;
            this.btn_userlogin.Location = new System.Drawing.Point(627, 34);
            this.btn_userlogin.Name = "btn_userlogin";
            this.btn_userlogin.Normalcolor = System.Drawing.Color.Teal;
            this.btn_userlogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_userlogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_userlogin.selected = false;
            this.btn_userlogin.Size = new System.Drawing.Size(97, 24);
            this.btn_userlogin.TabIndex = 20;
            this.btn_userlogin.Text = "Login";
            this.btn_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_userlogin.Textcolor = System.Drawing.Color.White;
            this.btn_userlogin.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userlogin.Click += new System.EventHandler(this.btn_userlogin_Click);
            // 
            // txtlogin_password
            // 
            this.txtlogin_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlogin_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtlogin_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin_password.HintForeColor = System.Drawing.Color.Empty;
            this.txtlogin_password.HintText = "Password";
            this.txtlogin_password.isPassword = true;
            this.txtlogin_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin_password.LineIdleColor = System.Drawing.Color.Teal;
            this.txtlogin_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin_password.LineThickness = 3;
            this.txtlogin_password.Location = new System.Drawing.Point(467, 25);
            this.txtlogin_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtlogin_password.Name = "txtlogin_password";
            this.txtlogin_password.Size = new System.Drawing.Size(139, 33);
            this.txtlogin_password.TabIndex = 19;
            this.txtlogin_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtlogin_username
            // 
            this.txtlogin_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlogin_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtlogin_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin_username.HintForeColor = System.Drawing.Color.Empty;
            this.txtlogin_username.HintText = "Username";
            this.txtlogin_username.isPassword = false;
            this.txtlogin_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin_username.LineIdleColor = System.Drawing.Color.Teal;
            this.txtlogin_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin_username.LineThickness = 3;
            this.txtlogin_username.Location = new System.Drawing.Point(315, 25);
            this.txtlogin_username.Margin = new System.Windows.Forms.Padding(4);
            this.txtlogin_username.Name = "txtlogin_username";
            this.txtlogin_username.Size = new System.Drawing.Size(134, 33);
            this.txtlogin_username.TabIndex = 18;
            this.txtlogin_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_userPortal
            // 
            this.panel_userPortal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_userPortal.BackgroundImage")));
            this.panel_userPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_userPortal.Controls.Add(this.panel_userBug);
            this.panel_userPortal.Controls.Add(this.panel_existingIssue);
            this.panel_userPortal.Controls.Add(this.panel_userside);
            this.panel_userPortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_userPortal.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_userPortal.GradientBottomRight = System.Drawing.Color.White;
            this.panel_userPortal.GradientTopLeft = System.Drawing.Color.White;
            this.panel_userPortal.GradientTopRight = System.Drawing.Color.White;
            this.panel_userPortal.Location = new System.Drawing.Point(20, 60);
            this.panel_userPortal.Name = "panel_userPortal";
            this.panel_userPortal.Quality = 10;
            this.panel_userPortal.Size = new System.Drawing.Size(740, 440);
            this.panel_userPortal.TabIndex = 1;
            this.panel_userPortal.Visible = false;
            // 
            // panel_userBug
            // 
            this.panel_userBug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_userBug.BackgroundImage")));
            this.panel_userBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_userBug.Controls.Add(this.txt_bugIssue);
            this.panel_userBug.Controls.Add(this.bunifuCustomLabel2);
            this.panel_userBug.Controls.Add(this.btn_bugSubmit);
            this.panel_userBug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_userBug.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_userBug.GradientBottomRight = System.Drawing.Color.White;
            this.panel_userBug.GradientTopLeft = System.Drawing.Color.White;
            this.panel_userBug.GradientTopRight = System.Drawing.Color.White;
            this.panel_userBug.Location = new System.Drawing.Point(200, 0);
            this.panel_userBug.Name = "panel_userBug";
            this.panel_userBug.Quality = 10;
            this.panel_userBug.Size = new System.Drawing.Size(540, 440);
            this.panel_userBug.TabIndex = 1;
            // 
            // txt_bugIssue
            // 
            this.txt_bugIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bugIssue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bugIssue.Location = new System.Drawing.Point(26, 125);
            this.txt_bugIssue.Name = "txt_bugIssue";
            this.txt_bugIssue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_bugIssue.Size = new System.Drawing.Size(483, 240);
            this.txt_bugIssue.TabIndex = 7;
            this.txt_bugIssue.Text = "Write your complain here.";
            this.txt_bugIssue.MouseEnter += new System.EventHandler(this.txt_bugIssue_MouseEnter);
            this.txt_bugIssue.MouseLeave += new System.EventHandler(this.txt_bugIssue_MouseLeave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(30, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(85, 91);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Bug Issue";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_bugSubmit
            // 
            this.btn_bugSubmit.Activecolor = System.Drawing.Color.Teal;
            this.btn_bugSubmit.BackColor = System.Drawing.Color.Teal;
            this.btn_bugSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bugSubmit.BorderRadius = 5;
            this.btn_bugSubmit.ButtonText = "Submit";
            this.btn_bugSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bugSubmit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_bugSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bugSubmit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_bugSubmit.Iconimage")));
            this.btn_bugSubmit.Iconimage_right = null;
            this.btn_bugSubmit.Iconimage_right_Selected = null;
            this.btn_bugSubmit.Iconimage_Selected = null;
            this.btn_bugSubmit.IconMarginLeft = 0;
            this.btn_bugSubmit.IconMarginRight = 0;
            this.btn_bugSubmit.IconRightVisible = true;
            this.btn_bugSubmit.IconRightZoom = 0D;
            this.btn_bugSubmit.IconVisible = false;
            this.btn_bugSubmit.IconZoom = 90D;
            this.btn_bugSubmit.IsTab = false;
            this.btn_bugSubmit.Location = new System.Drawing.Point(429, 389);
            this.btn_bugSubmit.Name = "btn_bugSubmit";
            this.btn_bugSubmit.Normalcolor = System.Drawing.Color.Teal;
            this.btn_bugSubmit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bugSubmit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_bugSubmit.selected = false;
            this.btn_bugSubmit.Size = new System.Drawing.Size(80, 31);
            this.btn_bugSubmit.TabIndex = 5;
            this.btn_bugSubmit.Text = "Submit";
            this.btn_bugSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bugSubmit.Textcolor = System.Drawing.Color.White;
            this.btn_bugSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bugSubmit.Click += new System.EventHandler(this.btn_bugSubmit_Click);
            // 
            // panel_existingIssue
            // 
            this.panel_existingIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_existingIssue.BackgroundImage")));
            this.panel_existingIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_existingIssue.Controls.Add(this.reportViewer1);
            this.panel_existingIssue.Controls.Add(this.bunifuCustomLabel3);
            this.panel_existingIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_existingIssue.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_existingIssue.GradientBottomRight = System.Drawing.Color.White;
            this.panel_existingIssue.GradientTopLeft = System.Drawing.Color.White;
            this.panel_existingIssue.GradientTopRight = System.Drawing.Color.White;
            this.panel_existingIssue.Location = new System.Drawing.Point(200, 0);
            this.panel_existingIssue.Name = "panel_existingIssue";
            this.panel_existingIssue.Quality = 10;
            this.panel_existingIssue.Size = new System.Drawing.Size(540, 440);
            this.panel_existingIssue.TabIndex = 7;
            this.panel_existingIssue.Visible = false;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.userComplainBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bug_Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 73);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(531, 363);
            this.reportViewer1.TabIndex = 8;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(22, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 70);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Your Issues";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_userside
            // 
            this.panel_userside.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_userside.BackgroundImage")));
            this.panel_userside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_userside.Controls.Add(this.btn_userSignout);
            this.panel_userside.Controls.Add(this.btn_existingIssue);
            this.panel_userside.Controls.Add(this.btn_userBug);
            this.panel_userside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_userside.GradientBottomLeft = System.Drawing.Color.Teal;
            this.panel_userside.GradientBottomRight = System.Drawing.Color.Teal;
            this.panel_userside.GradientTopLeft = System.Drawing.Color.Teal;
            this.panel_userside.GradientTopRight = System.Drawing.Color.Teal;
            this.panel_userside.Location = new System.Drawing.Point(0, 0);
            this.panel_userside.Name = "panel_userside";
            this.panel_userside.Quality = 10;
            this.panel_userside.Size = new System.Drawing.Size(200, 440);
            this.panel_userside.TabIndex = 0;
            // 
            // btn_userSignout
            // 
            this.btn_userSignout.Activecolor = System.Drawing.Color.Teal;
            this.btn_userSignout.BackColor = System.Drawing.Color.Transparent;
            this.btn_userSignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_userSignout.BorderRadius = 0;
            this.btn_userSignout.ButtonText = "Sign Out";
            this.btn_userSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userSignout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_userSignout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_userSignout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_userSignout.Iconimage")));
            this.btn_userSignout.Iconimage_right = null;
            this.btn_userSignout.Iconimage_right_Selected = null;
            this.btn_userSignout.Iconimage_Selected = null;
            this.btn_userSignout.IconMarginLeft = 0;
            this.btn_userSignout.IconMarginRight = 0;
            this.btn_userSignout.IconRightVisible = true;
            this.btn_userSignout.IconRightZoom = 0D;
            this.btn_userSignout.IconVisible = true;
            this.btn_userSignout.IconZoom = 90D;
            this.btn_userSignout.IsTab = false;
            this.btn_userSignout.Location = new System.Drawing.Point(0, 217);
            this.btn_userSignout.Name = "btn_userSignout";
            this.btn_userSignout.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_userSignout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_userSignout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_userSignout.selected = false;
            this.btn_userSignout.Size = new System.Drawing.Size(200, 48);
            this.btn_userSignout.TabIndex = 3;
            this.btn_userSignout.Text = "Sign Out";
            this.btn_userSignout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_userSignout.Textcolor = System.Drawing.Color.White;
            this.btn_userSignout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userSignout.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // btn_existingIssue
            // 
            this.btn_existingIssue.Activecolor = System.Drawing.Color.Teal;
            this.btn_existingIssue.BackColor = System.Drawing.Color.Transparent;
            this.btn_existingIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_existingIssue.BorderRadius = 0;
            this.btn_existingIssue.ButtonText = "View Existing Bug";
            this.btn_existingIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_existingIssue.DisabledColor = System.Drawing.Color.Gray;
            this.btn_existingIssue.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_existingIssue.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_existingIssue.Iconimage")));
            this.btn_existingIssue.Iconimage_right = null;
            this.btn_existingIssue.Iconimage_right_Selected = null;
            this.btn_existingIssue.Iconimage_Selected = null;
            this.btn_existingIssue.IconMarginLeft = 0;
            this.btn_existingIssue.IconMarginRight = 0;
            this.btn_existingIssue.IconRightVisible = true;
            this.btn_existingIssue.IconRightZoom = 0D;
            this.btn_existingIssue.IconVisible = true;
            this.btn_existingIssue.IconZoom = 90D;
            this.btn_existingIssue.IsTab = false;
            this.btn_existingIssue.Location = new System.Drawing.Point(0, 167);
            this.btn_existingIssue.Name = "btn_existingIssue";
            this.btn_existingIssue.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_existingIssue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_existingIssue.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_existingIssue.selected = false;
            this.btn_existingIssue.Size = new System.Drawing.Size(200, 48);
            this.btn_existingIssue.TabIndex = 2;
            this.btn_existingIssue.Text = "View Existing Bug";
            this.btn_existingIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_existingIssue.Textcolor = System.Drawing.Color.White;
            this.btn_existingIssue.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_existingIssue.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // btn_userBug
            // 
            this.btn_userBug.Activecolor = System.Drawing.Color.Teal;
            this.btn_userBug.BackColor = System.Drawing.Color.Transparent;
            this.btn_userBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_userBug.BorderRadius = 0;
            this.btn_userBug.ButtonText = "Report a Bug";
            this.btn_userBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userBug.DisabledColor = System.Drawing.Color.Gray;
            this.btn_userBug.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_userBug.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_userBug.Iconimage")));
            this.btn_userBug.Iconimage_right = null;
            this.btn_userBug.Iconimage_right_Selected = null;
            this.btn_userBug.Iconimage_Selected = null;
            this.btn_userBug.IconMarginLeft = 0;
            this.btn_userBug.IconMarginRight = 0;
            this.btn_userBug.IconRightVisible = true;
            this.btn_userBug.IconRightZoom = 0D;
            this.btn_userBug.IconVisible = true;
            this.btn_userBug.IconZoom = 90D;
            this.btn_userBug.IsTab = false;
            this.btn_userBug.Location = new System.Drawing.Point(0, 113);
            this.btn_userBug.Name = "btn_userBug";
            this.btn_userBug.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_userBug.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_userBug.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_userBug.selected = false;
            this.btn_userBug.Size = new System.Drawing.Size(200, 48);
            this.btn_userBug.TabIndex = 1;
            this.btn_userBug.Text = "Report a Bug";
            this.btn_userBug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_userBug.Textcolor = System.Drawing.Color.White;
            this.btn_userBug.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userBug.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // userComplainTableAdapter
            // 
            this.userComplainTableAdapter.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.panel_userPortal);
            this.Controls.Add(this.panel_userLogin);
            this.Name = "UserForm";
            this.Text = "User Portal";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userComplainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet)).EndInit();
            this.panel_userLogin.ResumeLayout(false);
            this.panel_userLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_userPortal.ResumeLayout(false);
            this.panel_userBug.ResumeLayout(false);
            this.panel_existingIssue.ResumeLayout(false);
            this.panel_userside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panel_userLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_signup;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsignup_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsignup_email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsignup_uname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsignup_lname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsignup_fname;
        private Bunifu.Framework.UI.BunifuFlatButton btn_userlogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtlogin_password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtlogin_username;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_userPortal;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_userside;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_userBug;
        private Bunifu.Framework.UI.BunifuFlatButton btn_userSignout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_existingIssue;
        private Bunifu.Framework.UI.BunifuFlatButton btn_userBug;
        private Bunifu.Framework.UI.BunifuFlatButton btn_bugSubmit;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_existingIssue;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label_loginError;
        private System.Windows.Forms.Label label_signupError;
        private System.Windows.Forms.RichTextBox txt_bugIssue;
        private _kancha_sysDataSet _kancha_sysDataSet;
        private System.Windows.Forms.BindingSource userComplainBindingSource;
        private _kancha_sysDataSetTableAdapters.UserComplainTableAdapter userComplainTableAdapter;
    }
}