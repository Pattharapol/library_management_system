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
    public partial class frm_Department : DevExpress.XtraEditors.XtraForm
    {
        public frm_Department()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvDepartment.Rows.Clear();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM department";
            dt = DataAccessLayer.Retreiving(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    Row.CreateCells(dgvDepartment);
                    Row.Cells[0].Value = row[0].ToString();
                    Row.Cells[1].Value = row[1].ToString();

                    string establishDate = Convert.ToString(Convert.ToInt32(Convert.ToDateTime(row[2]).ToString("yyyy-MM-dd").Substring(0, 4)) - 543) + Convert.ToDateTime(row[2]).ToString("yyyy-MM-dd").Substring(4);

                    Row.Cells[2].Value = establishDate;
                    Row.Cells[3].Value = row[3].ToString();

                    dgvDepartment.Rows.Add(Row);
                }
            }
            else
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtDepartment.Text.Trim() == "")
            {
                DataAccessLayer.ControlValidation(txtDepartment, "Please Enter Department name...", ep);
                return;
            }

            string sql = string.Format(@"INSERT INTO department (dept_Name, establish_Date, description) VALUES ('{0}','{1}','{2}')", txtDepartment.Text.Trim(), Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd"), txtDescription.Text.Trim());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Seuccessfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDescription.Clear();
            txtDepartment.Clear();
            dateTimePicker1.Value = DateTime.Now;
            FillGrid();
        }

        private void ClearForm()
        {
            txtDepartment.Clear();
            txtDescription.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.Rows.Count > 0)
            {
                if (dgvDepartment.SelectedRows.Count == 1)
                {
                    if (XtraMessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataAccessLayer.Execute(string.Format(@"DELETE FROM department WHERE dept_Id = '{0}'", dgvDepartment.CurrentRow.Cells[0].Value.ToString()));
                        XtraMessageBox.Show("Deleted Successfully...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillGrid();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Please Select one row...");
                }
            }
            else
            {
                XtraMessageBox.Show("List is Empty...");
            }
        }

        private void EnableComponent()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvDepartment.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            dgvDepartment.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.Rows.Count > 0)
            {
                if (dgvDepartment.SelectedRows.Count == 1)
                {
                    EnableComponent();
                    txtDepartment.Text = dgvDepartment.CurrentRow.Cells[1].Value.ToString();
                    txtDescription.Text = dgvDepartment.CurrentRow.Cells[3].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dgvDepartment.CurrentRow.Cells[2].Value);
                }
                else
                {
                    XtraMessageBox.Show("Please Select one row...");
                }
            }
            else
            {
                XtraMessageBox.Show("List is Empty...");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            DisableComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtDepartment.Text.Trim() == "")
            {
                DataAccessLayer.ControlValidation(txtDepartment, "Please Enter Department name...", ep);
                return;
            }

            string sql = string.Format(@"UPDATE department SET dept_Name = '{0}', establish_Date = '{1}', description = '{2}' WHERE dept_Id = '{3}'", txtDepartment.Text.Trim(), Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd"), txtDescription.Text.Trim(), dgvDepartment.CurrentRow.Cells[0].Value.ToString());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Seuccessfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            DisableComponent();
            FillGrid();
        }
    }
}