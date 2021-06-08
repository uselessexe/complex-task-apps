namespace ComplexDesktop
{
    partial class ThemeRecord
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
            this.labelClarification = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonddTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClarification
            // 
            this.labelClarification.AutoSize = true;
            this.labelClarification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelClarification.Location = new System.Drawing.Point(123, 57);
            this.labelClarification.Name = "labelClarification";
            this.labelClarification.Size = new System.Drawing.Size(558, 28);
            this.labelClarification.TabIndex = 0;
            this.labelClarification.Text = "Введите ниже название темы, которую нужно добавить:";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textBoxTheme.Location = new System.Drawing.Point(128, 99);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(571, 30);
            this.textBoxTheme.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(128, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(183, 53);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonddTheme
            // 
            this.buttonddTheme.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonddTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonddTheme.Location = new System.Drawing.Point(516, 191);
            this.buttonddTheme.Name = "buttonddTheme";
            this.buttonddTheme.Size = new System.Drawing.Size(183, 53);
            this.buttonddTheme.TabIndex = 22;
            this.buttonddTheme.Text = "OK";
            this.buttonddTheme.UseVisualStyleBackColor = true;
            this.buttonddTheme.Click += new System.EventHandler(this.buttonddTheme_Click);
            // 
            // ThemeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(810, 298);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonddTheme);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.labelClarification);
            this.Name = "ThemeRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemeRecord";
            this.Load += new System.EventHandler(this.ThemeRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClarification;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonddTheme;
    }
}