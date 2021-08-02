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
    public partial class frm_Programme : DevExpress.XtraEditors.XtraForm
    {
        public frm_Programme()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvProgramme.Rows.Clear();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM programme";
            dt = DataAccessLayer.Retreiving(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow createRow = new DataGridViewRow();
                    createRow.CreateCells(dgvProgramme);
                    createRow.Cells[0].Value = row[0].ToString();
                    createRow.Cells[1].Value = row[1].ToString();
                    createRow.Cells[2].Value = row[2].ToString();

                    dgvProgramme.Rows.Add(createRow);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtProgrammeName.Text.Trim() == "")
            {
                DataAccessLayer.ControlValidation(txtProgrammeName, "Please Enter Programme name...", ep);
                return;
            }

            string sql = string.Format(@"INSERT INTO programme (prog_Name, description) VALUES ('{0}','{1}')", txtProgrammeName.Text.Trim(), txtDescription.Text.Trim());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Seuccessfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDescription.Clear();
            txtProgrammeName.Clear();
            FillGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtProgrammeName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProgramme.Rows.Count > 0)
            {
                if (dgvProgramme.SelectedRows.Count == 1)
                {
                    if (XtraMessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataAccessLayer.Execute(string.Format(@"DELETE FROM programme WHERE prog_Id = '{0}'", dgvProgramme.CurrentRow.Cells[0].Value.ToString()));

                        XtraMessageBox.Show("Deleted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        FillGrid();
                    }
                }
            }
        }

        private void EnableComponent()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvProgramme.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            dgvProgramme.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProgramme.Rows.Count > 0)
            {
                if (dgvProgramme.SelectedRows.Count == 1)
                {
                    EnableComponent();
                    txtProgrammeName.Text = dgvProgramme.CurrentRow.Cells[1].Value.ToString();
                    txtDescription.Text = dgvProgramme.CurrentRow.Cells[2].Value.ToString();
                }
            }
            else
            {
                XtraMessageBox.Show("List is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtProgrammeName.Text.Trim() == "")
            {
                DataAccessLayer.ControlValidation(txtProgrammeName, "Please Enter Programme name...", ep);
                return;
            }

            string sql = string.Format(@"UPDATE programme SET prog_Name = '{0}', description = '{1}' WHERE prog_Id = '{2}'", txtProgrammeName.Text.Trim(), txtDescription.Text.Trim(), dgvProgramme.CurrentRow.Cells[0].Value.ToString());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Seuccessfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDescription.Clear();
            txtProgrammeName.Clear();
            DisableComponent();
            FillGrid();
        }
    }
}