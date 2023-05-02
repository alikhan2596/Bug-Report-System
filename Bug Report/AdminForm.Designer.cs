namespace Bug_Report
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.complainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._kancha_sysDataSet2 = new Bug_Report._kancha_sysDataSet();
            this.AdminReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._kancha_sysDataSet = new Bug_Report._kancha_sysDataSet();
            this.Label_adminLoginError = new MetroFramework.Controls.MetroLabel();
            this.txt_adminPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_adminUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_adminLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_adminPortal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel_adminReport = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Panel_adminDashboard = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ComboBox_adminEmp = new MetroFramework.Controls.MetroComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._kancha_sysDataSet3 = new Bug_Report._kancha_sysDataSet();
            this.txt_adminCID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_adminUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_adminComplainUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGrid_adminComplains = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel_adminSide = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_adminSignout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_adminReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_adminDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_adminLogin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this._kancha_sysDataSet1 = new Bug_Report._kancha_sysDataSet();
            this.complainTableAdapter = new Bug_Report._kancha_sysDataSetTableAdapters.complainTableAdapter();
            this.employeeTableAdapter = new Bug_Report._kancha_sysDataSetTableAdapters.employeeTableAdapter();
            this.AdminReportTableAdapter = new Bug_Report._kancha_sysDataSetTableAdapters.AdminReportTableAdapter();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_adminPortal.SuspendLayout();
            this.panel_adminReport.SuspendLayout();
            this.Panel_adminDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_adminComplains)).BeginInit();
            this.panel_adminSide.SuspendLayout();
            this.panel_adminLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // complainBindingSource
            // 
            this.complainBindingSource.DataMember = "complain";
            this.complainBindingSource.DataSource = this._kancha_sysDataSet2;
            // 
            // _kancha_sysDataSet2
            // 
            this._kancha_sysDataSet2.DataSetName = "_kancha_sysDataSet";
            this._kancha_sysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminReportBindingSource
            // 
            this.AdminReportBindingSource.DataMember = "AdminReport";
            this.AdminReportBindingSource.DataSource = this._kancha_sysDataSet;
            // 
            // _kancha_sysDataSet
            // 
            this._kancha_sysDataSet.DataSetName = "_kancha_sysDataSet";
            this._kancha_sysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label_adminLoginError
            // 
            this.Label_adminLoginError.AutoSize = true;
            this.Label_adminLoginError.ForeColor = System.Drawing.Color.Red;
            this.Label_adminLoginError.Location = new System.Drawing.Point(262, 288);
            this.Label_adminLoginError.Name = "Label_adminLoginError";
            this.Label_adminLoginError.Size = new System.Drawing.Size(211, 19);
            this.Label_adminLoginError.Style = MetroFramework.MetroColorStyle.Red;
            this.Label_adminLoginError.TabIndex = 16;
            this.Label_adminLoginError.Text = "Username or Password is incorrent";
            this.Label_adminLoginError.UseCustomForeColor = true;
            this.Label_adminLoginError.UseStyleColors = true;
            this.Label_adminLoginError.Visible = false;
            // 
            // txt_adminPassword
            // 
            this.txt_adminPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adminPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_adminPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txt_adminPassword.HintText = "Password";
            this.txt_adminPassword.isPassword = true;
            this.txt_adminPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminPassword.LineIdleColor = System.Drawing.Color.Teal;
            this.txt_adminPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminPassword.LineThickness = 3;
            this.txt_adminPassword.Location = new System.Drawing.Point(303, 251);
            this.txt_adminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminPassword.Name = "txt_adminPassword";
            this.txt_adminPassword.Size = new System.Drawing.Size(226, 33);
            this.txt_adminPassword.TabIndex = 15;
            this.txt_adminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_adminUsername
            // 
            this.txt_adminUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adminUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_adminUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txt_adminUsername.HintText = "Username";
            this.txt_adminUsername.isPassword = false;
            this.txt_adminUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminUsername.LineIdleColor = System.Drawing.Color.Teal;
            this.txt_adminUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminUsername.LineThickness = 3;
            this.txt_adminUsername.Location = new System.Drawing.Point(303, 196);
            this.txt_adminUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminUsername.Name = "txt_adminUsername";
            this.txt_adminUsername.Size = new System.Drawing.Size(226, 33);
            this.txt_adminUsername.TabIndex = 14;
            this.txt_adminUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(262, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_adminLogin
            // 
            this.btn_adminLogin.Activecolor = System.Drawing.Color.Teal;
            this.btn_adminLogin.BackColor = System.Drawing.Color.Teal;
            this.btn_adminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminLogin.BorderRadius = 5;
            this.btn_adminLogin.ButtonText = "Login";
            this.btn_adminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_adminLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_adminLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_adminLogin.Iconimage")));
            this.btn_adminLogin.Iconimage_right = null;
            this.btn_adminLogin.Iconimage_right_Selected = null;
            this.btn_adminLogin.Iconimage_Selected = null;
            this.btn_adminLogin.IconMarginLeft = 0;
            this.btn_adminLogin.IconMarginRight = 0;
            this.btn_adminLogin.IconRightVisible = true;
            this.btn_adminLogin.IconRightZoom = 0D;
            this.btn_adminLogin.IconVisible = false;
            this.btn_adminLogin.IconZoom = 90D;
            this.btn_adminLogin.IsTab = false;
            this.btn_adminLogin.Location = new System.Drawing.Point(262, 343);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Normalcolor = System.Drawing.Color.Teal;
            this.btn_adminLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adminLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_adminLogin.selected = false;
            this.btn_adminLogin.Size = new System.Drawing.Size(267, 34);
            this.btn_adminLogin.TabIndex = 17;
            this.btn_adminLogin.Text = "Login";
            this.btn_adminLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_adminLogin.Textcolor = System.Drawing.Color.White;
            this.btn_adminLogin.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminLogin.Click += new System.EventHandler(this.btn_adminLogin_Click);
            // 
            // panel_adminPortal
            // 
            this.panel_adminPortal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_adminPortal.BackgroundImage")));
            this.panel_adminPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_adminPortal.Controls.Add(this.Panel_adminDashboard);
            this.panel_adminPortal.Controls.Add(this.panel_adminReport);
            this.panel_adminPortal.Controls.Add(this.panel_adminSide);
            this.panel_adminPortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_adminPortal.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_adminPortal.GradientBottomRight = System.Drawing.Color.White;
            this.panel_adminPortal.GradientTopLeft = System.Drawing.Color.White;
            this.panel_adminPortal.GradientTopRight = System.Drawing.Color.White;
            this.panel_adminPortal.Location = new System.Drawing.Point(20, 60);
            this.panel_adminPortal.Name = "panel_adminPortal";
            this.panel_adminPortal.Quality = 10;
            this.panel_adminPortal.Size = new System.Drawing.Size(740, 440);
            this.panel_adminPortal.TabIndex = 18;
            // 
            // panel_adminReport
            // 
            this.panel_adminReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_adminReport.BackgroundImage")));
            this.panel_adminReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_adminReport.Controls.Add(this.bunifuCustomLabel1);
            this.panel_adminReport.Controls.Add(this.reportViewer1);
            this.panel_adminReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_adminReport.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_adminReport.GradientBottomRight = System.Drawing.Color.White;
            this.panel_adminReport.GradientTopLeft = System.Drawing.Color.White;
            this.panel_adminReport.GradientTopRight = System.Drawing.Color.White;
            this.panel_adminReport.Location = new System.Drawing.Point(200, 0);
            this.panel_adminReport.Name = "panel_adminReport";
            this.panel_adminReport.Quality = 10;
            this.panel_adminReport.Size = new System.Drawing.Size(540, 440);
            this.panel_adminReport.TabIndex = 0;
            this.panel_adminReport.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 70);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Complain Report";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.complainBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.AdminReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bug_Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(531, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // Panel_adminDashboard
            // 
            this.Panel_adminDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_adminDashboard.BackgroundImage")));
            this.Panel_adminDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_adminDashboard.Controls.Add(this.bunifuCustomLabel3);
            this.Panel_adminDashboard.Controls.Add(this.ComboBox_adminEmp);
            this.Panel_adminDashboard.Controls.Add(this.txt_adminCID);
            this.Panel_adminDashboard.Controls.Add(this.txt_adminUID);
            this.Panel_adminDashboard.Controls.Add(this.btn_adminComplainUpdate);
            this.Panel_adminDashboard.Controls.Add(this.DataGrid_adminComplains);
            this.Panel_adminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_adminDashboard.GradientBottomLeft = System.Drawing.Color.White;
            this.Panel_adminDashboard.GradientBottomRight = System.Drawing.Color.White;
            this.Panel_adminDashboard.GradientTopLeft = System.Drawing.Color.White;
            this.Panel_adminDashboard.GradientTopRight = System.Drawing.Color.White;
            this.Panel_adminDashboard.Location = new System.Drawing.Point(200, 0);
            this.Panel_adminDashboard.Name = "Panel_adminDashboard";
            this.Panel_adminDashboard.Quality = 10;
            this.Panel_adminDashboard.Size = new System.Drawing.Size(540, 440);
            this.Panel_adminDashboard.TabIndex = 1;
            this.Panel_adminDashboard.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(27, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(112, 70);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Dashboard";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_adminEmp
            // 
            this.ComboBox_adminEmp.BackColor = System.Drawing.Color.Teal;
            this.ComboBox_adminEmp.DataSource = this.employeeBindingSource;
            this.ComboBox_adminEmp.DisplayMember = "e_fname";
            this.ComboBox_adminEmp.ForeColor = System.Drawing.Color.White;
            this.ComboBox_adminEmp.FormattingEnabled = true;
            this.ComboBox_adminEmp.ItemHeight = 23;
            this.ComboBox_adminEmp.Location = new System.Drawing.Point(261, 396);
            this.ComboBox_adminEmp.Name = "ComboBox_adminEmp";
            this.ComboBox_adminEmp.Size = new System.Drawing.Size(136, 29);
            this.ComboBox_adminEmp.TabIndex = 6;
            this.ComboBox_adminEmp.UseCustomBackColor = true;
            this.ComboBox_adminEmp.UseCustomForeColor = true;
            this.ComboBox_adminEmp.UseSelectable = true;
            this.ComboBox_adminEmp.UseStyleColors = true;
            this.ComboBox_adminEmp.ValueMember = "e_id";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this._kancha_sysDataSet3;
            // 
            // _kancha_sysDataSet3
            // 
            this._kancha_sysDataSet3.DataSetName = "_kancha_sysDataSet";
            this._kancha_sysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_adminCID
            // 
            this.txt_adminCID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adminCID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_adminCID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminCID.HintForeColor = System.Drawing.Color.Empty;
            this.txt_adminCID.HintText = "Complain ID";
            this.txt_adminCID.isPassword = false;
            this.txt_adminCID.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.txt_adminCID.LineIdleColor = System.Drawing.Color.Teal;
            this.txt_adminCID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminCID.LineThickness = 3;
            this.txt_adminCID.Location = new System.Drawing.Point(133, 392);
            this.txt_adminCID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminCID.Name = "txt_adminCID";
            this.txt_adminCID.Size = new System.Drawing.Size(105, 33);
            this.txt_adminCID.TabIndex = 4;
            this.txt_adminCID.Text = "User ID";
            this.txt_adminCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_adminUID
            // 
            this.txt_adminUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adminUID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_adminUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminUID.HintForeColor = System.Drawing.Color.Empty;
            this.txt_adminUID.HintText = "User ID";
            this.txt_adminUID.isPassword = false;
            this.txt_adminUID.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.txt_adminUID.LineIdleColor = System.Drawing.Color.Teal;
            this.txt_adminUID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adminUID.LineThickness = 3;
            this.txt_adminUID.Location = new System.Drawing.Point(7, 391);
            this.txt_adminUID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adminUID.Name = "txt_adminUID";
            this.txt_adminUID.Size = new System.Drawing.Size(105, 33);
            this.txt_adminUID.TabIndex = 3;
            this.txt_adminUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_adminComplainUpdate
            // 
            this.btn_adminComplainUpdate.Activecolor = System.Drawing.Color.Teal;
            this.btn_adminComplainUpdate.BackColor = System.Drawing.Color.Teal;
            this.btn_adminComplainUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminComplainUpdate.BorderRadius = 5;
            this.btn_adminComplainUpdate.ButtonText = "Update";
            this.btn_adminComplainUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminComplainUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btn_adminComplainUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_adminComplainUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_adminComplainUpdate.Iconimage")));
            this.btn_adminComplainUpdate.Iconimage_right = null;
            this.btn_adminComplainUpdate.Iconimage_right_Selected = null;
            this.btn_adminComplainUpdate.Iconimage_Selected = null;
            this.btn_adminComplainUpdate.IconMarginLeft = 0;
            this.btn_adminComplainUpdate.IconMarginRight = 0;
            this.btn_adminComplainUpdate.IconRightVisible = true;
            this.btn_adminComplainUpdate.IconRightZoom = 0D;
            this.btn_adminComplainUpdate.IconVisible = false;
            this.btn_adminComplainUpdate.IconZoom = 90D;
            this.btn_adminComplainUpdate.IsTab = false;
            this.btn_adminComplainUpdate.Location = new System.Drawing.Point(438, 398);
            this.btn_adminComplainUpdate.Name = "btn_adminComplainUpdate";
            this.btn_adminComplainUpdate.Normalcolor = System.Drawing.Color.Teal;
            this.btn_adminComplainUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adminComplainUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_adminComplainUpdate.selected = false;
            this.btn_adminComplainUpdate.Size = new System.Drawing.Size(80, 27);
            this.btn_adminComplainUpdate.TabIndex = 2;
            this.btn_adminComplainUpdate.Text = "Update";
            this.btn_adminComplainUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_adminComplainUpdate.Textcolor = System.Drawing.Color.White;
            this.btn_adminComplainUpdate.TextFont = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminComplainUpdate.Click += new System.EventHandler(this.btn_adminComplainUpdate_Click);
            // 
            // DataGrid_adminComplains
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_adminComplains.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_adminComplains.AutoGenerateColumns = false;
            this.DataGrid_adminComplains.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_adminComplains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_adminComplains.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_adminComplains.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_adminComplains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_adminComplains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cdescriptionDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn,
            this.cstatusDataGridViewTextBoxColumn});
            this.DataGrid_adminComplains.DataSource = this.complainBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_adminComplains.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_adminComplains.DoubleBuffered = true;
            this.DataGrid_adminComplains.EnableHeadersVisualStyles = false;
            this.DataGrid_adminComplains.HeaderBgColor = System.Drawing.Color.Teal;
            this.DataGrid_adminComplains.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_adminComplains.Location = new System.Drawing.Point(0, 77);
            this.DataGrid_adminComplains.Name = "DataGrid_adminComplains";
            this.DataGrid_adminComplains.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_adminComplains.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_adminComplains.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGrid_adminComplains.Size = new System.Drawing.Size(540, 307);
            this.DataGrid_adminComplains.StandardTab = true;
            this.DataGrid_adminComplains.TabIndex = 1;
            this.DataGrid_adminComplains.VirtualMode = true;
            this.DataGrid_adminComplains.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_adminComplains_CellClick);
            // 
            // panel_adminSide
            // 
            this.panel_adminSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_adminSide.BackgroundImage")));
            this.panel_adminSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_adminSide.Controls.Add(this.btn_adminSignout);
            this.panel_adminSide.Controls.Add(this.btn_adminReport);
            this.panel_adminSide.Controls.Add(this.btn_adminDashboard);
            this.panel_adminSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_adminSide.GradientBottomLeft = System.Drawing.Color.Teal;
            this.panel_adminSide.GradientBottomRight = System.Drawing.Color.Teal;
            this.panel_adminSide.GradientTopLeft = System.Drawing.Color.Teal;
            this.panel_adminSide.GradientTopRight = System.Drawing.Color.Teal;
            this.panel_adminSide.Location = new System.Drawing.Point(0, 0);
            this.panel_adminSide.Name = "panel_adminSide";
            this.panel_adminSide.Quality = 10;
            this.panel_adminSide.Size = new System.Drawing.Size(200, 440);
            this.panel_adminSide.TabIndex = 0;
            // 
            // btn_adminSignout
            // 
            this.btn_adminSignout.Activecolor = System.Drawing.Color.Teal;
            this.btn_adminSignout.BackColor = System.Drawing.Color.Teal;
            this.btn_adminSignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminSignout.BorderRadius = 0;
            this.btn_adminSignout.ButtonText = "Sign Out";
            this.btn_adminSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminSignout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_adminSignout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_adminSignout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_adminSignout.Iconimage")));
            this.btn_adminSignout.Iconimage_right = null;
            this.btn_adminSignout.Iconimage_right_Selected = null;
            this.btn_adminSignout.Iconimage_Selected = null;
            this.btn_adminSignout.IconMarginLeft = 0;
            this.btn_adminSignout.IconMarginRight = 0;
            this.btn_adminSignout.IconRightVisible = true;
            this.btn_adminSignout.IconRightZoom = 0D;
            this.btn_adminSignout.IconVisible = true;
            this.btn_adminSignout.IconZoom = 90D;
            this.btn_adminSignout.IsTab = false;
            this.btn_adminSignout.Location = new System.Drawing.Point(0, 211);
            this.btn_adminSignout.Name = "btn_adminSignout";
            this.btn_adminSignout.Normalcolor = System.Drawing.Color.Teal;
            this.btn_adminSignout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adminSignout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_adminSignout.selected = false;
            this.btn_adminSignout.Size = new System.Drawing.Size(200, 48);
            this.btn_adminSignout.TabIndex = 2;
            this.btn_adminSignout.Text = "Sign Out";
            this.btn_adminSignout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminSignout.Textcolor = System.Drawing.Color.White;
            this.btn_adminSignout.TextFont = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminSignout.Click += new System.EventHandler(this.btn_adminSignout_Click);
            // 
            // btn_adminReport
            // 
            this.btn_adminReport.Activecolor = System.Drawing.Color.Teal;
            this.btn_adminReport.BackColor = System.Drawing.Color.Teal;
            this.btn_adminReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminReport.BorderRadius = 0;
            this.btn_adminReport.ButtonText = "Report";
            this.btn_adminReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminReport.DisabledColor = System.Drawing.Color.Gray;
            this.btn_adminReport.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_adminReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_adminReport.Iconimage")));
            this.btn_adminReport.Iconimage_right = null;
            this.btn_adminReport.Iconimage_right_Selected = null;
            this.btn_adminReport.Iconimage_Selected = null;
            this.btn_adminReport.IconMarginLeft = 0;
            this.btn_adminReport.IconMarginRight = 0;
            this.btn_adminReport.IconRightVisible = true;
            this.btn_adminReport.IconRightZoom = 0D;
            this.btn_adminReport.IconVisible = true;
            this.btn_adminReport.IconZoom = 90D;
            this.btn_adminReport.IsTab = false;
            this.btn_adminReport.Location = new System.Drawing.Point(0, 156);
            this.btn_adminReport.Name = "btn_adminReport";
            this.btn_adminReport.Normalcolor = System.Drawing.Color.Teal;
            this.btn_adminReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adminReport.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_adminReport.selected = false;
            this.btn_adminReport.Size = new System.Drawing.Size(200, 48);
            this.btn_adminReport.TabIndex = 1;
            this.btn_adminReport.Text = "Report";
            this.btn_adminReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminReport.Textcolor = System.Drawing.Color.White;
            this.btn_adminReport.TextFont = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminReport.Click += new System.EventHandler(this.btn_adminReport_Click);
            // 
            // btn_adminDashboard
            // 
            this.btn_adminDashboard.Activecolor = System.Drawing.Color.Teal;
            this.btn_adminDashboard.BackColor = System.Drawing.Color.Teal;
            this.btn_adminDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adminDashboard.BorderRadius = 0;
            this.btn_adminDashboard.ButtonText = "Dashboard";
            this.btn_adminDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btn_adminDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_adminDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_adminDashboard.Iconimage")));
            this.btn_adminDashboard.Iconimage_right = null;
            this.btn_adminDashboard.Iconimage_right_Selected = null;
            this.btn_adminDashboard.Iconimage_Selected = null;
            this.btn_adminDashboard.IconMarginLeft = 0;
            this.btn_adminDashboard.IconMarginRight = 0;
            this.btn_adminDashboard.IconRightVisible = true;
            this.btn_adminDashboard.IconRightZoom = 0D;
            this.btn_adminDashboard.IconVisible = true;
            this.btn_adminDashboard.IconZoom = 90D;
            this.btn_adminDashboard.IsTab = false;
            this.btn_adminDashboard.Location = new System.Drawing.Point(0, 102);
            this.btn_adminDashboard.Name = "btn_adminDashboard";
            this.btn_adminDashboard.Normalcolor = System.Drawing.Color.Teal;
            this.btn_adminDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adminDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_adminDashboard.selected = false;
            this.btn_adminDashboard.Size = new System.Drawing.Size(200, 48);
            this.btn_adminDashboard.TabIndex = 0;
            this.btn_adminDashboard.Text = "Dashboard";
            this.btn_adminDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminDashboard.Textcolor = System.Drawing.Color.White;
            this.btn_adminDashboard.TextFont = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adminDashboard.Click += new System.EventHandler(this.btn_adminDashboard_Click);
            // 
            // panel_adminLogin
            // 
            this.panel_adminLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_adminLogin.BackgroundImage")));
            this.panel_adminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_adminLogin.Controls.Add(this.txt_adminPassword);
            this.panel_adminLogin.Controls.Add(this.pictureBox3);
            this.panel_adminLogin.Controls.Add(this.txt_adminUsername);
            this.panel_adminLogin.Controls.Add(this.pictureBox2);
            this.panel_adminLogin.Controls.Add(this.pictureBox1);
            this.panel_adminLogin.Controls.Add(this.btn_adminLogin);
            this.panel_adminLogin.Controls.Add(this.Label_adminLoginError);
            this.panel_adminLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_adminLogin.GradientBottomLeft = System.Drawing.Color.White;
            this.panel_adminLogin.GradientBottomRight = System.Drawing.Color.White;
            this.panel_adminLogin.GradientTopLeft = System.Drawing.Color.White;
            this.panel_adminLogin.GradientTopRight = System.Drawing.Color.White;
            this.panel_adminLogin.Location = new System.Drawing.Point(20, 60);
            this.panel_adminLogin.Name = "panel_adminLogin";
            this.panel_adminLogin.Quality = 10;
            this.panel_adminLogin.Size = new System.Drawing.Size(740, 440);
            this.panel_adminLogin.TabIndex = 1;
            // 
            // _kancha_sysDataSet1
            // 
            this._kancha_sysDataSet1.DataSetName = "_kancha_sysDataSet";
            this._kancha_sysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainTableAdapter
            // 
            this.complainTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AdminReportTableAdapter
            // 
            this.AdminReportTableAdapter.ClearBeforeFill = true;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "Complain ID";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Width = 130;
            // 
            // cdescriptionDataGridViewTextBoxColumn
            // 
            this.cdescriptionDataGridViewTextBoxColumn.DataPropertyName = "c_description";
            this.cdescriptionDataGridViewTextBoxColumn.HeaderText = "Complain Description";
            this.cdescriptionDataGridViewTextBoxColumn.Name = "cdescriptionDataGridViewTextBoxColumn";
            this.cdescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "u_id";
            this.uidDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            // 
            // cstatusDataGridViewTextBoxColumn
            // 
            this.cstatusDataGridViewTextBoxColumn.DataPropertyName = "c_status";
            this.cstatusDataGridViewTextBoxColumn.HeaderText = "Complain Status";
            this.cstatusDataGridViewTextBoxColumn.Name = "cstatusDataGridViewTextBoxColumn";
            this.cstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.panel_adminLogin);
            this.Controls.Add(this.panel_adminPortal);
            this.Name = "AdminForm";
            this.Text = "Admin Portal";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_adminPortal.ResumeLayout(false);
            this.panel_adminReport.ResumeLayout(false);
            this.Panel_adminDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_adminComplains)).EndInit();
            this.panel_adminSide.ResumeLayout(false);
            this.panel_adminLogin.ResumeLayout(false);
            this.panel_adminLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._kancha_sysDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Label_adminLoginError;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_adminPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_adminUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_adminLogin;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_adminPortal;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_adminSide;
        private Bunifu.Framework.UI.BunifuFlatButton btn_adminDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btn_adminSignout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_adminReport;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_adminLogin;
        private Bunifu.Framework.UI.BunifuGradientPanel Panel_adminDashboard;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_adminReport;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_adminComplains;
        private Bunifu.Framework.UI.BunifuFlatButton btn_adminComplainUpdate;
        private MetroFramework.Controls.MetroComboBox ComboBox_adminEmp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_adminCID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_adminUID;
        private _kancha_sysDataSet _kancha_sysDataSet;
        private _kancha_sysDataSet _kancha_sysDataSet1;
        private _kancha_sysDataSet _kancha_sysDataSet2;
        private System.Windows.Forms.BindingSource complainBindingSource;
        private _kancha_sysDataSetTableAdapters.complainTableAdapter complainTableAdapter;
        private _kancha_sysDataSet _kancha_sysDataSet3;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private _kancha_sysDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AdminReportBindingSource;
        private _kancha_sysDataSetTableAdapters.AdminReportTableAdapter AdminReportTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatusDataGridViewTextBoxColumn;
    }
}