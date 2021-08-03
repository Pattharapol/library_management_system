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

namespace LibraryManagementSystem.Forms.StaffForms
{
    public partial class frm_AddStaff : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddStaff()
        {
            InitializeComponent();
        }

        private void RetreiveDesignations()
        {
            cmbDesignation.Items.Clear();
            cmbDesignation.Items.Add("Select Designations");
            DataTable dt = new DataTable();
            dt = DataAccessLayer.Retreiving("SELECT designation FROM designations");
            foreach (DataRow row in dt.Rows)
            {
                cmbDesignation.Items.Add(row[0].ToString());
            }
        }

        private void ClearForm()
        {
            cmbDesignation.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
            txtAddress.Clear();
            txtContactNo.Clear();
            txtFatherName.Clear();
            txtSearch.Clear();
            txtStaffName.Clear();
        }

        private void frm_AddStaff_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            RetreiveDesignations();
            cmbDesignation.SelectedIndex = 0;
            RetreiveStaffList(string.Empty);
            dgvStaffList.ClearSelection();
        }

        private void RetreiveStaffList(string searchValue)
        {
            string sql = null;
            dgvStaffList.Rows.Clear();
            if (string.IsNullOrEmpty(searchValue))
            {
                sql = string.Format(@"SELECT * FROM library_staff");
            }
            else
            {
                sql = string.Format(@"SELECT * FROM library_staff WHERE name like '%{0}%'", searchValue);
            }

            if (DataAccessLayer.Retreiving(sql).Rows.Count > 0)
            {
                foreach (DataRow row in DataAccessLayer.Retreiving(sql).Rows)
                {
                    DataGridViewRow addRow = new DataGridViewRow();
                    addRow.CreateCells(dgvStaffList);
                    addRow.Cells[0].Value = row[0].ToString();
                    addRow.Cells[1].Value = CommonCode.GetDesignationName(row[1].ToString());
                    addRow.Cells[2].Value = row[2].ToString();
                    addRow.Cells[3].Value = row[3].ToString();
                    addRow.Cells[4].Value = row[4].ToString();
                    addRow.Cells[5].Value = row[5].ToString();
                    addRow.Cells[6].Value = row[6].ToString();

                    dgvStaffList.Rows.Add(addRow);
                }
            }
        }

        private void EnableComponent()
        {
            txtSearch.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            dgvStaffList.Enabled = false;
        }

        private void DisableComponent()
        {
            txtSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            dgvStaffList.Enabled = true;
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbDesignation.SelectedIndex == 0)
            {
                ep.SetError(cmbDesignation, "Please Select Designations...");
                cmbDesignation.Focus();
                return;
            }
            if (cmbGender.SelectedIndex == 0)
            {
                ep.SetError(cmbGender, "Please Select Designations...");
                cmbGender.Focus();
                return;
            }
            if (txtStaffName.Text.Trim().Length == 0)
            {
                ep.SetError(txtStaffName, "Please Enter Staff Name...");
                txtStaffName.Focus();
                return;
            }
            if (txtFatherName.Text.Trim().Length == 0)
            {
                ep.SetError(txtFatherName, "Please Enter Father Name...");
                txtFatherName.Focus();
                return;
            }
            if (txtContactNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtContactNo, "Please Enter Contact No...");
                txtContactNo.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                ep.SetError(txtAddress, "Please Enter Address...");
                txtAddress.Focus();
                return;
            }

            string sql = string.Format(@"INSERT INTO library_staff (deg_Id, name, fathername, address, gender, contactno) VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}')", CommonCode.GetDesignationID(cmbDesignation.Text), txtStaffName.Text.Trim(), txtFatherName.Text.Trim(), txtAddress.Text.Trim(), cmbGender.Text, txtContactNo.Text.Trim());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Successfully Added Record...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RetreiveStaffList(string.Empty);
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaffList.Rows.Count > 0)
            {
                if (dgvStaffList.SelectedRows.Count == 1)
                {
                    if (XtraMessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataAccessLayer.Execute(string.Format(@"DELETE FROM library_staff WHERE staff_Id = '{0}'", dgvStaffList.CurrentRow.Cells[0].Value.ToString()));
                        XtraMessageBox.Show("Successfully Deleted Record...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RetreiveStaffList(string.Empty);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RetreiveStaffList(txtSearch.Text.Trim());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaffList.Rows.Count > 0)
            {
                if (dgvStaffList.SelectedRows.Count == 1)
                {
                    EnableComponent();
                    cmbDesignation.Text = dgvStaffList.CurrentRow.Cells[1].Value.ToString();
                    txtStaffName.Text = dgvStaffList.CurrentRow.Cells[2].Value.ToString();
                    txtFatherName.Text = dgvStaffList.CurrentRow.Cells[3].Value.ToString();
                    cmbGender.Text = dgvStaffList.CurrentRow.Cells[4].Value.ToString();
                    txtContactNo.Text = dgvStaffList.CurrentRow.Cells[5].Value.ToString();
                    txtAddress.Text = dgvStaffList.CurrentRow.Cells[6].Value.ToString();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbDesignation.SelectedIndex == 0)
            {
                ep.SetError(cmbDesignation, "Please Select Designations...");
                cmbDesignation.Focus();
                return;
            }
            if (cmbGender.SelectedIndex == 0)
            {
                ep.SetError(cmbGender, "Please Select Designations...");
                cmbGender.Focus();
                return;
            }
            if (txtStaffName.Text.Trim().Length == 0)
            {
                ep.SetError(txtStaffName, "Please Enter Staff Name...");
                txtStaffName.Focus();
                return;
            }
            if (txtFatherName.Text.Trim().Length == 0)
            {
                ep.SetError(txtFatherName, "Please Enter Father Name...");
                txtFatherName.Focus();
                return;
            }
            if (txtContactNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtContactNo, "Please Enter Contact No...");
                txtContactNo.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                ep.SetError(txtAddress, "Please Enter Address...");
                txtAddress.Focus();
                return;
            }

            string sql = string.Format(@"UPDATE library_staff SET deg_Id = '{0}', name = '{1}', fathername = '{2}', address = '{3}', gender = '{4}', contactno = '{5}' WHERE staff_Id = '{6}'", CommonCode.GetDesignationID(cmbDesignation.Text), txtStaffName.Text.Trim(), txtFatherName.Text.Trim(), txtAddress.Text.Trim(), cmbGender.Text, txtContactNo.Text.Trim(), dgvStaffList.CurrentRow.Cells[0].Value.ToString());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Recode Updated Successfully...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RetreiveStaffList(string.Empty);
            ClearForm();
        }
    }
}