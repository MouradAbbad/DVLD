namespace Driving_License_Management
{
    partial class frmManageLocalDrivingLicenseApplecations
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
            this.btnAddNewLDLApp = new System.Windows.Forms.Button();
            this.dgvLDLApp = new System.Windows.Forms.DataGridView();
            this.cmsManageLDLApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowAppDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditApplecation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteApplecation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelApplecation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleWritenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowPersonLicensHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbxFilterBy = new System.Windows.Forms.ComboBox();
            this.txbValueForFiltring = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).BeginInit();
            this.cmsManageLDLApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // btnAddNewLDLApp
            // 
            this.btnAddNewLDLApp.Location = new System.Drawing.Point(793, 124);
            this.btnAddNewLDLApp.Name = "btnAddNewLDLApp";
            this.btnAddNewLDLApp.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewLDLApp.TabIndex = 1;
            this.btnAddNewLDLApp.Text = "Add New";
            this.btnAddNewLDLApp.UseVisualStyleBackColor = true;
            this.btnAddNewLDLApp.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
            // 
            // dgvLDLApp
            // 
            this.dgvLDLApp.AllowUserToAddRows = false;
            this.dgvLDLApp.AllowUserToDeleteRows = false;
            this.dgvLDLApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDLApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApp.ContextMenuStrip = this.cmsManageLDLApp;
            this.dgvLDLApp.Location = new System.Drawing.Point(6, 188);
            this.dgvLDLApp.MultiSelect = false;
            this.dgvLDLApp.Name = "dgvLDLApp";
            this.dgvLDLApp.ReadOnly = true;
            this.dgvLDLApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApp.Size = new System.Drawing.Size(922, 315);
            this.dgvLDLApp.TabIndex = 2;
            this.dgvLDLApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvLDLApp_MouseDown);
            // 
            // cmsManageLDLApp
            // 
            this.cmsManageLDLApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowAppDetail,
            this.tsmiEditApplecation,
            this.tsmiDeleteApplecation,
            this.tsmiCancelApplecation,
            this.tsmiScheduleTest,
            this.tsmiIssueDrivingLicenseFirstTime,
            this.tsmiShowLicense,
            this.tsmiShowPersonLicensHistory});
            this.cmsManageLDLApp.Name = "cmsManageLDLApp";
            this.cmsManageLDLApp.Size = new System.Drawing.Size(238, 202);
            // 
            // tsmiShowAppDetail
            // 
            this.tsmiShowAppDetail.Name = "tsmiShowAppDetail";
            this.tsmiShowAppDetail.Size = new System.Drawing.Size(237, 22);
            this.tsmiShowAppDetail.Text = "Show Applecation Detail";
            // 
            // tsmiEditApplecation
            // 
            this.tsmiEditApplecation.Name = "tsmiEditApplecation";
            this.tsmiEditApplecation.Size = new System.Drawing.Size(237, 22);
            this.tsmiEditApplecation.Text = "Edit Applecation";
            // 
            // tsmiDeleteApplecation
            // 
            this.tsmiDeleteApplecation.Name = "tsmiDeleteApplecation";
            this.tsmiDeleteApplecation.Size = new System.Drawing.Size(237, 22);
            this.tsmiDeleteApplecation.Text = "Delete Applecation";
            this.tsmiDeleteApplecation.Click += new System.EventHandler(this.tsmiDeleteApplecation_Click);
            // 
            // tsmiCancelApplecation
            // 
            this.tsmiCancelApplecation.Name = "tsmiCancelApplecation";
            this.tsmiCancelApplecation.Size = new System.Drawing.Size(237, 22);
            this.tsmiCancelApplecation.Text = "Cancel Applecation";
            // 
            // tsmiScheduleTest
            // 
            this.tsmiScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScheduleVisionTest,
            this.tsmiScheduleWritenTest,
            this.tsmiScheduleStreetTest});
            this.tsmiScheduleTest.Name = "tsmiScheduleTest";
            this.tsmiScheduleTest.Size = new System.Drawing.Size(237, 22);
            this.tsmiScheduleTest.Text = "Schedule Test";
            // 
            // tsmiScheduleVisionTest
            // 
            this.tsmiScheduleVisionTest.Enabled = false;
            this.tsmiScheduleVisionTest.Name = "tsmiScheduleVisionTest";
            this.tsmiScheduleVisionTest.Size = new System.Drawing.Size(183, 22);
            this.tsmiScheduleVisionTest.Text = "Schedule Vision Test";
            this.tsmiScheduleVisionTest.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmiScheduleWritenTest
            // 
            this.tsmiScheduleWritenTest.Enabled = false;
            this.tsmiScheduleWritenTest.Name = "tsmiScheduleWritenTest";
            this.tsmiScheduleWritenTest.Size = new System.Drawing.Size(183, 22);
            this.tsmiScheduleWritenTest.Text = "Schedule Writen Test";
            this.tsmiScheduleWritenTest.Click += new System.EventHandler(this.tsmiScheduleWritenTest_Click);
            // 
            // tsmiScheduleStreetTest
            // 
            this.tsmiScheduleStreetTest.Enabled = false;
            this.tsmiScheduleStreetTest.Name = "tsmiScheduleStreetTest";
            this.tsmiScheduleStreetTest.Size = new System.Drawing.Size(183, 22);
            this.tsmiScheduleStreetTest.Text = "Schedule Street Test";
            this.tsmiScheduleStreetTest.Click += new System.EventHandler(this.tsmiScheduleStreetTest_Click);
            // 
            // tsmiIssueDrivingLicenseFirstTime
            // 
            this.tsmiIssueDrivingLicenseFirstTime.Enabled = false;
            this.tsmiIssueDrivingLicenseFirstTime.Name = "tsmiIssueDrivingLicenseFirstTime";
            this.tsmiIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(237, 22);
            this.tsmiIssueDrivingLicenseFirstTime.Text = "Issue Driving License First Time";
            this.tsmiIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.tsmiIssueDrivingLicenseFirstTime_Click);
            // 
            // tsmiShowLicense
            // 
            this.tsmiShowLicense.Enabled = false;
            this.tsmiShowLicense.Name = "tsmiShowLicense";
            this.tsmiShowLicense.Size = new System.Drawing.Size(237, 22);
            this.tsmiShowLicense.Text = "Show License";
            this.tsmiShowLicense.Click += new System.EventHandler(this.tsmiShowLicense_Click);
            // 
            // tsmiShowPersonLicensHistory
            // 
            this.tsmiShowPersonLicensHistory.Name = "tsmiShowPersonLicensHistory";
            this.tsmiShowPersonLicensHistory.Size = new System.Drawing.Size(237, 22);
            this.tsmiShowPersonLicensHistory.Text = "Show Person Licens History";
            this.tsmiShowPersonLicensHistory.Click += new System.EventHandler(this.tsmiShowPersonLicensHistory_Click);
            // 
            // cmbxFilterBy
            // 
            this.cmbxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFilterBy.FormattingEnabled = true;
            this.cmbxFilterBy.Items.AddRange(new object[] {
            "Non",
            "New License Application ID",
            "National ID",
            "Full Name",
            "Application statu"});
            this.cmbxFilterBy.Location = new System.Drawing.Point(102, 122);
            this.cmbxFilterBy.Name = "cmbxFilterBy";
            this.cmbxFilterBy.Size = new System.Drawing.Size(183, 25);
            this.cmbxFilterBy.TabIndex = 3;
            this.cmbxFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbxFilterBy_SelectedIndexChanged);
            // 
            // txbValueForFiltring
            // 
            this.txbValueForFiltring.Location = new System.Drawing.Point(303, 124);
            this.txbValueForFiltring.Name = "txbValueForFiltring";
            this.txbValueForFiltring.Size = new System.Drawing.Size(100, 25);
            this.txbValueForFiltring.TabIndex = 4;
            this.txbValueForFiltring.TextChanged += new System.EventHandler(this.txbValueForFiltring_TextChanged);
            this.txbValueForFiltring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValueForFiltring_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(255, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage Local Driving License Applecations";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Location = new System.Drawing.Point(119, 532);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(43, 17);
            this.lblRecordsNumber.TabIndex = 6;
            this.lblRecordsNumber.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "# Records:";
            // 
            // frmManageLocalDrivingLicenseApplecations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbValueForFiltring);
            this.Controls.Add(this.cmbxFilterBy);
            this.Controls.Add(this.dgvLDLApp);
            this.Controls.Add(this.btnAddNewLDLApp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageLocalDrivingLicenseApplecations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applecations";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplecations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApp)).EndInit();
            this.cmsManageLDLApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewLDLApp;
        private System.Windows.Forms.DataGridView dgvLDLApp;
        private System.Windows.Forms.ComboBox cmbxFilterBy;
        private System.Windows.Forms.TextBox txbValueForFiltring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmsManageLDLApp;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAppDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplecation;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteApplecation;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelApplecation;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleWritenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleStreetTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonLicensHistory;
    }
}