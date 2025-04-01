namespace Driving_License_Management
{
    partial class frmAddOrEditPerson
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lklblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.cbxNationality = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lklblSetImage = new System.Windows.Forms.LinkLabel();
            this.txtbLastname = new System.Windows.Forms.TextBox();
            this.txtbFirstname = new System.Windows.Forms.TextBox();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbNationalID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbPersonalPhoto = new System.Windows.Forms.PictureBox();
            this.txtbThirdname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbSecondname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.erpCheckMandatorytxtbX = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCheckMandatorytxtbX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(12, 58);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(895, 29);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "????";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(130, 84);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(38, 21);
            this.lblPersonID.TabIndex = 3;
            this.lblPersonID.Text = "????";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lklblRemoveImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.txtbAddress);
            this.panel1.Controls.Add(this.cbxNationality);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lklblSetImage);
            this.panel1.Controls.Add(this.txtbLastname);
            this.panel1.Controls.Add(this.txtbFirstname);
            this.panel1.Controls.Add(this.txtbPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtbNationalID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pbPersonalPhoto);
            this.panel1.Controls.Add(this.txtbThirdname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtbEmail);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtbSecondname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 360);
            this.panel1.TabIndex = 32;
            // 
            // lklblRemoveImage
            // 
            this.lklblRemoveImage.AutoSize = true;
            this.lklblRemoveImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblRemoveImage.Location = new System.Drawing.Point(720, 320);
            this.lklblRemoveImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklblRemoveImage.Name = "lklblRemoveImage";
            this.lklblRemoveImage.Size = new System.Drawing.Size(120, 21);
            this.lklblRemoveImage.TabIndex = 36;
            this.lklblRemoveImage.TabStop = true;
            this.lklblRemoveImage.Text = "Remove Image";
            this.lklblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblRemoveImage_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Gendor:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(202, 154);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 25);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbGender_CheckedChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(487, 103);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(183, 29);
            this.dtpDateOfBirth.TabIndex = 6;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(116, 154);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 25);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbGender_CheckedChanged);
            // 
            // txtbAddress
            // 
            this.txtbAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAddress.Location = new System.Drawing.Point(116, 245);
            this.txtbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbAddress.Multiline = true;
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(559, 96);
            this.txtbAddress.TabIndex = 12;
            this.txtbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtbXInput_Validating);
            // 
            // cbxNationality
            // 
            this.cbxNationality.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNationality.FormattingEnabled = true;
            this.cbxNationality.Location = new System.Drawing.Point(487, 201);
            this.cbxNationality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.Size = new System.Drawing.Size(183, 29);
            this.cbxNationality.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(175, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "National ID:";
            // 
            // lklblSetImage
            // 
            this.lklblSetImage.AutoSize = true;
            this.lklblSetImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblSetImage.Location = new System.Drawing.Point(738, 289);
            this.lklblSetImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklblSetImage.Name = "lklblSetImage";
            this.lklblSetImage.Size = new System.Drawing.Size(84, 21);
            this.lklblSetImage.TabIndex = 13;
            this.lklblSetImage.TabStop = true;
            this.lklblSetImage.Text = "Set Image";
            this.lklblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblSetImage_LinkClicked);
            // 
            // txtbLastname
            // 
            this.txtbLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLastname.Location = new System.Drawing.Point(689, 52);
            this.txtbLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbLastname.Multiline = true;
            this.txtbLastname.Name = "txtbLastname";
            this.txtbLastname.Size = new System.Drawing.Size(183, 31);
            this.txtbLastname.TabIndex = 4;
            this.txtbLastname.Validating += new System.ComponentModel.CancelEventHandler(this.txtbXInput_Validating);
            // 
            // txtbFirstname
            // 
            this.txtbFirstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFirstname.Location = new System.Drawing.Point(116, 52);
            this.txtbFirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbFirstname.Multiline = true;
            this.txtbFirstname.Name = "txtbFirstname";
            this.txtbFirstname.Size = new System.Drawing.Size(183, 31);
            this.txtbFirstname.TabIndex = 1;
            this.txtbFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.txtbXInput_Validating);
            // 
            // txtbPhone
            // 
            this.txtbPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPhone.Location = new System.Drawing.Point(487, 151);
            this.txtbPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbPhone.Multiline = true;
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(183, 31);
            this.txtbPhone.TabIndex = 7;
            this.txtbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtbXInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Third Name\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(359, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Second Name";
            // 
            // txtbNationalID
            // 
            this.txtbNationalID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNationalID.Location = new System.Drawing.Point(116, 103);
            this.txtbNationalID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbNationalID.Multiline = true;
            this.txtbNationalID.Name = "txtbNationalID";
            this.txtbNationalID.Size = new System.Drawing.Size(183, 31);
            this.txtbNationalID.TabIndex = 5;
            this.txtbNationalID.Validating += new System.ComponentModel.CancelEventHandler(this.txtbNationalID_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nationality:";
            // 
            // pbPersonalPhoto
            // 
            this.pbPersonalPhoto.Image = global::Driving_License_Management.Properties.Resources.boy;
            this.pbPersonalPhoto.Location = new System.Drawing.Point(693, 103);
            this.pbPersonalPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonalPhoto.Name = "pbPersonalPhoto";
            this.pbPersonalPhoto.Size = new System.Drawing.Size(178, 168);
            this.pbPersonalPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonalPhoto.TabIndex = 28;
            this.pbPersonalPhoto.TabStop = false;
            // 
            // txtbThirdname
            // 
            this.txtbThirdname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbThirdname.Location = new System.Drawing.Point(498, 52);
            this.txtbThirdname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbThirdname.Multiline = true;
            this.txtbThirdname.Name = "txtbThirdname";
            this.txtbThirdname.Size = new System.Drawing.Size(183, 31);
            this.txtbThirdname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(749, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 245);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Address:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.Location = new System.Drawing.Point(116, 199);
            this.txtbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbEmail.Multiline = true;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(183, 31);
            this.txtbEmail.TabIndex = 11;
            this.txtbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtbEmail_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 204);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "Email:";
            // 
            // txtbSecondname
            // 
            this.txtbSecondname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSecondname.Location = new System.Drawing.Point(307, 52);
            this.txtbSecondname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbSecondname.Multiline = true;
            this.txtbSecondname.Name = "txtbSecondname";
            this.txtbSecondname.Size = new System.Drawing.Size(183, 31);
            this.txtbSecondname.TabIndex = 2;
            this.txtbSecondname.Validating += new System.ComponentModel.CancelEventHandler(this.txtbXInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth:\r\n";
            // 
            // erpCheckMandatorytxtbX
            // 
            this.erpCheckMandatorytxtbX.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(587, 505);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 37);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(723, 505);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 37);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddOrEditPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(920, 566);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddOrEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "?????";
            this.Load += new System.EventHandler(this.frmAddOrEditPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCheckMandatorytxtbX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.ComboBox cbxNationality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lklblSetImage;
        private System.Windows.Forms.TextBox txtbLastname;
        private System.Windows.Forms.TextBox txtbFirstname;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbNationalID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbPersonalPhoto;
        private System.Windows.Forms.TextBox txtbThirdname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbSecondname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ErrorProvider erpCheckMandatorytxtbX;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lklblRemoveImage;
    }
}