namespace Driving_License_Management
{
    partial class frmAddOrEditUser
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
            this.tabContrl1 = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.uctrlPersonFind1 = new Driving_License_Management.uctrlFindPerson();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.txtbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbIsActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabContrl1.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContrl1
            // 
            this.tabContrl1.Controls.Add(this.tpPersonInfo);
            this.tabContrl1.Controls.Add(this.tpLogin);
            this.tabContrl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabContrl1.Location = new System.Drawing.Point(12, 74);
            this.tabContrl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabContrl1.Name = "tabContrl1";
            this.tabContrl1.SelectedIndex = 0;
            this.tabContrl1.Size = new System.Drawing.Size(816, 540);
            this.tabContrl1.TabIndex = 2;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.uctrlPersonFind1);
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 26);
            this.tpPersonInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tpPersonInfo.Size = new System.Drawing.Size(808, 510);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // uctrlPersonFind1
            // 
            this.uctrlPersonFind1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.uctrlPersonFind1.Location = new System.Drawing.Point(22, 32);
            this.uctrlPersonFind1.Margin = new System.Windows.Forms.Padding(5);
            this.uctrlPersonFind1.Name = "uctrlPersonFind1";
            this.uctrlPersonFind1.SelectedPerson = null;
            this.uctrlPersonFind1.Size = new System.Drawing.Size(767, 413);
            this.uctrlPersonFind1.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(636, 457);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 36);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.txtbConfirmPassword);
            this.tpLogin.Controls.Add(this.label7);
            this.tpLogin.Controls.Add(this.lblUserID);
            this.tpLogin.Controls.Add(this.txtbPassword);
            this.tpLogin.Controls.Add(this.txtbUsername);
            this.tpLogin.Controls.Add(this.label4);
            this.tpLogin.Controls.Add(this.chkbIsActive);
            this.tpLogin.Controls.Add(this.label3);
            this.tpLogin.Controls.Add(this.label2);
            this.tpLogin.Controls.Add(this.label1);
            this.tpLogin.Location = new System.Drawing.Point(4, 26);
            this.tpLogin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tpLogin.Size = new System.Drawing.Size(808, 510);
            this.tpLogin.TabIndex = 1;
            this.tpLogin.Text = "Login Info";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // txtbConfirmPassword
            // 
            this.txtbConfirmPassword.Location = new System.Drawing.Point(259, 265);
            this.txtbConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtbConfirmPassword.Name = "txtbConfirmPassword";
            this.txtbConfirmPassword.PasswordChar = '*';
            this.txtbConfirmPassword.Size = new System.Drawing.Size(180, 25);
            this.txtbConfirmPassword.TabIndex = 10;
            this.txtbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbConfirmPassword_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm Password:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(259, 94);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(32, 17);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "????";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(259, 206);
            this.txtbPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(180, 25);
            this.txtbPassword.TabIndex = 7;
            this.txtbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbPassword_Validating);
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(259, 147);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(180, 25);
            this.txtbUsername.TabIndex = 6;
            this.txtbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtbUsername_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Is Active:";
            // 
            // chkbIsActive
            // 
            this.chkbIsActive.AutoSize = true;
            this.chkbIsActive.Location = new System.Drawing.Point(259, 324);
            this.chkbIsActive.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chkbIsActive.Name = "chkbIsActive";
            this.chkbIsActive.Size = new System.Drawing.Size(46, 21);
            this.chkbIsActive.TabIndex = 3;
            this.chkbIsActive.Text = "Yes";
            this.chkbIsActive.UseVisualStyleBackColor = true;
            this.chkbIsActive.CheckedChanged += new System.EventHandler(this.chkbIsActive_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(16, 9);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(812, 65);
            this.lblTitel.TabIndex = 5;
            this.lblTitel.Text = "????";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(631, 628);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(446, 628);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmAddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(843, 679);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.tabContrl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmAddOrEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "????";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tabContrl1.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabContrl1;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtbConfirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private uctrlFindPerson uctrlPersonFind1;
    }
}