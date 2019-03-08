namespace UserHospital
{
    partial class SignUp
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PDepartment = new MetroFramework.Controls.MetroComboBox();
            this.PBloodGroup = new MetroFramework.Controls.MetroComboBox();
            this.PGender = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.POccupation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.PCity = new MetroFramework.Controls.MetroTextBox();
            this.PName = new MetroFramework.Controls.MetroTextBox();
            this.PContactNo = new MetroFramework.Controls.MetroTextBox();
            this.PCountry = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.PAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PDob = new MetroFramework.Controls.MetroDateTime();
            this.PRegDate = new MetroFramework.Controls.MetroDateTime();
            this.PMaritialstatus = new MetroFramework.Controls.MetroComboBox();
            this.PConsulant = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(650, 374);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 33);
            this.metroButton1.TabIndex = 39;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PDepartment
            // 
            this.PDepartment.FormattingEnabled = true;
            this.PDepartment.ItemHeight = 23;
            this.PDepartment.Items.AddRange(new object[] {
            "Neurology",
            "Orthopaedics",
            "General surgery",
            "Ear nose and throat (ENT)",
            "Cardiology"});
            this.PDepartment.Location = new System.Drawing.Point(510, 285);
            this.PDepartment.Name = "PDepartment";
            this.PDepartment.Size = new System.Drawing.Size(121, 29);
            this.PDepartment.TabIndex = 38;
            this.PDepartment.UseSelectable = true;
            this.PDepartment.SelectedIndexChanged += new System.EventHandler(this.PDepartment_SelectedIndexChanged);
            // 
            // PBloodGroup
            // 
            this.PBloodGroup.FormattingEnabled = true;
            this.PBloodGroup.ItemHeight = 23;
            this.PBloodGroup.Items.AddRange(new object[] {
            "A+",
            "AB+",
            "B+",
            "AB-",
            "B-",
            "A-",
            "O+",
            "O-"});
            this.PBloodGroup.Location = new System.Drawing.Point(149, 341);
            this.PBloodGroup.Name = "PBloodGroup";
            this.PBloodGroup.Size = new System.Drawing.Size(121, 29);
            this.PBloodGroup.TabIndex = 37;
            this.PBloodGroup.UseSelectable = true;
            // 
            // PGender
            // 
            this.PGender.FormattingEnabled = true;
            this.PGender.ItemHeight = 23;
            this.PGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.PGender.Location = new System.Drawing.Point(149, 184);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(105, 29);
            this.PGender.Sorted = true;
            this.PGender.TabIndex = 36;
            this.PGender.UseSelectable = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(408, 257);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(136, 25);
            this.metroLabel18.TabIndex = 35;
            this.metroLabel18.Text = "Hospital Details";
            this.metroLabel18.Click += new System.EventHandler(this.metroLabel18_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(408, 60);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(131, 25);
            this.metroLabel15.TabIndex = 34;
            this.metroLabel15.Text = "Patient Contact";
            // 
            // metroLabel11
            // 
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(60, 77);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(194, 33);
            this.metroLabel11.TabIndex = 33;
            this.metroLabel11.Text = "Patient Details";
            // 
            // POccupation
            // 
            // 
            // 
            // 
            this.POccupation.CustomButton.Image = null;
            this.POccupation.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.POccupation.CustomButton.Name = "";
            this.POccupation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.POccupation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.POccupation.CustomButton.TabIndex = 1;
            this.POccupation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.POccupation.CustomButton.UseSelectable = true;
            this.POccupation.CustomButton.Visible = false;
            this.POccupation.Lines = new string[0];
            this.POccupation.Location = new System.Drawing.Point(149, 231);
            this.POccupation.MaxLength = 32767;
            this.POccupation.Name = "POccupation";
            this.POccupation.PasswordChar = '\0';
            this.POccupation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.POccupation.SelectedText = "";
            this.POccupation.SelectionLength = 0;
            this.POccupation.SelectionStart = 0;
            this.POccupation.ShortcutsEnabled = true;
            this.POccupation.Size = new System.Drawing.Size(220, 23);
            this.POccupation.TabIndex = 29;
            this.POccupation.UseSelectable = true;
            this.POccupation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.POccupation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(60, 231);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 24);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "Occupation";
            // 
            // PCity
            // 
            // 
            // 
            // 
            this.PCity.CustomButton.Image = null;
            this.PCity.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.PCity.CustomButton.Name = "";
            this.PCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PCity.CustomButton.TabIndex = 1;
            this.PCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PCity.CustomButton.UseSelectable = true;
            this.PCity.CustomButton.Visible = false;
            this.PCity.Lines = new string[0];
            this.PCity.Location = new System.Drawing.Point(497, 146);
            this.PCity.MaxLength = 32767;
            this.PCity.Name = "PCity";
            this.PCity.PasswordChar = '\0';
            this.PCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PCity.SelectedText = "";
            this.PCity.SelectionLength = 0;
            this.PCity.SelectionStart = 0;
            this.PCity.ShortcutsEnabled = true;
            this.PCity.Size = new System.Drawing.Size(220, 23);
            this.PCity.TabIndex = 26;
            this.PCity.UseSelectable = true;
            this.PCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PName
            // 
            // 
            // 
            // 
            this.PName.CustomButton.Image = null;
            this.PName.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.PName.CustomButton.Name = "";
            this.PName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PName.CustomButton.TabIndex = 1;
            this.PName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PName.CustomButton.UseSelectable = true;
            this.PName.CustomButton.Visible = false;
            this.PName.Lines = new string[0];
            this.PName.Location = new System.Drawing.Point(149, 155);
            this.PName.MaxLength = 32767;
            this.PName.Name = "PName";
            this.PName.PasswordChar = '\0';
            this.PName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PName.SelectedText = "";
            this.PName.SelectionLength = 0;
            this.PName.SelectionStart = 0;
            this.PName.ShortcutsEnabled = true;
            this.PName.ShowClearButton = true;
            this.PName.Size = new System.Drawing.Size(220, 23);
            this.PName.TabIndex = 25;
            this.PName.UseSelectable = true;
            this.PName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PContactNo
            // 
            // 
            // 
            // 
            this.PContactNo.CustomButton.Image = null;
            this.PContactNo.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.PContactNo.CustomButton.Name = "";
            this.PContactNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PContactNo.CustomButton.TabIndex = 1;
            this.PContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PContactNo.CustomButton.UseSelectable = true;
            this.PContactNo.CustomButton.Visible = false;
            this.PContactNo.Lines = new string[0];
            this.PContactNo.Location = new System.Drawing.Point(497, 204);
            this.PContactNo.MaxLength = 32767;
            this.PContactNo.Name = "PContactNo";
            this.PContactNo.PasswordChar = '\0';
            this.PContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PContactNo.SelectedText = "";
            this.PContactNo.SelectionLength = 0;
            this.PContactNo.SelectionStart = 0;
            this.PContactNo.ShortcutsEnabled = true;
            this.PContactNo.Size = new System.Drawing.Size(220, 23);
            this.PContactNo.TabIndex = 22;
            this.PContactNo.UseSelectable = true;
            this.PContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PCountry
            // 
            // 
            // 
            // 
            this.PCountry.CustomButton.Image = null;
            this.PCountry.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.PCountry.CustomButton.Name = "";
            this.PCountry.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PCountry.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PCountry.CustomButton.TabIndex = 1;
            this.PCountry.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PCountry.CustomButton.UseSelectable = true;
            this.PCountry.CustomButton.Visible = false;
            this.PCountry.Lines = new string[0];
            this.PCountry.Location = new System.Drawing.Point(497, 175);
            this.PCountry.MaxLength = 32767;
            this.PCountry.Name = "PCountry";
            this.PCountry.PasswordChar = '\0';
            this.PCountry.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PCountry.SelectedText = "";
            this.PCountry.SelectionLength = 0;
            this.PCountry.SelectionStart = 0;
            this.PCountry.ShortcutsEnabled = true;
            this.PCountry.Size = new System.Drawing.Size(220, 23);
            this.PCountry.TabIndex = 23;
            this.PCountry.UseSelectable = true;
            this.PCountry.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PCountry.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(33, 376);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 24);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Marital Status";
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(408, 146);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(119, 24);
            this.metroLabel13.TabIndex = 19;
            this.metroLabel13.Text = "City";
            // 
            // metroLabel17
            // 
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(394, 318);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(119, 24);
            this.metroLabel17.TabIndex = 18;
            this.metroLabel17.Text = "Consultant Name";
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(408, 204);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(119, 24);
            this.metroLabel14.TabIndex = 17;
            this.metroLabel14.Text = "Contact No";
            // 
            // metroLabel16
            // 
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(421, 289);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(119, 24);
            this.metroLabel16.TabIndex = 16;
            this.metroLabel16.Text = "Department";
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(60, 155);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 24);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Name";
            // 
            // metroLabel12
            // 
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(408, 175);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(119, 24);
            this.metroLabel12.TabIndex = 14;
            this.metroLabel12.Text = "Country";
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(60, 184);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 24);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Gender";
            // 
            // PAddress
            // 
            // 
            // 
            // 
            this.PAddress.CustomButton.Image = null;
            this.PAddress.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.PAddress.CustomButton.Name = "";
            this.PAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PAddress.CustomButton.TabIndex = 1;
            this.PAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PAddress.CustomButton.UseSelectable = true;
            this.PAddress.CustomButton.Visible = false;
            this.PAddress.Lines = new string[0];
            this.PAddress.Location = new System.Drawing.Point(497, 117);
            this.PAddress.MaxLength = 32767;
            this.PAddress.Name = "PAddress";
            this.PAddress.PasswordChar = '\0';
            this.PAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PAddress.SelectedText = "";
            this.PAddress.SelectionLength = 0;
            this.PAddress.SelectionStart = 0;
            this.PAddress.ShortcutsEnabled = true;
            this.PAddress.Size = new System.Drawing.Size(220, 23);
            this.PAddress.TabIndex = 32;
            this.PAddress.UseSelectable = true;
            this.PAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(60, 290);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 24);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Age";
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(408, 117);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(119, 24);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(33, 342);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 24);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Blood Group";
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(60, 126);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(119, 24);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Reg Date :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(60, 263);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 24);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "DOB";
            // 
            // PDob
            // 
            this.PDob.Location = new System.Drawing.Point(149, 258);
            this.PDob.MinimumSize = new System.Drawing.Size(0, 29);
            this.PDob.Name = "PDob";
            this.PDob.Size = new System.Drawing.Size(220, 29);
            this.PDob.TabIndex = 40;
            // 
            // PRegDate
            // 
            this.PRegDate.Location = new System.Drawing.Point(149, 117);
            this.PRegDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.PRegDate.Name = "PRegDate";
            this.PRegDate.Size = new System.Drawing.Size(220, 29);
            this.PRegDate.TabIndex = 41;
            // 
            // PMaritialstatus
            // 
            this.PMaritialstatus.FormattingEnabled = true;
            this.PMaritialstatus.ItemHeight = 23;
            this.PMaritialstatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widow"});
            this.PMaritialstatus.Location = new System.Drawing.Point(149, 378);
            this.PMaritialstatus.Name = "PMaritialstatus";
            this.PMaritialstatus.Size = new System.Drawing.Size(121, 29);
            this.PMaritialstatus.TabIndex = 42;
            this.PMaritialstatus.UseSelectable = true;
            // 
            // PConsulant
            // 
            this.PConsulant.FormattingEnabled = true;
            this.PConsulant.ItemHeight = 23;
            this.PConsulant.Location = new System.Drawing.Point(510, 321);
            this.PConsulant.Name = "PConsulant";
            this.PConsulant.Size = new System.Drawing.Size(121, 29);
            this.PConsulant.TabIndex = 43;
            this.PConsulant.UseSelectable = true;
            this.PConsulant.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(149, 294);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(121, 31);
            this.metroTextBox1.TabIndex = 44;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(517, 374);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(114, 33);
            this.metroButton2.TabIndex = 45;
            this.metroButton2.Text = "Back";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 427);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.PConsulant);
            this.Controls.Add(this.PMaritialstatus);
            this.Controls.Add(this.PRegDate);
            this.Controls.Add(this.PDob);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.PDepartment);
            this.Controls.Add(this.PBloodGroup);
            this.Controls.Add(this.PGender);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.POccupation);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.PCity);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.PContactNo);
            this.Controls.Add(this.PCountry);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.PAddress);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SignUp";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox PDepartment;
        private MetroFramework.Controls.MetroComboBox PBloodGroup;
        private MetroFramework.Controls.MetroComboBox PGender;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox POccupation;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox PCity;
        private MetroFramework.Controls.MetroTextBox PName;
        private MetroFramework.Controls.MetroTextBox PContactNo;
        private MetroFramework.Controls.MetroTextBox PCountry;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox PAddress;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime PDob;
        private MetroFramework.Controls.MetroDateTime PRegDate;
        private MetroFramework.Controls.MetroComboBox PMaritialstatus;
        private MetroFramework.Controls.MetroComboBox PConsulant;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;

    }
}