namespace ComplexDesktop
{
    partial class TeacherCatalog
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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.labelTeacherCatalog = new System.Windows.Forms.Label();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.buttonCreateTeacher = new System.Windows.Forms.Button();
            this.menuStripAdmPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
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
            this.menuStripAdmPage.TabIndex = 10;
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
            this.TSMI_TeacherList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.TSMI_TeacherList.Name = "TSMI_TeacherList";
            this.TSMI_TeacherList.Size = new System.Drawing.Size(193, 32);
            this.TSMI_TeacherList.Text = "Список учителей";
            // 
            // TSMI_StudentList
            // 
            this.TSMI_StudentList.Name = "TSMI_StudentList";
            this.TSMI_StudentList.Size = new System.Drawing.Size(193, 32);
            this.TSMI_StudentList.Text = "Список студентов";
            this.TSMI_StudentList.Click += new System.EventHandler(this.TSMI_StudentList_Click);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(278, 126);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.RowTemplate.Height = 24;
            this.dgvTeachers.Size = new System.Drawing.Size(914, 533);
            this.dgvTeachers.TabIndex = 12;
            // 
            // labelTeacherCatalog
            // 
            this.labelTeacherCatalog.AutoSize = true;
            this.labelTeacherCatalog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherCatalog.Location = new System.Drawing.Point(273, 79);
            this.labelTeacherCatalog.Name = "labelTeacherCatalog";
            this.labelTeacherCatalog.Size = new System.Drawing.Size(179, 28);
            this.labelTeacherCatalog.TabIndex = 11;
            this.labelTeacherCatalog.Text = "Список учителей:";
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTeacher.Location = new System.Drawing.Point(1215, 214);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(183, 76);
            this.buttonEditTeacher.TabIndex = 26;
            this.buttonEditTeacher.Text = "Редактировать запись";
            this.buttonEditTeacher.UseVisualStyleBackColor = true;
            this.buttonEditTeacher.Click += new System.EventHandler(this.buttonEditTeacher_Click);
            // 
            // buttonCreateTeacher
            // 
            this.buttonCreateTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTeacher.Location = new System.Drawing.Point(1215, 126);
            this.buttonCreateTeacher.Name = "buttonCreateTeacher";
            this.buttonCreateTeacher.Size = new System.Drawing.Size(183, 64);
            this.buttonCreateTeacher.TabIndex = 27;
            this.buttonCreateTeacher.Text = "Создать запись";
            this.buttonCreateTeacher.UseVisualStyleBackColor = true;
            this.buttonCreateTeacher.Click += new System.EventHandler(this.buttonCreateTeacher_Click);
            // 
            // TeacherCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.buttonCreateTeacher);
            this.Controls.Add(this.buttonEditTeacher);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.labelTeacherCatalog);
            this.Controls.Add(this.menuStripAdmPage);
            this.Name = "TeacherCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserCatalog";
            this.Load += new System.EventHandler(this.TeacherCatalog_Load);
            this.menuStripAdmPage.ResumeLayout(false);
            this.menuStripAdmPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdmPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonalPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TeacherList;
        private System.Windows.Forms.ToolStripMenuItem TSMI_StudentList;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label labelTeacherCatalog;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.Button buttonCreateTeacher;
    }
}