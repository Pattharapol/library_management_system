using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Code;

namespace LibraryManagementSystem.Forms.ConfigurationForms
{
    public partial class frm_Session : DevExpress.XtraEditors.XtraForm
    {
        public frm_Session()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvSessionList.Rows.Clear();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM session";
            dt = DataAccessLayer.Retreiving(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow programmeRow = new DataGridViewRow();
                    programmeRow.CreateCells(dgvSessionList);
                    programmeRow.Cells[0].Value = row[0].ToString();
                    programmeRow.Cells[1].Value = row[1].ToString();

                    string startDate = Convert.ToString(Convert.ToInt32(Convert.ToDateTime(row[2]).ToString("yyyy-MM-dd").Substring(0, 4)) - 543) + Convert.ToDateTime(row[2]).ToString("yyyy-MM-dd").Substring(4);
                    string endDate = Convert.ToString(Convert.ToInt32(Convert.ToDateTime(row[3]).ToString("yyyy-MM-dd").Substring(0, 4)) - 543) + Convert.ToDateTime(row[3]).ToString("yyyy-MM-dd").Substring(4);

                    programmeRow.Cells[2].Value = startDate;
                    programmeRow.Cells[3].Value = endDate;
                    programmeRow.Cells[4].Value = row[4].ToString();

                    dgvSessionList.Rows.Add(programmeRow);
                }
            }
            else
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSessionName.Text.Trim().Length == 0)
            {
                DataAccessLayer.ControlValidation(txtSessionName, "Please Enter Session Name...", ep);
                return;
            }
            string sql = string.Format(@"INSERT INTO session (sess_Name, start_Date, end_Date, description) VALUES ('{0}','{1}','{2}','{3}')", txtSessionName.Text.Trim(), dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpEndDate.Value.ToString("yyyy-MM-dd"), txtDescription.Text.Trim());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Programme is Added.");
            txtSessionName.Clear();
            txtSessionName.Focus();
            FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSessionList.Rows.Count > 0)
                {
                    if (dgvSessionList.SelectedRows.Count == 1)
                    {
                        if (XtraMessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DataAccessLayer.Execute(string.Format(@"DELETE FROM session WHERE sess_Id = '{0}'", dgvSessionList.CurrentRow.Cells[0].Value.ToString()));
                            XtraMessageBox.Show("Record sucessfully deleted...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void EnableComponent()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtSearch.Enabled = false;
            dgvSessionList.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            txtSearch.Enabled = true;
            dgvSessionList.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void ClearForm()
        {
            txtSessionName.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSessionList.Rows.Count > 0)
            {
                if (dgvSessionList.SelectedRows.Count == 1)
                {
                    txtSessionName.Text = dgvSessionList.CurrentRow.Cells[1].Value.ToString();
                    txtDescription.Text = dgvSessionList.CurrentRow.Cells[4].Value.ToString();
                    dtpStartDate.Value = Convert.ToDateTime(dgvSessionList.CurrentRow.Cells[2].Value.ToString());
                    dtpEndDate.Value = Convert.ToDateTime(dgvSessionList.CurrentRow.Cells[3].Value.ToString());
                    EnableComponent();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            DisableComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSessionName.Text.Trim().Length == 0)
            {
                DataAccessLayer.ControlValidation(txtSessionName, "Please Enter Session Name...", ep);
                return;
            }

            string sql = string.Format(@"UPDATE session SET sess_Name = '{0}', start_Date = '{1}', end_Date = '{2}', description = '{3}' WHERE sess_Id = '{4}'", txtSessionName.Text.Trim(), dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpEndDate.Value.ToString("yyyy-MM-dd"), txtDescription.Text.Trim(), dgvSessionList.CurrentRow.Cells[0].Value.ToString());
            DataAccessLayer.Execute(sql);
            XtraMessageBox.Show("Programme is Updated.");
            ClearForm();
            FillGrid();
            DisableComponent();
        }
    }
}