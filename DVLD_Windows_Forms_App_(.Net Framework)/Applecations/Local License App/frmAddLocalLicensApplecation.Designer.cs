namespace Driving_License_Management
{
    partial class frmAddLocalLicensApplecation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.uctrlPersonFind1 = new Driving_License_Management.uctrlFindPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblApplecationDate = new System.Windows.Forms.Label();
            this.cbxLicensesClass = new System.Windows.Forms.ComboBox();
            this.lblUserCreator = new System.Windows.Forms.Label();
            this.lblApplecationFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDLApplecationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.uctrlPersonFind1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(606, 453);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // uctrlPersonFind1
            // 
            this.uctrlPersonFind1.Location = new System.Drawing.Point(21, 49);
            this.uctrlPersonFind1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonFind1.Name = "uctrlPersonFind1";
           // this.uctrlPersonFind1.PersonID = -1;
            this.uctrlPersonFind1.Size = new System.Drawing.Size(768, 397);
            this.uctrlPersonFind1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblApplecationDate);
            this.tabPage2.Controls.Add(this.cbxLicensesClass);
            this.tabPage2.Controls.Add(this.lblUserCreator);
            this.tabPage2.Controls.Add(this.lblApplecationFees);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblDLApplecationID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Applecation Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblApplecationDate
            // 
            this.lblApplecationDate.AutoSize = true;
            this.lblApplecationDate.Location = new System.Drawing.Point(146, 140);
            this.lblApplecationDate.Name = "lblApplecationDate";
            this.lblApplecationDate.Size = new System.Drawing.Size(32, 17);
            this.lblApplecationDate.TabIndex = 17;
            this.lblApplecationDate.Text = "????";
            // 
            // cbxLicensesClass
            // 
            this.cbxLicensesClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLicensesClass.FormattingEnabled = true;
            this.cbxLicensesClass.Location = new System.Drawing.Point(149, 190);
            this.cbxLicensesClass.Name = "cbxLicensesClass";
            this.cbxLicensesClass.Size = new System.Drawing.Size(465, 25);
            this.cbxLicensesClass.TabIndex = 16;
            // 
            // lblUserCreator
            // 
            this.lblUserCreator.AutoSize = true;
            this.lblUserCreator.Location = new System.Drawing.Point(146, 315);
            this.lblUserCreator.Name = "lblUserCreator";
            this.lblUserCreator.Size = new System.Drawing.Size(32, 17);
            this.lblUserCreator.TabIndex = 15;
            this.lblUserCreator.Text = "????";
            // 
            // lblApplecationFees
            // 
            this.lblApplecationFees.AutoSize = true;
            this.lblApplecationFees.Location = new System.Drawing.Point(146, 248);
            this.lblApplecationFees.Name = "lblApplecationFees";
            this.lblApplecationFees.Size = new System.Drawing.Size(32, 17);
            this.lblApplecationFees.TabIndex = 14;
            this.lblApplecationFees.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "License Class:";
            // 
            // lblDLApplecationID
            // 
            this.lblDLApplecationID.AutoSize = true;
            this.lblDLApplecationID.Location = new System.Drawing.Point(146, 86);
            this.lblDLApplecationID.Name = "lblDLApplecationID";
            this.lblDLApplecationID.Size = new System.Drawing.Size(32, 17);
            this.lblDLApplecationID.TabIndex = 12;
            this.lblDLApplecationID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Applecation Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Applecation Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "D.L Applecation ID:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(589, 634);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(705, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(217, 31);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(366, 30);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "New Local Driving License Application";
            // 
            // frmAddLocalLicensApplecation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 679);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddLocalLicensApplecation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License Application             ";
            this.Load += new System.EventHandler(this.frmAddLocalLicensApplecation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private uctrlFindPerson uctrlPersonFind1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxLicensesClass;
        private System.Windows.Forms.Label lblUserCreator;
        private System.Windows.Forms.Label lblApplecationFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDLApplecationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplecationDate;
    }
}