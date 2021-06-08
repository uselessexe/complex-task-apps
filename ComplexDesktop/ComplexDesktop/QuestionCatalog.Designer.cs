namespace ComplexDesktop
{
    partial class QuestionCatalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxThemes = new System.Windows.Forms.ComboBox();
            this.buttonAddQues = new System.Windows.Forms.Button();
            this.labelQuestionCatalog = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEditQuestion = new System.Windows.Forms.Button();
            this.buttonSelectTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTheme.Location = new System.Drawing.Point(302, 74);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(162, 28);
            this.labelTheme.TabIndex = 2;
            this.labelTheme.Text = "Выберите тему:";
            // 
            // comboBoxThemes
            // 
            this.comboBoxThemes.BackColor = System.Drawing.Color.White;
            this.comboBoxThemes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxThemes.FormattingEnabled = true;
            this.comboBoxThemes.Location = new System.Drawing.Point(470, 76);
            this.comboBoxThemes.Name = "comboBoxThemes";
            this.comboBoxThemes.Size = new System.Drawing.Size(701, 31);
            this.comboBoxThemes.TabIndex = 3;
            // 
            // buttonAddQues
            // 
            this.buttonAddQues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddQues.AutoSize = true;
            this.buttonAddQues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQues.Location = new System.Drawing.Point(1199, 236);
            this.buttonAddQues.Name = "buttonAddQues";
            this.buttonAddQues.Size = new System.Drawing.Size(237, 53);
            this.buttonAddQues.TabIndex = 5;
            this.buttonAddQues.Text = "Добавить вопрос";
            this.buttonAddQues.UseVisualStyleBackColor = true;
            this.buttonAddQues.Click += new System.EventHandler(this.buttonAddQues_Click);
            // 
            // labelQuestionCatalog
            // 
            this.labelQuestionCatalog.AutoSize = true;
            this.labelQuestionCatalog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionCatalog.Location = new System.Drawing.Point(288, 193);
            this.labelQuestionCatalog.Name = "labelQuestionCatalog";
            this.labelQuestionCatalog.Size = new System.Drawing.Size(186, 28);
            this.labelQuestionCatalog.TabIndex = 6;
            this.labelQuestionCatalog.Text = "Каталог вопросов:";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(257, 236);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersWidth = 51;
            this.dgvQuestions.RowTemplate.Height = 24;
            this.dgvQuestions.Size = new System.Drawing.Size(914, 468);
            this.dgvQuestions.TabIndex = 7;
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
            this.questionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.questionToolStripMenuItem.Text = "Вопросы";
            // 
            // studentsAnswersToolStripMenuItem
            // 
            this.studentsAnswersToolStripMenuItem.Name = "studentsAnswersToolStripMenuItem";
            this.studentsAnswersToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.studentsAnswersToolStripMenuItem.Text = "Ответы студента";
            this.studentsAnswersToolStripMenuItem.Click += new System.EventHandler(this.studentsAnswersToolStripMenuItem_Click);
            // 
            // buttonEditQuestion
            // 
            this.buttonEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditQuestion.AutoSize = true;
            this.buttonEditQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditQuestion.Location = new System.Drawing.Point(1199, 312);
            this.buttonEditQuestion.Name = "buttonEditQuestion";
            this.buttonEditQuestion.Size = new System.Drawing.Size(237, 53);
            this.buttonEditQuestion.TabIndex = 9;
            this.buttonEditQuestion.Text = "Редактировать вопрос";
            this.buttonEditQuestion.UseVisualStyleBackColor = true;
            this.buttonEditQuestion.Click += new System.EventHandler(this.buttonEditQuestion_Click);
            // 
            // buttonSelectTheme
            // 
            this.buttonSelectTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectTheme.AutoSize = true;
            this.buttonSelectTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectTheme.Location = new System.Drawing.Point(1199, 62);
            this.buttonSelectTheme.Name = "buttonSelectTheme";
            this.buttonSelectTheme.Size = new System.Drawing.Size(237, 53);
            this.buttonSelectTheme.TabIndex = 10;
            this.buttonSelectTheme.Text = "Выбрать тему";
            this.buttonSelectTheme.UseVisualStyleBackColor = true;
            this.buttonSelectTheme.Click += new System.EventHandler(this.buttonSelectTheme_Click);
            // 
            // QuestionCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.buttonSelectTheme);
            this.Controls.Add(this.buttonEditQuestion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.labelQuestionCatalog);
            this.Controls.Add(this.buttonAddQues);
            this.Controls.Add(this.comboBoxThemes);
            this.Controls.Add(this.labelTheme);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "QuestionCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.ComboBox comboBoxThemes;
        private System.Windows.Forms.Button buttonAddQues;
        private System.Windows.Forms.Label labelQuestionCatalog;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsAnswersToolStripMenuItem;
        private System.Windows.Forms.Button buttonEditQuestion;
        private System.Windows.Forms.Button buttonSelectTheme;
    }
}

