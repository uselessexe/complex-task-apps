namespace ComplexDesktop
{
    partial class TeacherPersonalPage
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
            this.menuStripTeachPage = new System.Windows.Forms.MenuStrip();
            this.TSMI_TeacherPersonalPage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Themes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Questions = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_StudentAnswers = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.menuStripTeachPage.SuspendLayout();
            this.groupBoxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTeachPage
            // 
            this.menuStripTeachPage.BackColor = System.Drawing.Color.OldLace;
            this.menuStripTeachPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripTeachPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.menuStripTeachPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTeachPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TeacherPersonalPage,
            this.TSMI_Themes,
            this.TSMI_Questions,
            this.TSMI_StudentAnswers});
            this.menuStripTeachPage.Location = new System.Drawing.Point(0, 0);
            this.menuStripTeachPage.Name = "menuStripTeachPage";
            this.menuStripTeachPage.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripTeachPage.Size = new System.Drawing.Size(189, 827);
            this.menuStripTeachPage.TabIndex = 8;
            this.menuStripTeachPage.Text = "menuStrip1";
            // 
            // TSMI_TeacherPersonalPage
            // 
            this.TSMI_TeacherPersonalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.TSMI_TeacherPersonalPage.Name = "TSMI_TeacherPersonalPage";
            this.TSMI_TeacherPersonalPage.Size = new System.Drawing.Size(188, 32);
            this.TSMI_TeacherPersonalPage.Text = "Личная страница";
            // 
            // TSMI_Themes
            // 
            this.TSMI_Themes.Name = "TSMI_Themes";
            this.TSMI_Themes.Size = new System.Drawing.Size(188, 32);
            this.TSMI_Themes.Text = "Темы";
            this.TSMI_Themes.Click += new System.EventHandler(this.TSMI_Themes_Click);
            // 
            // TSMI_Questions
            // 
            this.TSMI_Questions.Name = "TSMI_Questions";
            this.TSMI_Questions.Size = new System.Drawing.Size(188, 32);
            this.TSMI_Questions.Text = "Вопросы";
            this.TSMI_Questions.Click += new System.EventHandler(this.TSMI_Questions_Click);
            // 
            // TSMI_StudentAnswers
            // 
            this.TSMI_StudentAnswers.Name = "TSMI_StudentAnswers";
            this.TSMI_StudentAnswers.Size = new System.Drawing.Size(188, 32);
            this.TSMI_StudentAnswers.Text = "Ответы студента";
            this.TSMI_StudentAnswers.Click += new System.EventHandler(this.TSMI_StudentAnswers_Click);
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBoxUserInfo.Controls.Add(this.labelEmail);
            this.groupBoxUserInfo.Controls.Add(this.labelFIO);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(441, 209);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(786, 195);
            this.groupBoxUserInfo.TabIndex = 10;
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
            this.buttonUserEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserEdit.Location = new System.Drawing.Point(973, 433);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(254, 53);
            this.buttonUserEdit.TabIndex = 17;
            this.buttonUserEdit.Text = "Редактировать данные";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
            // 
            // TeacherPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.buttonUserEdit);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.menuStripTeachPage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TeacherPersonalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Личная страница учителя";
            this.Load += new System.EventHandler(this.TeacherPersonalPage_Load);
            this.menuStripTeachPage.ResumeLayout(false);
            this.menuStripTeachPage.PerformLayout();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTeachPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TeacherPersonalPage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Themes;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Questions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_StudentAnswers;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button buttonUserEdit;
    }
}