namespace UserHospital
{
    partial class DoctorReg
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
            this.dAge = new MetroFramework.Controls.MetroTextBox();
            this.dMaritialstatus = new MetroFramework.Controls.MetroComboBox();
            this.dRegDate = new MetroFramework.Controls.MetroDateTime();
            this.dDob = new MetroFramework.Controls.MetroDateTime();
            this.dBloodGroup = new MetroFramework.Controls.MetroComboBox();
            this.dGender = new MetroFramework.Controls.MetroComboBox();
            this.dName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.dCity = new MetroFramework.Controls.MetroTextBox();
            this.dContactNo = new MetroFramework.Controls.MetroTextBox();
            this.dCountry = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.dAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.dDepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dUsername = new MetroFramework.Controls.MetroTextBox();
            this.dPassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // dAge
            // 
            // 
            // 
            // 
            this.dAge.CustomButton.Image = null;
            this.dAge.CustomButton.Location = new System.Drawing.Point(91, 2);
            this.dAge.CustomButton.Name = "";
            this.dAge.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.dAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dAge.CustomButton.TabIndex = 1;
            this.dAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dAge.CustomButton.UseSelectable = true;
            this.dAge.CustomButton.Visible = false;
            this.dAge.Lines = new string[0];
            this.dAge.Location = new System.Drawing.Point(123, 242);
            this.dAge.MaxLength = 32767;
            this.dAge.Multiline = true;
            this.dAge.Name = "dAge";
            this.dAge.PasswordChar = '\0';
            this.dAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dAge.SelectedText = "";
            this.dAge.SelectionLength = 0;
            this.dAge.SelectionStart = 0;
            this.dAge.ShortcutsEnabled = true;
            this.dAge.Size = new System.Drawing.Size(121, 32);
            this.dAge.TabIndex = 60;
            this.dAge.UseSelectable = true;
            this.dAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dMaritialstatus
            // 
            this.dMaritialstatus.FormattingEnabled = true;
            this.dMaritialstatus.ItemHeight = 23;
            this.dMaritialstatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widow"});
            this.dMaritialstatus.Location = new System.Drawing.Point(123, 326);
            this.dMaritialstatus.Name = "dMaritialstatus";
            this.dMaritialstatus.Size = new System.Drawing.Size(121, 29);
            this.dMaritialstatus.TabIndex = 59;
            this.dMaritialstatus.UseSelectable = true;
            // 
            // dRegDate
            // 
            this.dRegDate.Location = new System.Drawing.Point(123, 65);
            this.dRegDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dRegDate.Name = "dRegDate";
            this.dRegDate.Size = new System.Drawing.Size(220, 29);
            this.dRegDate.TabIndex = 58;
            // 
            // dDob
            // 
            this.dDob.Location = new System.Drawing.Point(123, 206);
            this.dDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.dDob.Name = "dDob";
            this.dDob.Size = new System.Drawing.Size(220, 29);
            this.dDob.TabIndex = 57;
            // 
            // dBloodGroup
            // 
            this.dBloodGroup.FormattingEnabled = true;
            this.dBloodGroup.ItemHeight = 23;
            this.dBloodGroup.Items.AddRange(new object[] {
            "A+",
            "AB+",
            "B+",
            "AB-",
            "B-",
            "A-",
            "O+",
            "O-"});
            this.dBloodGroup.Location = new System.Drawing.Point(123, 289);
            this.dBloodGroup.Name = "dBloodGroup";
            this.dBloodGroup.Size = new System.Drawing.Size(121, 29);
            this.dBloodGroup.TabIndex = 56;
            this.dBloodGroup.UseSelectable = true;
            // 
            // dGender
            // 
            this.dGender.FormattingEnabled = true;
            this.dGender.ItemHeight = 23;
            this.dGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.dGender.Location = new System.Drawing.Point(123, 132);
            this.dGender.Name = "dGender";
            this.dGender.Size = new System.Drawing.Size(105, 29);
            this.dGender.Sorted = true;
            this.dGender.TabIndex = 55;
            this.dGender.UseSelectable = true;
            // 
            // dName
            // 
            // 
            // 
            // 
            this.dName.CustomButton.Image = null;
            this.dName.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.dName.CustomButton.Name = "";
            this.dName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dName.CustomButton.TabIndex = 1;
            this.dName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dName.CustomButton.UseSelectable = true;
            this.dName.CustomButton.Visible = false;
            this.dName.Lines = new string[0];
            this.dName.Location = new System.Drawing.Point(123, 103);
            this.dName.MaxLength = 32767;
            this.dName.Name = "dName";
            this.dName.PasswordChar = '\0';
            this.dName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dName.SelectedText = "";
            this.dName.SelectionLength = 0;
            this.dName.SelectionStart = 0;
            this.dName.ShortcutsEnabled = true;
            this.dName.ShowClearButton = true;
            this.dName.Size = new System.Drawing.Size(220, 23);
            this.dName.TabIndex = 53;
            this.dName.UseSelectable = true;
            this.dName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(7, 324);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 24);
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "Marital Status";
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(34, 103);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 24);
            this.metroLabel7.TabIndex = 50;
            this.metroLabel7.Text = "Name";
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(34, 132);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 24);
            this.metroLabel6.TabIndex = 49;
            this.metroLabel6.Text = "Gender";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(34, 238);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 24);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "Age";
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(7, 290);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 24);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "Blood Group";
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(34, 74);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(119, 24);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Reg Date :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(34, 211);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 24);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "DOB";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(399, 40);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(133, 25);
            this.metroLabel15.TabIndex = 69;
            this.metroLabel15.Text = "Doctor Contact";
            // 
            // dCity
            // 
            // 
            // 
            // 
            this.dCity.CustomButton.Image = null;
            this.dCity.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.dCity.CustomButton.Name = "";
            this.dCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dCity.CustomButton.TabIndex = 1;
            this.dCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dCity.CustomButton.UseSelectable = true;
            this.dCity.CustomButton.Visible = false;
            this.dCity.Lines = new string[0];
            this.dCity.Location = new System.Drawing.Point(488, 126);
            this.dCity.MaxLength = 32767;
            this.dCity.Name = "dCity";
            this.dCity.PasswordChar = '\0';
            this.dCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dCity.SelectedText = "";
            this.dCity.SelectionLength = 0;
            this.dCity.SelectionStart = 0;
            this.dCity.ShortcutsEnabled = true;
            this.dCity.Size = new System.Drawing.Size(220, 23);
            this.dCity.TabIndex = 67;
            this.dCity.UseSelectable = true;
            this.dCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dContactNo
            // 
            // 
            // 
            // 
            this.dContactNo.CustomButton.Image = null;
            this.dContactNo.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.dContactNo.CustomButton.Name = "";
            this.dContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dContactNo.CustomButton.TabIndex = 1;
            this.dContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dContactNo.CustomButton.UseSelectable = true;
            this.dContactNo.CustomButton.Visible = false;
            this.dContactNo.Lines = new string[0];
            this.dContactNo.Location = new System.Drawing.Point(488, 179);
            this.dContactNo.MaxLength = 32767;
            this.dContactNo.Name = "dContactNo";
            this.dContactNo.PasswordChar = '\0';
            this.dContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dContactNo.SelectedText = "";
            this.dContactNo.SelectionLength = 0;
            this.dContactNo.SelectionStart = 0;
            this.dContactNo.ShortcutsEnabled = true;
            this.dContactNo.Size = new System.Drawing.Size(220, 23);
            this.dContactNo.TabIndex = 65;
            this.dContactNo.UseSelectable = true;
            this.dContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dCountry
            // 
            // 
            // 
            // 
            this.dCountry.CustomButton.Image = null;
            this.dCountry.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.dCountry.CustomButton.Name = "";
            this.dCountry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dCountry.CustomButton.TabIndex = 1;
            this.dCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dCountry.CustomButton.UseSelectable = true;
            this.dCountry.CustomButton.Visible = false;
            this.dCountry.Lines = new string[0];
            this.dCountry.Location = new System.Drawing.Point(488, 150);
            this.dCountry.MaxLength = 32767;
            this.dCountry.Name = "dCountry";
            this.dCountry.PasswordChar = '\0';
            this.dCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dCountry.SelectedText = "";
            this.dCountry.SelectionLength = 0;
            this.dCountry.SelectionStart = 0;
            this.dCountry.ShortcutsEnabled = true;
            this.dCountry.Size = new System.Drawing.Size(220, 23);
            this.dCountry.TabIndex = 66;
            this.dCountry.UseSelectable = true;
            this.dCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(399, 126);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(119, 24);
            this.metroLabel13.TabIndex = 64;
            this.metroLabel13.Text = "City";
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(399, 179);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(119, 24);
            this.metroLabel14.TabIndex = 63;
            this.metroLabel14.Text = "Contact No";
            // 
            // metroLabel12
            // 
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(399, 150);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(119, 24);
            this.metroLabel12.TabIndex = 62;
            this.metroLabel12.Text = "Country";
            // 
            // dAddress
            // 
            // 
            // 
            // 
            this.dAddress.CustomButton.Image = null;
            this.dAddress.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.dAddress.CustomButton.Name = "";
            this.dAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dAddress.CustomButton.TabIndex = 1;
            this.dAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dAddress.CustomButton.UseSelectable = true;
            this.dAddress.CustomButton.Visible = false;
            this.dAddress.Lines = new string[0];
            this.dAddress.Location = new System.Drawing.Point(488, 97);
            this.dAddress.MaxLength = 32767;
            this.dAddress.Name = "dAddress";
            this.dAddress.PasswordChar = '\0';
            this.dAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dAddress.SelectedText = "";
            this.dAddress.SelectionLength = 0;
            this.dAddress.SelectionStart = 0;
            this.dAddress.ShortcutsEnabled = true;
            this.dAddress.Size = new System.Drawing.Size(220, 23);
            this.dAddress.TabIndex = 68;
            this.dAddress.UseSelectable = true;
            this.dAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(399, 97);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(119, 24);
            this.metroLabel10.TabIndex = 61;
            this.metroLabel10.Text = "Address";
            // 
            // dDepartment
            // 
            this.dDepartment.FormattingEnabled = true;
            this.dDepartment.ItemHeight = 23;
            this.dDepartment.Items.AddRange(new object[] {
            "Neurology",
            "Orthopaedics",
            "General surgery",
            "Ear nose and throat (ENT)",
            "Cardiology"});
            this.dDepartment.Location = new System.Drawing.Point(123, 171);
            this.dDepartment.Name = "dDepartment";
            this.dDepartment.Size = new System.Drawing.Size(121, 29);
            this.dDepartment.TabIndex = 71;
            this.dDepartment.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(34, 175);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(119, 24);
            this.metroLabel16.TabIndex = 70;
            this.metroLabel16.Text = "Department";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(627, 322);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 33);
            this.metroButton1.TabIndex = 72;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(498, 322);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(114, 33);
            this.metroButton2.TabIndex = 72;
            this.metroButton2.Text = "Back";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(399, 227);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 24);
            this.metroLabel8.TabIndex = 62;
            this.metroLabel8.Text = "UserName";
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(399, 256);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(119, 24);
            this.metroLabel9.TabIndex = 63;
            this.metroLabel9.Text = "PassWord";
            // 
            // dUsername
            // 
            // 
            // 
            // 
            this.dUsername.CustomButton.Image = null;
            this.dUsername.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.dUsername.CustomButton.Name = "";
            this.dUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dUsername.CustomButton.TabIndex = 1;
            this.dUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dUsername.CustomButton.UseSelectable = true;
            this.dUsername.CustomButton.Visible = false;
            this.dUsername.Lines = new string[0];
            this.dUsername.Location = new System.Drawing.Point(488, 227);
            this.dUsername.MaxLength = 32767;
            this.dUsername.Name = "dUsername";
            this.dUsername.PasswordChar = '\0';
            this.dUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dUsername.SelectedText = "";
            this.dUsername.SelectionLength = 0;
            this.dUsername.SelectionStart = 0;
            this.dUsername.ShortcutsEnabled = true;
            this.dUsername.Size = new System.Drawing.Size(220, 23);
            this.dUsername.TabIndex = 66;
            this.dUsername.UseSelectable = true;
            this.dUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dPassword
            // 
            // 
            // 
            // 
            this.dPassword.CustomButton.Image = null;
            this.dPassword.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.dPassword.CustomButton.Name = "";
            this.dPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dPassword.CustomButton.TabIndex = 1;
            this.dPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dPassword.CustomButton.UseSelectable = true;
            this.dPassword.CustomButton.Visible = false;
            this.dPassword.Lines = new string[0];
            this.dPassword.Location = new System.Drawing.Point(488, 256);
            this.dPassword.MaxLength = 32767;
            this.dPassword.Name = "dPassword";
            this.dPassword.PasswordChar = '\0';
            this.dPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dPassword.SelectedText = "";
            this.dPassword.SelectionLength = 0;
            this.dPassword.SelectionStart = 0;
            this.dPassword.ShortcutsEnabled = true;
            this.dPassword.Size = new System.Drawing.Size(220, 23);
            this.dPassword.TabIndex = 65;
            this.dPassword.UseSelectable = true;
            this.dPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DoctorReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 436);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dDepartment);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.dCity);
            this.Controls.Add(this.dPassword);
            this.Controls.Add(this.dContactNo);
            this.Controls.Add(this.dUsername);
            this.Controls.Add(this.dCountry);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.dAddress);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.dAge);
            this.Controls.Add(this.dMaritialstatus);
            this.Controls.Add(this.dRegDate);
            this.Controls.Add(this.dDob);
            this.Controls.Add(this.dBloodGroup);
            this.Controls.Add(this.dGender);
            this.Controls.Add(this.dName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Name = "DoctorReg";
            this.Text = "DoctorReg";
            this.Load += new System.EventHandler(this.DoctorReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox dAge;
        private MetroFramework.Controls.MetroComboBox dMaritialstatus;
        private MetroFramework.Controls.MetroDateTime dRegDate;
        private MetroFramework.Controls.MetroDateTime dDob;
        private MetroFramework.Controls.MetroComboBox dBloodGroup;
        private MetroFramework.Controls.MetroComboBox dGender;
        private MetroFramework.Controls.MetroTextBox dName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox dCity;
        private MetroFramework.Controls.MetroTextBox dContactNo;
        private MetroFramework.Controls.MetroTextBox dCountry;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox dAddress;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox dDepartment;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox dUsername;
        private MetroFramework.Controls.MetroTextBox dPassword;
    }
}