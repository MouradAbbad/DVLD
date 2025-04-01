namespace Driving_License_Management.Applecations.Issue_International_Driving__Licenses
{
    partial class uctrlFindLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxLicenseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearsh = new System.Windows.Forms.Button();
            this.uctrlLicenseInfo1 = new Driving_License_Management.uctrlLicenseInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearsh);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtter";
            // 
            // txtbxLicenseID
            // 
            this.txtbxLicenseID.Location = new System.Drawing.Point(146, 24);
            this.txtbxLicenseID.Name = "txtbxLicenseID";
            this.txtbxLicenseID.Size = new System.Drawing.Size(181, 20);
            this.txtbxLicenseID.TabIndex = 3;
            this.txtbxLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxLicenseID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "License ID:";
            // 
            // btnSearsh
            // 
            this.btnSearsh.Location = new System.Drawing.Point(348, 26);
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.Size = new System.Drawing.Size(75, 23);
            this.btnSearsh.TabIndex = 4;
            this.btnSearsh.Text = "Searsh";
            this.btnSearsh.UseVisualStyleBackColor = true;
            this.btnSearsh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // uctrlLicenseInfo1
            // 
            this.uctrlLicenseInfo1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uctrlLicenseInfo1.Location = new System.Drawing.Point(8, 87);
            this.uctrlLicenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlLicenseInfo1.Name = "uctrlLicenseInfo1";
            this.uctrlLicenseInfo1.Size = new System.Drawing.Size(681, 352);
            this.uctrlLicenseInfo1.TabIndex = 7;
            // 
            // uctrlFindLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uctrlLicenseInfo1);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctrlFindLicense";
            this.Size = new System.Drawing.Size(697, 443);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxLicenseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearsh;
        private uctrlLicenseInfo uctrlLicenseInfo1;
    }
}
