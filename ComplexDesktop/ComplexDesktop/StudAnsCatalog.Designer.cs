namespace ComplexDesktop
{
    partial class StudAnsCatalog
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.dgvStudAns = new System.Windows.Forms.DataGridView();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonMoreDet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudAns)).BeginInit();
            this.SuspendLayout();
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
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.themesToolStripMenuItem.Text = "Темы";
            this.themesToolStripMenuItem.Click += new System.EventHandler(this.themesToolStripMenuItem_Click);
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
            this.studentsAnswersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.studentsAnswersToolStripMenuItem.Name = "studentsAnswersToolStripMenuItem";
            this.studentsAnswersToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.studentsAnswersToolStripMenuItem.Text = "Ответы студента";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.BackColor = System.Drawing.Color.White;
            this.comboBoxTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(602, 62);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(497, 31);
            this.comboBoxTheme.TabIndex = 10;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTheme.Location = new System.Drawing.Point(415, 60);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(162, 28);
            this.labelTheme.TabIndex = 9;
            this.labelTheme.Text = "Выберите тему:";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.BackColor = System.Drawing.Color.White;
            this.comboBoxGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(602, 156);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(497, 31);
            this.comboBoxGroup.TabIndex = 12;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelGroup.Location = new System.Drawing.Point(415, 154);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(181, 28);
            this.labelGroup.TabIndex = 11;
            this.labelGroup.Text = "Выберите группу:";
            // 
            // dgvStudAns
            // 
            this.dgvStudAns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudAns.Location = new System.Drawing.Point(420, 280);
            this.dgvStudAns.Name = "dgvStudAns";
            this.dgvStudAns.RowHeadersWidth = 51;
            this.dgvStudAns.RowTemplate.Height = 24;
            this.dgvStudAns.Size = new System.Drawing.Size(914, 369);
            this.dgvStudAns.TabIndex = 14;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(415, 234);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(249, 28);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "Полученные результаты:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(1151, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(183, 53);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonMoreDet
            // 
            this.buttonMoreDet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoreDet.Location = new System.Drawing.Point(1151, 678);
            this.buttonMoreDet.Name = "buttonMoreDet";
            this.buttonMoreDet.Size = new System.Drawing.Size(183, 53);
            this.buttonMoreDet.TabIndex = 16;
            this.buttonMoreDet.Text = "Подробнее...";
            this.buttonMoreDet.UseVisualStyleBackColor = true;
            this.buttonMoreDet.Click += new System.EventHandler(this.buttonMoreDet_Click);
            // 
            // StudAnsCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.buttonMoreDet);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dgvStudAns);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StudAnsCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudAnsCatalog";
            this.Load += new System.EventHandler(this.StudAnsCatalog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudAns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsAnswersToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.DataGridView dgvStudAns;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonMoreDet;
    }
}