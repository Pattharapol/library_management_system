using DevExpress.XtraEditors;
using LibraryManagementSystem.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms.ConfigurationForms
{
    public partial class frm_Designations : DevExpress.XtraEditors.XtraForm
    {
        public frm_Designations()
        {
            InitializeComponent();
        }

        private void FillGrid()
        {
            string sql = "SELECT * FROM designations";
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving(sql);
            if (dt.Rows.Count > 0)
            {
                dgvDesignation.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDesignation.Text.Trim().Length == 0)
            {
                DataAccessLayer.ControlValidation(txtDesignation, "Please Enter Designation...", ep);
                return;
            }

            DataAccessLayer.Execute(string.Format(@"INSERT INTO designations (designation) VALUES ('{0}')", txtDesignation.Text.Trim()));
            XtraMessageBox.Show("Successfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDesignation.Clear();
            txtDesignation.Focus();
            FillGrid();
        }

        private void frm_Designations_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}