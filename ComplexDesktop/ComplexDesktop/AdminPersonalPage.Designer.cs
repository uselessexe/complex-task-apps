namespace ComplexDesktop
{
    partial class AdminPersonalPage
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
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.menuStripAdmPage.SuspendLayout();
            this.groupBoxUserInfo.SuspendLayout();
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
            this.menuStripAdmPage.TabIndex = 9;
            this.menuStripAdmPage.Text = "menuStrip1";
            // 
            // TSMI_PersonalPage
            // 
            this.TSMI_PersonalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.TSMI_PersonalPage.Name = "TSMI_PersonalPage";
            this.TSMI_PersonalPage.Size = new System.Drawing.Size(193, 32);
            this.TSMI_PersonalPage.Text = "Личная страница";
            // 
            // TSMI_TeacherList
            // 
            this.TSMI_TeacherList.Name = "TSMI_TeacherList";
            this.TSMI_TeacherList.Size = new System.Drawing.Size(193, 32);
            this.TSMI_TeacherList.Text = "Список учителей";
            this.TSMI_TeacherList.Click += new System.EventHandler(this.TSMI_TeacherList_Click);
            // 
            // TSMI_StudentList
            // 
            this.TSMI_StudentList.Name = "TSMI_StudentList";
            this.TSMI_StudentList.Size = new System.Drawing.Size(193, 32);
            this.TSMI_StudentList.Text = "Список студентов";
            this.TSMI_StudentList.Click += new System.EventHandler(this.TSMI_StudentList_Click);
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBoxUserInfo.Controls.Add(this.labelEmail);
            this.groupBoxUserInfo.Controls.Add(this.labelFIO);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(441, 209);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(786, 195);
            this.groupBoxUserInfo.TabIndex = 11;
            this.groupBoxUserInfo.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmail.Location = new System.Drawing.Point(18, 109);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(201, 28);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Электронная почта:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelFIO.Location = new System.Drawing.Point(18, 28);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(63, 28);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "ФИО:";
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.AutoSize = true;
            this.buttonUserEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserEdit.Location = new System.Drawing.Point(973, 433);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(254, 53);
            this.buttonUserEdit.TabIndex = 18;
            this.buttonUserEdit.Text = "Редактировать данные";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
            // 
            // AdminPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.buttonUserEdit);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.menuStripAdmPage);
            this.Name = "AdminPersonalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Личная страница администратора";
            this.Load += new System.EventHandler(this.AdminPersonalPage_Load);
            this.menuStripAdmPage.ResumeLayout(false);
            this.menuStripAdmPage.PerformLayout();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAdmPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonalPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TeacherList;
        private System.Windows.Forms.ToolStripMenuItem TSMI_StudentList;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button buttonUserEdit;
    }
}