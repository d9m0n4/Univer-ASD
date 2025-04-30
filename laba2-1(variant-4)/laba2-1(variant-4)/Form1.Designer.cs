namespace laba2_1_variant_4_
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
            this.textX = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textR1 = new System.Windows.Forms.TextBox();
            this.textR2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(146, 131);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 31);
            this.textX.TabIndex = 0;
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(146, 231);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(100, 31);
            this.textY.TabIndex = 1;
            // 
            // textR1
            // 
            this.textR1.Location = new System.Drawing.Point(146, 320);
            this.textR1.Name = "textR1";
            this.textR1.Size = new System.Drawing.Size(100, 31);
            this.textR1.TabIndex = 2;
            // 
            // textR2
            // 
            this.textR2.Location = new System.Drawing.Point(146, 403);
            this.textR2.Name = "textR2";
            this.textR2.Size = new System.Drawing.Size(100, 31);
            this.textR2.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(146, 500);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(168, 58);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(541, 134);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(24, 25);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "д";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "R1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "R2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 731);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.textR2);
            this.Controls.Add(this.textR1);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.textX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textR1;
        private System.Windows.Forms.TextBox textR2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

