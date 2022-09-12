namespace auto
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(61, 42);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(61, 95);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(107, 173);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(58, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(58, 79);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "label2";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(126, 157);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_error.TabIndex = 5;
            this.lbl_error.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 208);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_error;
    }
}

