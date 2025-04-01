namespace Driving_License_Management
{
    partial class frmDrivers
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dtgdDrivesTable = new System.Windows.Forms.DataGridView();
            this.cmbxFiltterby = new System.Windows.Forms.ComboBox();
            this.txtbxValueOfFiltring = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdDrivesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(609, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Drivers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtter by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "#Records:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(87, 425);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(32, 17);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "????";
            // 
            // dtgdDrivesTable
            // 
            this.dtgdDrivesTable.AllowUserToAddRows = false;
            this.dtgdDrivesTable.AllowUserToDeleteRows = false;
            this.dtgdDrivesTable.AllowUserToResizeColumns = false;
            this.dtgdDrivesTable.AllowUserToResizeRows = false;
            this.dtgdDrivesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdDrivesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdDrivesTable.Location = new System.Drawing.Point(10, 122);
            this.dtgdDrivesTable.MultiSelect = false;
            this.dtgdDrivesTable.Name = "dtgdDrivesTable";
            this.dtgdDrivesTable.ReadOnly = true;
            this.dtgdDrivesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgdDrivesTable.Size = new System.Drawing.Size(729, 294);
            this.dtgdDrivesTable.TabIndex = 5;
            // 
            // cmbxFiltterby
            // 
            this.cmbxFiltterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFiltterby.FormattingEnabled = true;
            this.cmbxFiltterby.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person",
            "National ID",
            "Full Name",
            "Issuance Date",
            "is Active"});
            this.cmbxFiltterby.Location = new System.Drawing.Point(84, 87);
            this.cmbxFiltterby.Name = "cmbxFiltterby";
            this.cmbxFiltterby.Size = new System.Drawing.Size(121, 25);
            this.cmbxFiltterby.TabIndex = 6;
            this.cmbxFiltterby.SelectedIndexChanged += new System.EventHandler(this.cmbxFiltterby_SelectedIndexChanged);
            // 
            // txtbxValueOfFiltring
            // 
            this.txtbxValueOfFiltring.Location = new System.Drawing.Point(211, 87);
            this.txtbxValueOfFiltring.Name = "txtbxValueOfFiltring";
            this.txtbxValueOfFiltring.Size = new System.Drawing.Size(121, 25);
            this.txtbxValueOfFiltring.TabIndex = 7;
            this.txtbxValueOfFiltring.TextChanged += new System.EventHandler(this.txtbxValueOfFiltring_TextChanged);
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 469);
            this.Controls.Add(this.txtbxValueOfFiltring);
            this.Controls.Add(this.cmbxFiltterby);
            this.Controls.Add(this.dtgdDrivesTable);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDrivers";
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdDrivesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dtgdDrivesTable;
        private System.Windows.Forms.ComboBox cmbxFiltterby;
        private System.Windows.Forms.TextBox txtbxValueOfFiltring;
    }
}