using DevExpress.XtraEditors;
using LibraryManagementSystem.Forms.ConfigurationForms;
using LibraryManagementSystem.Forms.StaffForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class Main_Form : DevExpress.XtraEditors.XtraForm
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void tsmSession_Click(object sender, EventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frm_Session frm = Application.OpenForms["frm_Session"] as frm_Session;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frm_Session();
                frm.Name = "frm_Session";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsmProgramme_Click(object sender, EventArgs e)
        {
            frm_Programme f = new frm_Programme();
            f.ShowDialog();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Department f = new frm_Department();
            f.ShowDialog();
        }

        private void tsmAddStaff_Click(object sender, EventArgs e)
        {
            frm_AddStaff f = new frm_AddStaff();
            f.ShowDialog();
        }
    }
}