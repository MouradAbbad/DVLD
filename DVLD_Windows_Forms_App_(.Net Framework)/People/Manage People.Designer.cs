namespace Driving_License_Management
{
    partial class frmManagePeople
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
            this.cmsManagePerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditePersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValueForFiltring = new System.Windows.Forms.TextBox();
            this.cbxFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvPeopleList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsManagePerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsManagePerson
            // 
            this.cmsManagePerson.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManagePerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowDetails,
            this.toolStripMenuItemAddNewPerson,
            this.toolStripMenuItemEditePersonInfo,
            this.toolStripMenuItemDeletePerson,
            this.toolStripMenuItemSendEmail,
            this.toolStripMenuItemPhoneCall});
            this.cmsManagePerson.Name = "cmsManagePerson";
            this.cmsManagePerson.Size = new System.Drawing.Size(180, 148);
            // 
            // toolStripMenuItemShowDetails
            // 
            this.toolStripMenuItemShowDetails.Name = "toolStripMenuItemShowDetails";
            this.toolStripMenuItemShowDetails.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemShowDetails.Text = "Show Details";
            this.toolStripMenuItemShowDetails.Click += new System.EventHandler(this.toolStripMenuItemShowDetails_Click);
            // 
            // toolStripMenuItemAddNewPerson
            // 
            this.toolStripMenuItemAddNewPerson.Name = "toolStripMenuItemAddNewPerson";
            this.toolStripMenuItemAddNewPerson.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemAddNewPerson.Text = "Add New Perso";
            this.toolStripMenuItemAddNewPerson.Click += new System.EventHandler(this.AddNewPerson_Click);
            // 
            // toolStripMenuItemEditePersonInfo
            // 
            this.toolStripMenuItemEditePersonInfo.Name = "toolStripMenuItemEditePersonInfo";
            this.toolStripMenuItemEditePersonInfo.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemEditePersonInfo.Text = "Edite";
            this.toolStripMenuItemEditePersonInfo.Click += new System.EventHandler(this.toolStripMenuItemEditePersonInfo_Click);
            // 
            // toolStripMenuItemDeletePerson
            // 
            this.toolStripMenuItemDeletePerson.Name = "toolStripMenuItemDeletePerson";
            this.toolStripMenuItemDeletePerson.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemDeletePerson.Text = "Delete";
            this.toolStripMenuItemDeletePerson.Click += new System.EventHandler(this.toolStripMenuItemDeletePerson_Click);
            // 
            // toolStripMenuItemSendEmail
            // 
            this.toolStripMenuItemSendEmail.Name = "toolStripMenuItemSendEmail";
            this.toolStripMenuItemSendEmail.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemSendEmail.Text = "Send Email";
            // 
            // toolStripMenuItemPhoneCall
            // 
            this.toolStripMenuItemPhoneCall.Name = "toolStripMenuItemPhoneCall";
            this.toolStripMenuItemPhoneCall.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemPhoneCall.Text = "Phone Call";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(427, 45);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(184, 29);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Manage People";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Location = new System.Drawing.Point(794, 116);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(162, 37);
            this.btnAddNewPerson.TabIndex = 5;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.AddNewPerson_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By:";
            // 
            // txtValueForFiltring
            // 
            this.txtValueForFiltring.Location = new System.Drawing.Point(276, 124);
            this.txtValueForFiltring.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValueForFiltring.Name = "txtValueForFiltring";
            this.txtValueForFiltring.Size = new System.Drawing.Size(196, 34);
            this.txtValueForFiltring.TabIndex = 7;
            this.txtValueForFiltring.TextChanged += new System.EventHandler(this.txtValueForFiltring_TextChanged);
            // 
            // cbxFilterBy
            // 
            this.cbxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterBy.FormattingEnabled = true;
            this.cbxFilterBy.Items.AddRange(new object[] {
            "NON",
            "Person ID",
            "National ID",
            "First Name",
            "Last Name",
            "Gender",
            "Country Name"});
            this.cbxFilterBy.Location = new System.Drawing.Point(119, 124);
            this.cbxFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFilterBy.Name = "cbxFilterBy";
            this.cbxFilterBy.Size = new System.Drawing.Size(140, 36);
            this.cbxFilterBy.TabIndex = 8;
            this.cbxFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbxFilterBy_SelectedIndexChanged);
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.AllowUserToAddRows = false;
            this.dgvPeopleList.AllowUserToDeleteRows = false;
            this.dgvPeopleList.AllowUserToResizeColumns = false;
            this.dgvPeopleList.AllowUserToResizeRows = false;
            this.dgvPeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeopleList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleList.ContextMenuStrip = this.cmsManagePerson;
            this.dgvPeopleList.Location = new System.Drawing.Point(7, 161);
            this.dgvPeopleList.MultiSelect = false;
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.ReadOnly = true;
            this.dgvPeopleList.RowHeadersWidth = 51;
            this.dgvPeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeopleList.Size = new System.Drawing.Size(963, 254);
            this.dgvPeopleList.TabIndex = 9;
            this.dgvPeopleList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.toolStripMenuItemShowDetails_Click);
            this.dgvPeopleList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPeopleList_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "#Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(105, 433);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(38, 23);
            this.lblRecordsCount.TabIndex = 11;
            this.lblRecordsCount.Text = "????";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(794, 433);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 37);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 474);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPeopleList);
            this.Controls.Add(this.cbxFilterBy);
            this.Controls.Add(this.txtValueForFiltring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.lblTitel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            this.cmsManagePerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValueForFiltring;
        private System.Windows.Forms.ComboBox cbxFilterBy;
        private System.Windows.Forms.ContextMenuStrip cmsManagePerson;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditePersonInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeletePerson;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSendEmail;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPhoneCall;
        private System.Windows.Forms.DataGridView dgvPeopleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
    }
}