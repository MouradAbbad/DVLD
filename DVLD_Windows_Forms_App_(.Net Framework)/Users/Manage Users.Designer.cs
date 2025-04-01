namespace Driving_License_Management
{
    partial class frmManageUser
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
            this.cbxFilterBy = new System.Windows.Forms.ComboBox();
            this.txtValueForFiltring = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfRecord = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this.cmsManageUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetail_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNew_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delet_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword_toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmail_toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCall_toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIsActivValues = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.cmsManageUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFilterBy
            // 
            this.cbxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterBy.FormattingEnabled = true;
            this.cbxFilterBy.Items.AddRange(new object[] {
            "NON",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbxFilterBy.Location = new System.Drawing.Point(106, 152);
            this.cbxFilterBy.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbxFilterBy.Name = "cbxFilterBy";
            this.cbxFilterBy.Size = new System.Drawing.Size(133, 36);
            this.cbxFilterBy.TabIndex = 17;
            this.cbxFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbxFilterBy_SelectedIndexChanged);
            // 
            // txtValueForFiltring
            // 
            this.txtValueForFiltring.Location = new System.Drawing.Point(253, 154);
            this.txtValueForFiltring.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtValueForFiltring.Name = "txtValueForFiltring";
            this.txtValueForFiltring.Size = new System.Drawing.Size(222, 34);
            this.txtValueForFiltring.TabIndex = 16;
            this.txtValueForFiltring.TextChanged += new System.EventHandler(this.txtValueForFiltring_TextChanged);
            this.txtValueForFiltring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValueForFiltring_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filter By:";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(561, 144);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(168, 44);
            this.btnAddNewUser.TabIndex = 14;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(562, 500);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 44);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "#Record:";
            // 
            // lblNumberOfRecord
            // 
            this.lblNumberOfRecord.AutoSize = true;
            this.lblNumberOfRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecord.Location = new System.Drawing.Point(113, 500);
            this.lblNumberOfRecord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfRecord.Name = "lblNumberOfRecord";
            this.lblNumberOfRecord.Size = new System.Drawing.Size(66, 28);
            this.lblNumberOfRecord.TabIndex = 11;
            this.lblNumberOfRecord.Text = "label2";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(556, -100);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(184, 29);
            this.lblTitel.TabIndex = 10;
            this.lblTitel.Text = "Manage People";
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToResizeRows = false;
            this.dgvUsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersList.ColumnHeadersHeight = 29;
            this.dgvUsersList.ContextMenuStrip = this.cmsManageUsers;
            this.dgvUsersList.Location = new System.Drawing.Point(6, 202);
            this.dgvUsersList.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvUsersList.MultiSelect = false;
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersWidth = 51;
            this.dgvUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersList.Size = new System.Drawing.Size(757, 276);
            this.dgvUsersList.TabIndex = 9;
            this.dgvUsersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDetails_Click);
            // 
            // cmsManageUsers
            // 
            this.cmsManageUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetail_toolStripMenuItem,
            this.AddNew_toolStripMenuItem,
            this.Edit_toolStripMenuItem,
            this.Delet_toolStripMenuItem,
            this.ChangePassword_toolStripMenuItem5,
            this.SendEmail_toolStripMenuItem7,
            this.PhoneCall_toolStripMenuItem6});
            this.cmsManageUsers.Name = "cmsManageUsers";
            this.cmsManageUsers.Size = new System.Drawing.Size(194, 172);
            // 
            // ShowDetail_toolStripMenuItem
            // 
            this.ShowDetail_toolStripMenuItem.Name = "ShowDetail_toolStripMenuItem";
            this.ShowDetail_toolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ShowDetail_toolStripMenuItem.Text = "Show Details";
            this.ShowDetail_toolStripMenuItem.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // AddNew_toolStripMenuItem
            // 
            this.AddNew_toolStripMenuItem.Name = "AddNew_toolStripMenuItem";
            this.AddNew_toolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.AddNew_toolStripMenuItem.Text = "Add New User";
            this.AddNew_toolStripMenuItem.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // Edit_toolStripMenuItem
            // 
            this.Edit_toolStripMenuItem.Name = "Edit_toolStripMenuItem";
            this.Edit_toolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.Edit_toolStripMenuItem.Text = "Edit ";
            this.Edit_toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemUpdateUser_Click);
            // 
            // Delet_toolStripMenuItem
            // 
            this.Delet_toolStripMenuItem.Name = "Delet_toolStripMenuItem";
            this.Delet_toolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.Delet_toolStripMenuItem.Text = "Delete";
            this.Delet_toolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemDeleteUser_Click);
            // 
            // ChangePassword_toolStripMenuItem5
            // 
            this.ChangePassword_toolStripMenuItem5.Name = "ChangePassword_toolStripMenuItem5";
            this.ChangePassword_toolStripMenuItem5.Size = new System.Drawing.Size(193, 24);
            this.ChangePassword_toolStripMenuItem5.Text = "Change Password";
            this.ChangePassword_toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItemChangePassword_Click);
            // 
            // SendEmail_toolStripMenuItem7
            // 
            this.SendEmail_toolStripMenuItem7.Name = "SendEmail_toolStripMenuItem7";
            this.SendEmail_toolStripMenuItem7.Size = new System.Drawing.Size(193, 24);
            this.SendEmail_toolStripMenuItem7.Text = "Send Email";
            // 
            // PhoneCall_toolStripMenuItem6
            // 
            this.PhoneCall_toolStripMenuItem6.Name = "PhoneCall_toolStripMenuItem6";
            this.PhoneCall_toolStripMenuItem6.Size = new System.Drawing.Size(193, 24);
            this.PhoneCall_toolStripMenuItem6.Text = "Phone Call";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 56);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage  Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbIsActivValues
            // 
            this.cmbIsActivValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsActivValues.FormattingEnabled = true;
            this.cmbIsActivValues.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbIsActivValues.Location = new System.Drawing.Point(253, 152);
            this.cmbIsActivValues.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbIsActivValues.Name = "cmbIsActivValues";
            this.cmbIsActivValues.Size = new System.Drawing.Size(133, 36);
            this.cmbIsActivValues.TabIndex = 19;
            this.cmbIsActivValues.SelectedIndexChanged += new System.EventHandler(this.cmbIsActivValues_SelectedIndexChanged);
            // 
            // frmManageUser
            // 
            this.AcceptButton = this.btnAddNewUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(773, 564);
            this.Controls.Add(this.cmbIsActivValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFilterBy);
            this.Controls.Add(this.txtValueForFiltring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfRecord);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.dgvUsersList);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.cmsManageUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFilterBy;
        private System.Windows.Forms.TextBox txtValueForFiltring;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfRecord;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgvUsersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIsActivValues;
        private System.Windows.Forms.ContextMenuStrip cmsManageUsers;
        private System.Windows.Forms.ToolStripMenuItem ShowDetail_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNew_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delet_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword_toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem SendEmail_toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem PhoneCall_toolStripMenuItem6;
    }
}