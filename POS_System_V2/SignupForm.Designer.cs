namespace POS_System_V2
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLbl = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.mobileNumberLbl = new System.Windows.Forms.Label();
            this.txtUserMobileNumber = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.txtconfirmPassword = new System.Windows.Forms.TextBox();
            this.showPasswordCB = new System.Windows.Forms.CheckBox();
            this.Signupbtn = new System.Windows.Forms.Button();
            this.LinkToLoginForm = new System.Windows.Forms.LinkLabel();
            this.txtUserAge = new System.Windows.Forms.NumericUpDown();
            this.txtUserAddress = new System.Windows.Forms.TextBox();
            this.cmbUserGender = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 60);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 16);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ageLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mobileNumberLbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtUserMobileNumber, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.passwordLbl, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtUserPassword, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.genderLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addressLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.emailLbl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtUserEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.confirmPasswordLbl, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtconfirmPassword, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.showPasswordCB, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Signupbtn, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.LinkToLoginForm, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtUserAge, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUserAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbUserGender, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 454);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.Green;
            this.nameLbl.Location = new System.Drawing.Point(3, 11);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(48, 16);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(3, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Enter full name";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // ageLbl
            // 
            this.ageLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.ForeColor = System.Drawing.Color.Green;
            this.ageLbl.Location = new System.Drawing.Point(3, 89);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(35, 16);
            this.ageLbl.TabIndex = 0;
            this.ageLbl.Text = "Age";
            // 
            // mobileNumberLbl
            // 
            this.mobileNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mobileNumberLbl.AutoSize = true;
            this.mobileNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumberLbl.ForeColor = System.Drawing.Color.Green;
            this.mobileNumberLbl.Location = new System.Drawing.Point(3, 167);
            this.mobileNumberLbl.Name = "mobileNumberLbl";
            this.mobileNumberLbl.Size = new System.Drawing.Size(112, 16);
            this.mobileNumberLbl.TabIndex = 0;
            this.mobileNumberLbl.Text = "Mobile Number";
            // 
            // txtUserMobileNumber
            // 
            this.txtUserMobileNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserMobileNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtUserMobileNumber.Location = new System.Drawing.Point(3, 204);
            this.txtUserMobileNumber.MaxLength = 11;
            this.txtUserMobileNumber.Name = "txtUserMobileNumber";
            this.txtUserMobileNumber.Size = new System.Drawing.Size(223, 20);
            this.txtUserMobileNumber.TabIndex = 4;
            this.txtUserMobileNumber.Text = "Enter mobile number";
            this.txtUserMobileNumber.Enter += new System.EventHandler(this.txtUserMobileNumber_Enter);
            this.txtUserMobileNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserMobileNumber_KeyPress);
            this.txtUserMobileNumber.Leave += new System.EventHandler(this.txtUserMobileNumber_Leave);
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.Green;
            this.passwordLbl.Location = new System.Drawing.Point(3, 245);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(75, 16);
            this.passwordLbl.TabIndex = 0;
            this.passwordLbl.Text = "Password";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtUserPassword.Location = new System.Drawing.Point(3, 282);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(223, 20);
            this.txtUserPassword.TabIndex = 6;
            this.txtUserPassword.Text = "Enter password";
            this.txtUserPassword.UseSystemPasswordChar = true;
            this.txtUserPassword.Enter += new System.EventHandler(this.txtUserPassword_Enter);
            this.txtUserPassword.Leave += new System.EventHandler(this.txtUserPassword_Leave);
            // 
            // genderLbl
            // 
            this.genderLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.Green;
            this.genderLbl.Location = new System.Drawing.Point(293, 11);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(58, 16);
            this.genderLbl.TabIndex = 0;
            this.genderLbl.Text = "Gender";
            // 
            // addressLbl
            // 
            this.addressLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.ForeColor = System.Drawing.Color.Green;
            this.addressLbl.Location = new System.Drawing.Point(293, 89);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(65, 16);
            this.addressLbl.TabIndex = 0;
            this.addressLbl.Text = "Address";
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.Green;
            this.emailLbl.Location = new System.Drawing.Point(293, 167);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(46, 16);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtUserEmail.Location = new System.Drawing.Point(293, 204);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(223, 20);
            this.txtUserEmail.TabIndex = 5;
            this.txtUserEmail.Text = "Enter email address";
            this.txtUserEmail.Enter += new System.EventHandler(this.txtUserEmail_Enter);
            this.txtUserEmail.Leave += new System.EventHandler(this.txtUserEmail_Leave);
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLbl.ForeColor = System.Drawing.Color.Green;
            this.confirmPasswordLbl.Location = new System.Drawing.Point(293, 245);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(131, 16);
            this.confirmPasswordLbl.TabIndex = 0;
            this.confirmPasswordLbl.Text = "Confirm Password";
            // 
            // txtconfirmPassword
            // 
            this.txtconfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtconfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtconfirmPassword.Location = new System.Drawing.Point(293, 282);
            this.txtconfirmPassword.Name = "txtconfirmPassword";
            this.txtconfirmPassword.Size = new System.Drawing.Size(223, 20);
            this.txtconfirmPassword.TabIndex = 7;
            this.txtconfirmPassword.Text = "Re-enter password";
            this.txtconfirmPassword.UseSystemPasswordChar = true;
            this.txtconfirmPassword.Enter += new System.EventHandler(this.txtconfirmPassword_Enter);
            this.txtconfirmPassword.Leave += new System.EventHandler(this.txtconfirmPassword_Leave);
            // 
            // showPasswordCB
            // 
            this.showPasswordCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.showPasswordCB.AutoSize = true;
            this.showPasswordCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCB.ForeColor = System.Drawing.Color.Green;
            this.showPasswordCB.Location = new System.Drawing.Point(3, 323);
            this.showPasswordCB.Name = "showPasswordCB";
            this.showPasswordCB.Size = new System.Drawing.Size(115, 17);
            this.showPasswordCB.TabIndex = 10;
            this.showPasswordCB.Text = "Show Password";
            this.showPasswordCB.UseVisualStyleBackColor = true;
            this.showPasswordCB.CheckedChanged += new System.EventHandler(this.showPasswordCB_CheckedChanged);
            // 
            // Signupbtn
            // 
            this.Signupbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Signupbtn.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.Signupbtn, 2);
            this.Signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbtn.ForeColor = System.Drawing.Color.White;
            this.Signupbtn.Location = new System.Drawing.Point(167, 369);
            this.Signupbtn.Name = "Signupbtn";
            this.tableLayoutPanel1.SetRowSpan(this.Signupbtn, 2);
            this.Signupbtn.Size = new System.Drawing.Size(245, 41);
            this.Signupbtn.TabIndex = 8;
            this.Signupbtn.Text = "Sign up";
            this.Signupbtn.UseVisualStyleBackColor = false;
            this.Signupbtn.Click += new System.EventHandler(this.Signupbtn_Click);
            // 
            // LinkToLoginForm
            // 
            this.LinkToLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinkToLoginForm.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LinkToLoginForm, 2);
            this.LinkToLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkToLoginForm.Location = new System.Drawing.Point(178, 433);
            this.LinkToLoginForm.Name = "LinkToLoginForm";
            this.LinkToLoginForm.Size = new System.Drawing.Size(223, 16);
            this.LinkToLoginForm.TabIndex = 9;
            this.LinkToLoginForm.TabStop = true;
            this.LinkToLoginForm.Text = "Already Registered? Click here";
            this.LinkToLoginForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToLoginForm_LinkClicked);
            // 
            // txtUserAge
            // 
            this.txtUserAge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserAge.Location = new System.Drawing.Point(3, 126);
            this.txtUserAge.Name = "txtUserAge";
            this.txtUserAge.Size = new System.Drawing.Size(223, 20);
            this.txtUserAge.TabIndex = 2;
            this.txtUserAge.Leave += new System.EventHandler(this.txtUserAge_Leave);
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtUserAddress.Location = new System.Drawing.Point(293, 126);
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Size = new System.Drawing.Size(223, 20);
            this.txtUserAddress.TabIndex = 3;
            this.txtUserAddress.Text = "Enter your residential address";
            this.txtUserAddress.Enter += new System.EventHandler(this.txtUserAddress_Enter);
            this.txtUserAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserAddress_KeyPress);
            this.txtUserAddress.Leave += new System.EventHandler(this.txtUserAddress_Leave);
            // 
            // cmbUserGender
            // 
            this.cmbUserGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbUserGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUserGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUserGender.ForeColor = System.Drawing.Color.Gray;
            this.cmbUserGender.FormattingEnabled = true;
            this.cmbUserGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbUserGender.Location = new System.Drawing.Point(293, 48);
            this.cmbUserGender.Name = "cmbUserGender";
            this.cmbUserGender.Size = new System.Drawing.Size(223, 21);
            this.cmbUserGender.TabIndex = 1;
            this.cmbUserGender.Text = "Select gender";
            this.cmbUserGender.Enter += new System.EventHandler(this.cmbUserGender_Enter);
            this.cmbUserGender.Leave += new System.EventHandler(this.cmbUserGender_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(593, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label mobileNumberLbl;
        private System.Windows.Forms.TextBox txtUserMobileNumber;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.TextBox txtconfirmPassword;
        private System.Windows.Forms.CheckBox showPasswordCB;
        private System.Windows.Forms.Button Signupbtn;
        private System.Windows.Forms.LinkLabel LinkToLoginForm;
        private System.Windows.Forms.ComboBox cmbUserGender;
        private System.Windows.Forms.NumericUpDown txtUserAge;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}