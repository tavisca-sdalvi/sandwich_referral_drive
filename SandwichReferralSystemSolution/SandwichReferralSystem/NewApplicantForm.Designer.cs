namespace SandwichReferralSystem
{
    partial class NewApplicantForm
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
        public void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.ExperienceLabel = new System.Windows.Forms.Label();
            this.ApplicantNameTextbox = new System.Windows.Forms.TextBox();
            this.ExperienceTextbox = new System.Windows.Forms.TextBox();
            this.UploadResumeButton = new System.Windows.Forms.Button();
            this.ResumeTextbox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ReferralIdLabel = new System.Windows.Forms.Label();
            this.ReferrancedByNameTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.UserNameTb = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ReferrencedByValidatorLabel = new System.Windows.Forms.Label();
            this.NameValidatorLabel = new System.Windows.Forms.Label();
            this.PostValidatorLabel = new System.Windows.Forms.Label();
            this.EmailValidatorLabel = new System.Windows.Forms.Label();
            this.QualificationValidatorLabel = new System.Windows.Forms.Label();
            this.DateTextbox = new System.Windows.Forms.TextBox();
            this.ReferrentEmailIdTextBox = new System.Windows.Forms.TextBox();
            this.QualificationTextBox = new System.Windows.Forms.TextBox();
            this.Qualificationlabel = new System.Windows.Forms.Label();
            this.ReferrantEmailLabel = new System.Windows.Forms.Label();
            this.ApplicantExperienceValidatorLabel = new System.Windows.Forms.Label();
            this.DateValidatorLabel = new System.Windows.Forms.Label();
            this.ReferralEmailValidatorLabel = new System.Windows.Forms.Label();
            this.UploadValidatorLabel = new System.Windows.Forms.Label();
            this.ApplicantAppliedForPostComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.NameLabel.Location = new System.Drawing.Point(90, 89);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(102, 19);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Full Name :-";
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostLabel.ForeColor = System.Drawing.Color.LightGray;
            this.PostLabel.Location = new System.Drawing.Point(87, 156);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(161, 19);
            this.PostLabel.TabIndex = 4;
            this.PostLabel.Text = "Applying For Post  :-";
            // 
            // ExperienceLabel
            // 
            this.ExperienceLabel.AutoSize = true;
            this.ExperienceLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExperienceLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ExperienceLabel.Location = new System.Drawing.Point(90, 518);
            this.ExperienceLabel.Name = "ExperienceLabel";
            this.ExperienceLabel.Size = new System.Drawing.Size(182, 19);
            this.ExperienceLabel.TabIndex = 8;
            this.ExperienceLabel.Text = "Years Of Experience  :-";
            // 
            // ApplicantNameTextbox
            // 
            this.ApplicantNameTextbox.BackColor = System.Drawing.Color.Silver;
            this.ApplicantNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApplicantNameTextbox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicantNameTextbox.Location = new System.Drawing.Point(258, 89);
            this.ApplicantNameTextbox.Multiline = true;
            this.ApplicantNameTextbox.Name = "ApplicantNameTextbox";
            this.ApplicantNameTextbox.Size = new System.Drawing.Size(301, 33);
            this.ApplicantNameTextbox.TabIndex = 2;
            this.ApplicantNameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.ApplicantNameTextbox_Validating);
            // 
            // ExperienceTextbox
            // 
            this.ExperienceTextbox.BackColor = System.Drawing.Color.Silver;
            this.ExperienceTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExperienceTextbox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExperienceTextbox.Location = new System.Drawing.Point(91, 554);
            this.ExperienceTextbox.Multiline = true;
            this.ExperienceTextbox.Name = "ExperienceTextbox";
            this.ExperienceTextbox.Size = new System.Drawing.Size(206, 27);
            this.ExperienceTextbox.TabIndex = 9;
            this.ExperienceTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.ExperienceTextbox_Validating);
            // 
            // UploadResumeButton
            // 
            this.UploadResumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UploadResumeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UploadResumeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadResumeButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadResumeButton.ForeColor = System.Drawing.Color.Silver;
            this.UploadResumeButton.Location = new System.Drawing.Point(91, 448);
            this.UploadResumeButton.Name = "UploadResumeButton";
            this.UploadResumeButton.Size = new System.Drawing.Size(137, 32);
            this.UploadResumeButton.TabIndex = 7;
            this.UploadResumeButton.Text = "Upload Resume";
            this.UploadResumeButton.UseVisualStyleBackColor = false;
            this.UploadResumeButton.Click += new System.EventHandler(this.UploadResumeButton_Click);
            // 
            // ResumeTextbox
            // 
            this.ResumeTextbox.BackColor = System.Drawing.Color.Silver;
            this.ResumeTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResumeTextbox.Enabled = false;
            this.ResumeTextbox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeTextbox.Location = new System.Drawing.Point(259, 448);
            this.ResumeTextbox.Multiline = true;
            this.ResumeTextbox.Name = "ResumeTextbox";
            this.ResumeTextbox.Size = new System.Drawing.Size(301, 32);
            this.ResumeTextbox.TabIndex = 8;
            this.ResumeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResumeTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.ResumeTextbox_Validating);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Silver;
            this.SubmitButton.Location = new System.Drawing.Point(259, 638);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(142, 51);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\pgupta\\Desktop\\Sandwich";
            // 
            // ReferralIdLabel
            // 
            this.ReferralIdLabel.AutoSize = true;
            this.ReferralIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReferralIdLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferralIdLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ReferralIdLabel.Location = new System.Drawing.Point(87, 28);
            this.ReferralIdLabel.Name = "ReferralIdLabel";
            this.ReferralIdLabel.Size = new System.Drawing.Size(144, 19);
            this.ReferralIdLabel.TabIndex = 0;
            this.ReferralIdLabel.Text = "Refferenced By  :-";
            this.ReferralIdLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReferrancedByNameTextbox
            // 
            this.ReferrancedByNameTextbox.BackColor = System.Drawing.Color.Silver;
            this.ReferrancedByNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReferrancedByNameTextbox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferrancedByNameTextbox.Location = new System.Drawing.Point(258, 24);
            this.ReferrancedByNameTextbox.Multiline = true;
            this.ReferrancedByNameTextbox.Name = "ReferrancedByNameTextbox";
            this.ReferrancedByNameTextbox.Size = new System.Drawing.Size(301, 33);
            this.ReferrancedByNameTextbox.TabIndex = 1;
            this.ReferrancedByNameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.ReferrancedByNameTextbox_Validating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.LightGray;
            this.emailLabel.Location = new System.Drawing.Point(90, 220);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(143, 19);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "E-Mail Address  :-";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BackColor = System.Drawing.Color.Silver;
            this.EmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextbox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.Location = new System.Drawing.Point(258, 220);
            this.EmailTextbox.Multiline = true;
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(302, 29);
            this.EmailTextbox.TabIndex = 4;
            this.EmailTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTextbox_Validating);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.DateLabel.Location = new System.Drawing.Point(327, 518);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(285, 19);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Date of Submission (yyyy-mm-dd) :-";
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.ForgetPassword);
            this.tabPage1.Controls.Add(this.PasswordLable);
            this.tabPage1.Controls.Add(this.UserNameLable);
            this.tabPage1.Controls.Add(this.PasswordTb);
            this.tabPage1.Controls.Add(this.UserNameTb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(263, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HR View";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(79, 111);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.Location = new System.Drawing.Point(76, 149);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(107, 13);
            this.ForgetPassword.TabIndex = 15;
            this.ForgetPassword.TabStop = true;
            this.ForgetPassword.Text = "Forgot Password ???";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(29, 81);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(53, 13);
            this.PasswordLable.TabIndex = 3;
            this.PasswordLable.Text = "Password";
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(29, 27);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(57, 13);
            this.UserNameLable.TabIndex = 2;
            this.UserNameLable.Text = "UserName";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(125, 75);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(100, 20);
            this.PasswordTb.TabIndex = 13;
            // 
            // UserNameTb
            // 
            this.UserNameTb.Location = new System.Drawing.Point(125, 20);
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.Size = new System.Drawing.Size(100, 20);
            this.UserNameTb.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(603, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(271, 211);
            this.tabControl1.TabIndex = 15;
            // 
            // ReferrencedByValidatorLabel
            // 
            this.ReferrencedByValidatorLabel.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferrencedByValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ReferrencedByValidatorLabel.Location = new System.Drawing.Point(255, 60);
            this.ReferrencedByValidatorLabel.Name = "ReferrencedByValidatorLabel";
            this.ReferrencedByValidatorLabel.Size = new System.Drawing.Size(304, 23);
            this.ReferrencedByValidatorLabel.TabIndex = 5;
            // 
            // NameValidatorLabel
            // 
            this.NameValidatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.NameValidatorLabel.Location = new System.Drawing.Point(255, 128);
            this.NameValidatorLabel.Name = "NameValidatorLabel";
            this.NameValidatorLabel.Size = new System.Drawing.Size(305, 23);
            this.NameValidatorLabel.TabIndex = 4;
            // 
            // PostValidatorLabel
            // 
            this.PostValidatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PostValidatorLabel.Location = new System.Drawing.Point(255, 186);
            this.PostValidatorLabel.Name = "PostValidatorLabel";
            this.PostValidatorLabel.Size = new System.Drawing.Size(304, 23);
            this.PostValidatorLabel.TabIndex = 3;
            // 
            // EmailValidatorLabel
            // 
            this.EmailValidatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EmailValidatorLabel.Location = new System.Drawing.Point(255, 252);
            this.EmailValidatorLabel.Name = "EmailValidatorLabel";
            this.EmailValidatorLabel.Size = new System.Drawing.Size(305, 23);
            this.EmailValidatorLabel.TabIndex = 2;
            // 
            // QualificationValidatorLabel
            // 
            this.QualificationValidatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualificationValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.QualificationValidatorLabel.Location = new System.Drawing.Point(256, 320);
            this.QualificationValidatorLabel.Name = "QualificationValidatorLabel";
            this.QualificationValidatorLabel.Size = new System.Drawing.Size(302, 37);
            this.QualificationValidatorLabel.TabIndex = 0;
            // 
            // DateTextbox
            // 
            this.DateTextbox.BackColor = System.Drawing.Color.Silver;
            this.DateTextbox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextbox.Location = new System.Drawing.Point(331, 554);
            this.DateTextbox.Multiline = true;
            this.DateTextbox.Name = "DateTextbox";
            this.DateTextbox.Size = new System.Drawing.Size(217, 27);
            this.DateTextbox.TabIndex = 10;
            this.DateTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.DateTextbox_Validating);
            // 
            // ReferrentEmailIdTextBox
            // 
            this.ReferrentEmailIdTextBox.BackColor = System.Drawing.Color.Silver;
            this.ReferrentEmailIdTextBox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ReferrentEmailIdTextBox.Location = new System.Drawing.Point(256, 362);
            this.ReferrentEmailIdTextBox.Multiline = true;
            this.ReferrentEmailIdTextBox.Name = "ReferrentEmailIdTextBox";
            this.ReferrentEmailIdTextBox.Size = new System.Drawing.Size(302, 32);
            this.ReferrentEmailIdTextBox.TabIndex = 6;
            this.ReferrentEmailIdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ReferrentEmailIdTextBox_Validating);
            // 
            // QualificationTextBox
            // 
            this.QualificationTextBox.BackColor = System.Drawing.Color.Silver;
            this.QualificationTextBox.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.QualificationTextBox.Location = new System.Drawing.Point(259, 286);
            this.QualificationTextBox.Multiline = true;
            this.QualificationTextBox.Name = "QualificationTextBox";
            this.QualificationTextBox.Size = new System.Drawing.Size(302, 32);
            this.QualificationTextBox.TabIndex = 5;
            this.QualificationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.QualificationTextBox_Validating);
            // 
            // Qualificationlabel
            // 
            this.Qualificationlabel.AutoSize = true;
            this.Qualificationlabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qualificationlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Qualificationlabel.Location = new System.Drawing.Point(87, 286);
            this.Qualificationlabel.Name = "Qualificationlabel";
            this.Qualificationlabel.Size = new System.Drawing.Size(125, 19);
            this.Qualificationlabel.TabIndex = 18;
            this.Qualificationlabel.Text = "Qualification :-";
            // 
            // ReferrantEmailLabel
            // 
            this.ReferrantEmailLabel.AutoSize = true;
            this.ReferrantEmailLabel.BackColor = System.Drawing.Color.DimGray;
            this.ReferrantEmailLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferrantEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReferrantEmailLabel.Location = new System.Drawing.Point(75, 375);
            this.ReferrantEmailLabel.Name = "ReferrantEmailLabel";
            this.ReferrantEmailLabel.Size = new System.Drawing.Size(158, 19);
            this.ReferrantEmailLabel.TabIndex = 19;
            this.ReferrantEmailLabel.Text = "ReferrentEmailId :-";
            // 
            // ApplicantExperienceValidatorLabel
            // 
            this.ApplicantExperienceValidatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicantExperienceValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ApplicantExperienceValidatorLabel.Location = new System.Drawing.Point(88, 584);
            this.ApplicantExperienceValidatorLabel.Name = "ApplicantExperienceValidatorLabel";
            this.ApplicantExperienceValidatorLabel.Size = new System.Drawing.Size(203, 23);
            this.ApplicantExperienceValidatorLabel.TabIndex = 2;
            // 
            // DateValidatorLabel
            // 
            this.DateValidatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DateValidatorLabel.Location = new System.Drawing.Point(328, 584);
            this.DateValidatorLabel.Name = "DateValidatorLabel";
            this.DateValidatorLabel.Size = new System.Drawing.Size(220, 23);
            this.DateValidatorLabel.TabIndex = 21;
            // 
            // ReferralEmailValidatorLabel
            // 
            this.ReferralEmailValidatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferralEmailValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ReferralEmailValidatorLabel.Location = new System.Drawing.Point(266, 407);
            this.ReferralEmailValidatorLabel.Name = "ReferralEmailValidatorLabel";
            this.ReferralEmailValidatorLabel.Size = new System.Drawing.Size(293, 23);
            this.ReferralEmailValidatorLabel.TabIndex = 22;
            // 
            // UploadValidatorLabel
            // 
            this.UploadValidatorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.UploadValidatorLabel.Location = new System.Drawing.Point(259, 483);
            this.UploadValidatorLabel.Name = "UploadValidatorLabel";
            this.UploadValidatorLabel.Size = new System.Drawing.Size(299, 23);
            this.UploadValidatorLabel.TabIndex = 23;
            // 
            // ApplicantAppliedForPostComboBox
            // 
            this.ApplicantAppliedForPostComboBox.BackColor = System.Drawing.Color.LightGray;
            this.ApplicantAppliedForPostComboBox.DropDownHeight = 150;
            this.ApplicantAppliedForPostComboBox.FormattingEnabled = true;
            this.ApplicantAppliedForPostComboBox.IntegralHeight = false;
            this.ApplicantAppliedForPostComboBox.Items.AddRange(new object[] {
            "Developer\t",
            "Marketing",
            "HR",
            "DBA",
            "Tester",
            "Junior Programmer",
            "Senior Programmer"});
            this.ApplicantAppliedForPostComboBox.Location = new System.Drawing.Point(258, 157);
            this.ApplicantAppliedForPostComboBox.Name = "ApplicantAppliedForPostComboBox";
            this.ApplicantAppliedForPostComboBox.Size = new System.Drawing.Size(302, 21);
            this.ApplicantAppliedForPostComboBox.TabIndex = 3;
            this.ApplicantAppliedForPostComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ApplicantAppliedForPostComboBox_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SandwichReferralSystem.Properties.Resources.logo_sprite;
            this.pictureBox1.Location = new System.Drawing.Point(603, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 56);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(604, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "ReFerral System";
            // 
            // NewApplicantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApplicantAppliedForPostComboBox);
            this.Controls.Add(this.UploadValidatorLabel);
            this.Controls.Add(this.ReferralEmailValidatorLabel);
            this.Controls.Add(this.DateValidatorLabel);
            this.Controls.Add(this.ApplicantExperienceValidatorLabel);
            this.Controls.Add(this.ReferrantEmailLabel);
            this.Controls.Add(this.Qualificationlabel);
            this.Controls.Add(this.QualificationTextBox);
            this.Controls.Add(this.ReferrentEmailIdTextBox);
            this.Controls.Add(this.QualificationValidatorLabel);
            this.Controls.Add(this.EmailValidatorLabel);
            this.Controls.Add(this.PostValidatorLabel);
            this.Controls.Add(this.NameValidatorLabel);
            this.Controls.Add(this.ReferrencedByValidatorLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DateTextbox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.ReferrancedByNameTextbox);
            this.Controls.Add(this.ReferralIdLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ResumeTextbox);
            this.Controls.Add(this.UploadResumeButton);
            this.Controls.Add(this.ExperienceTextbox);
            this.Controls.Add(this.ApplicantNameTextbox);
            this.Controls.Add(this.ExperienceLabel);
            this.Controls.Add(this.PostLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "NewApplicantForm";
            this.Text = "Page1";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label ExperienceLabel;
        public System.Windows.Forms.TextBox ApplicantNameTextbox;
        public System.Windows.Forms.TextBox ExperienceTextbox;

        private System.Windows.Forms.Button UploadResumeButton;
        public System.Windows.Forms.TextBox ResumeTextbox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label ReferralIdLabel;
        public System.Windows.Forms.TextBox ReferrancedByNameTextbox;
        private System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox UserNameTb;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel ForgetPassword;
        private System.Windows.Forms.Label ReferrencedByValidatorLabel;
        private System.Windows.Forms.Label NameValidatorLabel;
        private System.Windows.Forms.Label PostValidatorLabel;
        private System.Windows.Forms.Label EmailValidatorLabel;
        private System.Windows.Forms.Label QualificationValidatorLabel;
        public System.Windows.Forms.TextBox DateTextbox;
        private System.Windows.Forms.TextBox ReferrentEmailIdTextBox;
        private System.Windows.Forms.TextBox QualificationTextBox;
        private System.Windows.Forms.Label Qualificationlabel;
        private System.Windows.Forms.Label ReferrantEmailLabel;
        private System.Windows.Forms.Label ApplicantExperienceValidatorLabel;
        private System.Windows.Forms.Label DateValidatorLabel;
        private System.Windows.Forms.Label ReferralEmailValidatorLabel;
        private System.Windows.Forms.Label UploadValidatorLabel;
        private System.Windows.Forms.ComboBox ApplicantAppliedForPostComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

