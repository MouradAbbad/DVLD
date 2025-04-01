namespace Driving_License_Management
{
    partial class uctrlFindPerson
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
            this.components = new System.ComponentModel.Container();
            this.cbxFiltterby = new System.Windows.Forms.ComboBox();
            this.txtbValueOfFiltring = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uctrlPersonCard = new Driving_License_Management.uctrlPersonCard();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFiltterby
            // 
            this.cbxFiltterby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltterby.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltterby.FormattingEnabled = true;
            this.cbxFiltterby.Items.AddRange(new object[] {
            "National ID",
            "Person ID"});
            this.cbxFiltterby.Location = new System.Drawing.Point(75, 22);
            this.cbxFiltterby.Name = "cbxFiltterby";
            this.cbxFiltterby.Size = new System.Drawing.Size(149, 28);
            this.cbxFiltterby.TabIndex = 1;
            this.cbxFiltterby.SelectedIndexChanged += new System.EventHandler(this.cbxFiltterby_SelectedIndexChanged);
            // 
            // txtbValueOfFiltring
            // 
            this.txtbValueOfFiltring.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbValueOfFiltring.Location = new System.Drawing.Point(243, 22);
            this.txtbValueOfFiltring.Name = "txtbValueOfFiltring";
            this.txtbValueOfFiltring.Size = new System.Drawing.Size(149, 27);
            this.txtbValueOfFiltring.TabIndex = 2;
            this.txtbValueOfFiltring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbValueOfFiltring_KeyPress);
            this.txtbValueOfFiltring.Validating += new System.ComponentModel.CancelEventHandler(this.txtbValueOfFiltring_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewPerson);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxFiltterby);
            this.groupBox1.Controls.Add(this.txtbValueOfFiltring);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Location = new System.Drawing.Point(513, 22);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(111, 27);
            this.btnAddNewPerson.TabIndex = 5;
            this.btnAddNewPerson.Text = "Add Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(411, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctrlPersonCard
            // 
            this.uctrlPersonCard.Location = new System.Drawing.Point(9, 84);
            this.uctrlPersonCard.Margin = new System.Windows.Forms.Padding(4);
            this.uctrlPersonCard.Name = "uctrlPersonCard";
            this.uctrlPersonCard.Size = new System.Drawing.Size(639, 224);
            this.uctrlPersonCard.TabIndex = 4;
            // 
            // uctrlFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.uctrlPersonCard);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctrlFindPerson";
            this.Size = new System.Drawing.Size(662, 318);
            this.Load += new System.EventHandler(this.uctrlPersonFind_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxFiltterby;
        private System.Windows.Forms.TextBox txtbValueOfFiltring;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private uctrlPersonCard uctrlPersonCard;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
