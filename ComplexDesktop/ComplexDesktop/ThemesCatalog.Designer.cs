namespace ComplexDesktop
{
    partial class ThemesCatalog
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
            this.dgvThemesCatalog = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelThemesCatalog = new System.Windows.Forms.Label();
            this.buttonCreateTheme = new System.Windows.Forms.Button();
            this.buttonEditTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemesCatalog)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThemesCatalog
            // 
            this.dgvThemesCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemesCatalog.Location = new System.Drawing.Point(278, 126);
            this.dgvThemesCatalog.Name = "dgvThemesCatalog";
            this.dgvThemesCatalog.RowHeadersWidth = 51;
            this.dgvThemesCatalog.RowTemplate.Height = 24;
            this.dgvThemesCatalog.Size = new System.Drawing.Size(914, 533);
            this.dgvThemesCatalog.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OldLace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalPageToolStripMenuItem,
            this.themesToolStripMenuItem,
            this.questionToolStripMenuItem,
            this.studentsAnswersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(189, 827);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalPageToolStripMenuItem
            // 
            this.personalPageToolStripMenuItem.Name = "personalPageToolStripMenuItem";
            this.personalPageToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.personalPageToolStripMenuItem.Text = "Личная страница";
            this.personalPageToolStripMenuItem.Click += new System.EventHandler(this.personalPageToolStripMenuItem_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.themesToolStripMenuItem.Text = "Темы";
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.questionToolStripMenuItem.Text = "Вопросы";
            this.questionToolStripMenuItem.Click += new System.EventHandler(this.questionToolStripMenuItem_Click);
            // 
            // studentsAnswersToolStripMenuItem
            // 
            this.studentsAnswersToolStripMenuItem.Name = "studentsAnswersToolStripMenuItem";
            this.studentsAnswersToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.studentsAnswersToolStripMenuItem.Text = "Ответы студента";
            this.studentsAnswersToolStripMenuItem.Click += new System.EventHandler(this.studentsAnswersToolStripMenuItem_Click);
            // 
            // labelThemesCatalog
            // 
            this.labelThemesCatalog.AutoSize = true;
            this.labelThemesCatalog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThemesCatalog.Location = new System.Drawing.Point(273, 79);
            this.labelThemesCatalog.Name = "labelThemesCatalog";
            this.labelThemesCatalog.Size = new System.Drawing.Size(130, 28);
            this.labelThemesCatalog.TabIndex = 9;
            this.labelThemesCatalog.Text = "Каталог тем:";
            // 
            // buttonCreateTheme
            // 
            this.buttonCreateTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTheme.Location = new System.Drawing.Point(1215, 126);
            this.buttonCreateTheme.Name = "buttonCreateTheme";
            this.buttonCreateTheme.Size = new System.Drawing.Size(183, 64);
            this.buttonCreateTheme.TabIndex = 29;
            this.buttonCreateTheme.Text = "Создать запись";
            this.buttonCreateTheme.UseVisualStyleBackColor = true;
            this.buttonCreateTheme.Click += new System.EventHandler(this.buttonCreateTheme_Click);
            // 
            // buttonEditTheme
            // 
            this.buttonEditTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTheme.Location = new System.Drawing.Point(1215, 214);
            this.buttonEditTheme.Name = "buttonEditTheme";
            this.buttonEditTheme.Size = new System.Drawing.Size(183, 76);
            this.buttonEditTheme.TabIndex = 28;
            this.buttonEditTheme.Text = "Редактировать запись";
            this.buttonEditTheme.UseVisualStyleBackColor = true;
            this.buttonEditTheme.Click += new System.EventHandler(this.buttonEditTheme_Click);
            // 
            // ThemesCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.buttonCreateTheme);
            this.Controls.Add(this.buttonEditTheme);
            this.Controls.Add(this.labelThemesCatalog);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvThemesCatalog);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ThemesCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeacherInterface";
            this.Load += new System.EventHandler(this.ThemesCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemesCatalog)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThemesCatalog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsAnswersToolStripMenuItem;
        private System.Windows.Forms.Label labelThemesCatalog;
        private System.Windows.Forms.Button buttonCreateTheme;
        private System.Windows.Forms.Button buttonEditTheme;
    }
}