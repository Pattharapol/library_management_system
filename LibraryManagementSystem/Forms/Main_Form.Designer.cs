
namespace LibraryManagementSystem.Forms
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSession = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.designationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customBooksReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.issueBookReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksFineReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.staffReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.listOfDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.allStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentCustomReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1453, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.userToolStripMenuItem,
            this.tsmSession,
            this.tsmProgramme,
            this.designationsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // tsmSession
            // 
            this.tsmSession.Name = "tsmSession";
            this.tsmSession.Size = new System.Drawing.Size(142, 22);
            this.tsmSession.Text = "Session";
            this.tsmSession.Click += new System.EventHandler(this.tsmSession_Click);
            // 
            // tsmProgramme
            // 
            this.tsmProgramme.Name = "tsmProgramme";
            this.tsmProgramme.Size = new System.Drawing.Size(142, 22);
            this.tsmProgramme.Text = "Programme";
            this.tsmProgramme.Click += new System.EventHandler(this.tsmProgramme_Click);
            // 
            // designationsToolStripMenuItem
            // 
            this.designationsToolStripMenuItem.Name = "designationsToolStripMenuItem";
            this.designationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.designationsToolStripMenuItem.Text = "Designations";
            this.designationsToolStripMenuItem.Click += new System.EventHandler(this.designationsToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddStaff});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // tsmAddStaff
            // 
            this.tsmAddStaff.Name = "tsmAddStaff";
            this.tsmAddStaff.Size = new System.Drawing.Size(180, 22);
            this.tsmAddStaff.Text = "Add Staff";
            this.tsmAddStaff.Click += new System.EventHandler(this.tsmAddStaff_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.issueBooksToolStripMenuItem.Text = "Issue Books";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBooksToolStripMenuItem,
            this.customBooksReportsToolStripMenuItem,
            this.toolStripSeparator1,
            this.issueBookReportToolStripMenuItem,
            this.returnBooksReportToolStripMenuItem,
            this.booksFineReportToolStripMenuItem,
            this.toolStripSeparator2,
            this.staffReportToolStripMenuItem,
            this.toolStripSeparator3,
            this.listOfDepartmentToolStripMenuItem,
            this.listOfSessionToolStripMenuItem,
            this.toolStripSeparator4,
            this.allStudentsToolStripMenuItem,
            this.studentCustomReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // allBooksToolStripMenuItem
            // 
            this.allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            this.allBooksToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.allBooksToolStripMenuItem.Text = "All Books";
            // 
            // customBooksReportsToolStripMenuItem
            // 
            this.customBooksReportsToolStripMenuItem.Name = "customBooksReportsToolStripMenuItem";
            this.customBooksReportsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.customBooksReportsToolStripMenuItem.Text = "Custom Books Reports";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // issueBookReportToolStripMenuItem
            // 
            this.issueBookReportToolStripMenuItem.Name = "issueBookReportToolStripMenuItem";
            this.issueBookReportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.issueBookReportToolStripMenuItem.Text = "Issue Book Report";
            // 
            // returnBooksReportToolStripMenuItem
            // 
            this.returnBooksReportToolStripMenuItem.Name = "returnBooksReportToolStripMenuItem";
            this.returnBooksReportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.returnBooksReportToolStripMenuItem.Text = "Return Books Report";
            // 
            // booksFineReportToolStripMenuItem
            // 
            this.booksFineReportToolStripMenuItem.Name = "booksFineReportToolStripMenuItem";
            this.booksFineReportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.booksFineReportToolStripMenuItem.Text = "Books Fine Report";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // staffReportToolStripMenuItem
            // 
            this.staffReportToolStripMenuItem.Name = "staffReportToolStripMenuItem";
            this.staffReportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.staffReportToolStripMenuItem.Text = "Staff Report";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // listOfDepartmentToolStripMenuItem
            // 
            this.listOfDepartmentToolStripMenuItem.Name = "listOfDepartmentToolStripMenuItem";
            this.listOfDepartmentToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listOfDepartmentToolStripMenuItem.Text = "List of Department";
            // 
            // listOfSessionToolStripMenuItem
            // 
            this.listOfSessionToolStripMenuItem.Name = "listOfSessionToolStripMenuItem";
            this.listOfSessionToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listOfSessionToolStripMenuItem.Text = "List of Session";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // allStudentsToolStripMenuItem
            // 
            this.allStudentsToolStripMenuItem.Name = "allStudentsToolStripMenuItem";
            this.allStudentsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.allStudentsToolStripMenuItem.Text = "All Students";
            // 
            // studentCustomReportToolStripMenuItem
            // 
            this.studentCustomReportToolStripMenuItem.Name = "studentCustomReportToolStripMenuItem";
            this.studentCustomReportToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.studentCustomReportToolStripMenuItem.Text = "Student Custom Report";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1453, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1453, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "   Ready...";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSession;
        private System.Windows.Forms.ToolStripMenuItem tsmProgramme;
        private System.Windows.Forms.ToolStripMenuItem designationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddStaff;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customBooksReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem issueBookReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksFineReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem staffReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem listOfDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem allStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentCustomReportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}