namespace ComplexDesktop
{
    partial class StudentsCatalog
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
            this.menuStripAdmPage = new System.Windows.Forms.MenuStrip();
            this.TSMI_PersonalPage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TeacherList = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_StudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.labelStudCatalog = new System.Windows.Forms.Label();
            this.buttonCreateStudent = new System.Windows.Forms.Button();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.menuStripAdmPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripAdmPage
            // 
            this.menuStripAdmPage.BackColor = System.Drawing.Color.OldLace;
            this.menuStripAdmPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripAdmPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.menuStripAdmPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdmPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_PersonalPage,
            this.TSMI_TeacherList,
            this.TSMI_StudentList});
            this.menuStripAdmPage.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmPage.Name = "menuStripAdmPage";
            this.menuStripAdmPage.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripAdmPage.Size = new System.Drawing.Size(194, 827);
            this.menuStripAdmPage.TabIndex = 11;
            this.menuStripAdmPage.Text = "menuStrip1";
            // 
            // TSMI_PersonalPage
            // 
            this.TSMI_PersonalPage.BackColor = System.Drawing.Color.OldLace;
            this.TSMI_PersonalPage.Name = "TSMI_PersonalPage";
            this.TSMI_PersonalPage.Size = new System.Drawing.Size(193, 32);
            this.TSMI_PersonalPage.Text = "Личная страница";
            this.TSMI_PersonalPage.Click += new System.EventHandler(this.TSMI_PersonalPage_Click);
            // 
            // TSMI_TeacherList
            // 
            this.TSMI_TeacherList.BackColor = System.Drawing.Color.OldLace;
            this.TSMI_TeacherList.Name = "TSMI_TeacherList";
            this.TSMI_TeacherList.Size = new System.Drawing.Size(193, 32);
            this.TSMI_TeacherList.Text = "Список учителей";
            this.TSMI_TeacherList.Click += new System.EventHandler(this.TSMI_TeacherList_Click);
            // 
            // TSMI_StudentList
            // 
            this.TSMI_StudentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.TSMI_StudentList.Name = "TSMI_StudentList";
            this.TSMI_StudentList.Size = new System.Drawing.Size(193, 32);
            this.TSMI_StudentList.Text = "Список студентов";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(278, 126);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(914, 533);
            this.dgvStudents.TabIndex = 14;
            // 
            // labelStudCatalog
            // 
            this.labelStudCatalog.AutoSize = true;
            this.labelStudCatalog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudCatalog.Location = new System.Drawing.Point(273, 79);
            this.labelStudCatalog.Name = "labelStudCatalog";
            this.labelStudCatalog.Size = new System.Drawing.Size(185, 28);
            this.labelStudCatalog.TabIndex = 13;
            this.labelStudCatalog.Text = "Список студентов:";
            // 
            // buttonCreateStudent
            // 
            this.buttonCreateStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateStudent.Location = new System.Drawing.Point(1215, 126);
            this.buttonCreateStudent.Name = "buttonCreateStudent";
            this.buttonCreateStudent.Size = new System.Drawing.Size(183, 64);
            this.buttonCreateStudent.TabIndex = 29;
            this.buttonCreateStudent.Text = "Создать запись";
            this.buttonCreateStudent.UseVisualStyleBackColor = true;
            this.buttonCreateStudent.Click += new System.EventHandler(this.buttonCreateStudent_Click);
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditStudent.Location = new System.Drawing.Point(1215, 214);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(183, 76);
            this.buttonEditStudent.TabIndex = 28;
            this.buttonEditStudent.Text = "Редактировать запись";
            this.buttonEditStudent.UseVisualStyleBackColor = true;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // StudentsCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.buttonCreateStudent);
            this.Controls.Add(this.buttonEditStudent);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.labelStudCatalog);
            this.Controls.Add(this.menuStripAdmPage);
            this.Name = "StudentsCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentsCatalog";
            this.Load += new System.EventHandler(this.StudentsCatalog_Load);
            this.menuStripAdmPage.ResumeLayout(false);
            this.menuStripAdmPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdmPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonalPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TeacherList;
        private System.Windows.Forms.ToolStripMenuItem TSMI_StudentList;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label labelStudCatalog;
        private System.Windows.Forms.Button buttonCreateStudent;
        private System.Windows.Forms.Button buttonEditStudent;
    }
}