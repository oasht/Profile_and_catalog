namespace User_profile__catalog
{
    partial class Form1
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
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.SystemColors.Control;
            this.bt_1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_1.Location = new System.Drawing.Point(54, 25);
            this.bt_1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(128, 53);
            this.bt_1.TabIndex = 0;
            this.bt_1.TabStop = false;
            this.bt_1.Text = "Анкета";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.SystemColors.Control;
            this.bt_2.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_2.Location = new System.Drawing.Point(54, 113);
            this.bt_2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(128, 53);
            this.bt_2.TabIndex = 1;
            this.bt_2.TabStop = false;
            this.bt_2.Text = "Каталог";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.SystemColors.Control;
            this.bt_3.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_3.Location = new System.Drawing.Point(54, 202);
            this.bt_3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(128, 53);
            this.bt_3.TabIndex = 2;
            this.bt_3.TabStop = false;
            this.bt_3.Text = "Выход";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(240, 314);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
    }
}

