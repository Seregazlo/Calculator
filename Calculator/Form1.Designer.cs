namespace Calculator
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
            this.FirstField = new System.Windows.Forms.TextBox();
            this.SecondField = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Addition = new System.Windows.Forms.Button();
            this.Difference = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstField
            // 
            this.FirstField.Location = new System.Drawing.Point(12, 12);
            this.FirstField.Name = "FirstField";
            this.FirstField.Size = new System.Drawing.Size(75, 20);
            this.FirstField.TabIndex = 0;
            this.FirstField.TextChanged += new System.EventHandler(this.FirstField_TextChanged);
            // 
            // SecondField
            // 
            this.SecondField.Location = new System.Drawing.Point(108, 12);
            this.SecondField.Name = "SecondField";
            this.SecondField.Size = new System.Drawing.Size(70, 20);
            this.SecondField.TabIndex = 1;
            this.SecondField.TextChanged += new System.EventHandler(this.SecondField_TextChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(190, 15);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(40, 13);
            this.Result.TabIndex = 2;
            this.Result.Text = "           ";
            this.Result.Click += new System.EventHandler(this.ResultField_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 51);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 23);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "Сложение";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // Difference
            // 
            this.Difference.Location = new System.Drawing.Point(103, 51);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(75, 23);
            this.Difference.TabIndex = 4;
            this.Difference.Text = "Вычитание";
            this.Difference.UseVisualStyleBackColor = true;
            this.Difference.Click += new System.EventHandler(this.DifferenceButton_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(12, 100);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "Умножение";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(103, 100);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "Деление";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 172);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondField);
            this.Controls.Add(this.FirstField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstField;
        private System.Windows.Forms.TextBox SecondField;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Difference;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
    }
}

