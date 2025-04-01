namespace Driving_License_Management
{
    partial class frmChangeUserPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtbConfirmePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNewPasword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uctrlUserInfo1 = new Driving_License_Management.uctrlUserInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password:";
            // 
            // txtbCurrentPassword
            // 
            this.txtbCurrentPassword.Location = new System.Drawing.Point(172, 15);
            this.txtbCurrentPassword.Name = "txtbCurrentPassword";
            this.txtbCurrentPassword.PasswordChar = '*';
            this.txtbCurrentPassword.Size = new System.Drawing.Size(205, 25);
            this.txtbCurrentPassword.TabIndex = 3;
            this.txtbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbCurrentPassword_Validating);
            // 
            // txtbConfirmePassword
            // 
            this.txtbConfirmePassword.Location = new System.Drawing.Point(172, 112);
            this.txtbConfirmePassword.Name = "txtbConfirmePassword";
            this.txtbConfirmePassword.PasswordChar = '*';
            this.txtbConfirmePassword.Size = new System.Drawing.Size(205, 25);
            this.txtbConfirmePassword.TabIndex = 5;
            this.txtbConfirmePassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbConfirmePassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirme Password:";
            // 
            // txtbNewPasword
            // 
            this.txtbNewPasword.Location = new System.Drawing.Point(172, 62);
            this.txtbNewPasword.Name = "txtbNewPasword";
            this.txtbNewPasword.PasswordChar = '*';
            this.txtbNewPasword.Size = new System.Drawing.Size(205, 25);
            this.txtbNewPasword.TabIndex = 7;
            this.txtbNewPasword.Validating += new System.ComponentModel.CancelEventHandler(this.txtbNewPasword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(528, 99);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(668, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctrlUserInfo1
            // 
            this.uctrlUserInfo1.Location = new System.Drawing.Point(3, -8);
            this.uctrlUserInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlUserInfo1.Name = "uctrlUserInfo1";
            this.uctrlUserInfo1.Size = new System.Drawing.Size(886, 474);
            this.uctrlUserInfo1.TabIndex = 10;
            this.uctrlUserInfo1.UserID = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbCurrentPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtbConfirmePassword);
            this.panel1.Controls.Add(this.txtbNewPasword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 151);
            this.panel1.TabIndex = 11;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(890, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uctrlUserInfo1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangeUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCurrentPassword;
        private System.Windows.Forms.TextBox txtbConfirmePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNewPasword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private uctrlUserInfo uctrlUserInfo1;
        private System.Windows.Forms.Panel panel1;
    }
}