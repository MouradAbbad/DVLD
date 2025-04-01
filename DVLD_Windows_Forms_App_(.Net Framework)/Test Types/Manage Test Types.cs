using DVLD_Buisnes_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_Management
{
    public partial class frmManageTestTypes : Form
    {
        //DataTable tableTestTypes;
        DataView tableTestTypes;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
           
            tableTestTypes = clsTestType.GetTestTypesList().DefaultView;
            dgvTestTypesList.DataSource = tableTestTypes;
            lblNumberOfRecords.Text = dgvTestTypesList.Rows.Count.ToString();
            if (dgvTestTypesList.Rows.Count > 0)
            {
                dgvTestTypesList.Columns[0].Width = 70;
                dgvTestTypesList.Columns[1].Width = 170;
                dgvTestTypesList.Columns[2].Width = 800;
                dgvTestTypesList.Columns[3].Width = 80;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            clsTestType.enTypeID ID= (clsTestType.enTypeID)dgvTestTypesList.CurrentRow.Cells[0].Value;
            frmEditTestType frm = new frmEditTestType(ID);
            frm.ShowDialog();
            frmManageTestTypes_Load(null, null);

        }
    }
}
