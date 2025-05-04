namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.rbInt = new System.Windows.Forms.RadioButton();
            this.rbFloat = new System.Windows.Forms.RadioButton();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.chkDouble = new System.Windows.Forms.CheckBox();
            this.chkDecimal = new System.Windows.Forms.CheckBox();
            this.chkFloat = new System.Windows.Forms.CheckBox();
            this.chkString = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(141, 13);
            this.lblQuestion1.TabIndex = 0;
            this.lblQuestion1.Text = "1. Целочисленный тип в C#";
            // 
            // rbInt
            // 
            this.rbInt.AutoSize = true;
            this.rbInt.Location = new System.Drawing.Point(15, 35);
            this.rbInt.Name = "rbInt";
            this.rbInt.Size = new System.Drawing.Size(40, 17);
            this.rbInt.TabIndex = 1;
            this.rbInt.TabStop = true;
            this.rbInt.Text = "int";
            this.rbInt.UseVisualStyleBackColor = true;
            // 
            // rbFloat
            // 
            this.rbFloat.AutoSize = true;
            this.rbFloat.Location = new System.Drawing.Point(15, 58);
            this.rbFloat.Name = "rbFloat";
            this.rbFloat.Size = new System.Drawing.Size(47, 17);
            this.rbFloat.TabIndex = 2;
            this.rbFloat.TabStop = true;
            this.rbFloat.Text = "float";
            this.rbFloat.UseVisualStyleBackColor = true;
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Location = new System.Drawing.Point(12, 88);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(224, 13);
            this.lblQuestion2.TabIndex = 3;
            this.lblQuestion2.Text = "2. Какие типы являются вещественными?";
            // 
            // chkDouble
            // 
            this.chkDouble.AutoSize = true;
            this.chkDouble.Location = new System.Drawing.Point(15, 114);
            this.chkDouble.Name = "chkDouble";
            this.chkDouble.Size = new System.Drawing.Size(60, 17);
            this.chkDouble.TabIndex = 4;
            this.chkDouble.Text = "double";
            this.chkDouble.UseVisualStyleBackColor = true;
            // 
            // chkDecimal
            // 
            this.chkDecimal.AutoSize = true;
            this.chkDecimal.Location = new System.Drawing.Point(15, 137);
            this.chkDecimal.Name = "chkDecimal";
            this.chkDecimal.Size = new System.Drawing.Size(66, 17);
            this.chkDecimal.TabIndex = 5;
            this.chkDecimal.Text = "decimal";
            this.chkDecimal.UseVisualStyleBackColor = true;
            // 
            // chkFloat
            // 
            this.chkFloat.AutoSize = true;
            this.chkFloat.Location = new System.Drawing.Point(15, 160);
            this.chkFloat.Name = "chkFloat";
            this.chkFloat.Size = new System.Drawing.Size(47, 17);
            this.chkFloat.TabIndex = 6;
            this.chkFloat.Text = "float";
            this.chkFloat.UseVisualStyleBackColor = true;
            // 
            // chkString
            // 
            this.chkString.AutoSize = true;
            this.chkString.Location = new System.Drawing.Point(15, 183);
            this.chkString.Name = "chkString";
            this.chkString.Size = new System.Drawing.Size(54, 17);
            this.chkString.TabIndex = 7;
            this.chkString.Text = "string";
            this.chkString.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(15, 216);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(150, 219);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(138, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Результат: 0/2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.chkString);
            this.Controls.Add(this.chkFloat);
            this.Controls.Add(this.chkDecimal);
            this.Controls.Add(this.chkDouble);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.rbFloat);
            this.Controls.Add(this.rbInt);
            this.Controls.Add(this.lblQuestion1);
            this.Name = "Form1";
            this.Text = "Тест по типам данных C#";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.RadioButton rbInt;
        private System.Windows.Forms.RadioButton rbFloat;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.CheckBox chkDouble;
        private System.Windows.Forms.CheckBox chkDecimal;
        private System.Windows.Forms.CheckBox chkFloat;
        private System.Windows.Forms.CheckBox chkString;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
    }
}