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
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Ctan = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Arcctan = new System.Windows.Forms.Button();
            this.ArithmeticMean = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.PointAngle = new System.Windows.Forms.Button();
            this.RemainDivision = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SecondField.Size = new System.Drawing.Size(75, 20);
            this.SecondField.TabIndex = 1;
            this.SecondField.TextChanged += new System.EventHandler(this.SecondField_TextChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(238, 15);
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
            this.Addition.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Difference
            // 
            this.Difference.Location = new System.Drawing.Point(108, 51);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(75, 23);
            this.Difference.TabIndex = 4;
            this.Difference.Text = "Вычитание";
            this.Difference.UseVisualStyleBackColor = true;
            this.Difference.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(12, 100);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "Умножение";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(108, 100);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "Деление";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(12, 148);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "sin()";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(108, 148);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "cos()";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Exponent
            // 
            this.Exponent.Location = new System.Drawing.Point(12, 188);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(75, 23);
            this.Exponent.TabIndex = 9;
            this.Exponent.Text = "Степень";
            this.Exponent.UseVisualStyleBackColor = true;
            this.Exponent.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(108, 188);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 23);
            this.Sqrt.TabIndex = 10;
            this.Sqrt.Text = "Корень";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(203, 51);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 11;
            this.Tan.Text = "tan()";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Ctan
            // 
            this.Ctan.Location = new System.Drawing.Point(203, 81);
            this.Ctan.Name = "Ctan";
            this.Ctan.Size = new System.Drawing.Size(75, 23);
            this.Ctan.TabIndex = 12;
            this.Ctan.Text = "ctan()";
            this.Ctan.UseVisualStyleBackColor = true;
            this.Ctan.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(203, 111);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 23);
            this.Arcsin.TabIndex = 13;
            this.Arcsin.Text = "arcsin()";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(203, 141);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 14;
            this.Arccos.Text = "arccos()";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Arctan
            // 
            this.Arctan.Location = new System.Drawing.Point(203, 171);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(75, 23);
            this.Arctan.TabIndex = 15;
            this.Arctan.Text = "arctan()";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // Arcctan
            // 
            this.Arcctan.Location = new System.Drawing.Point(203, 201);
            this.Arcctan.Name = "Arcctan";
            this.Arcctan.Size = new System.Drawing.Size(75, 23);
            this.Arcctan.TabIndex = 16;
            this.Arcctan.Text = "arctctan()";
            this.Arcctan.UseVisualStyleBackColor = true;
            this.Arcctan.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // ArithmeticMean
            // 
            this.ArithmeticMean.Location = new System.Drawing.Point(203, 231);
            this.ArithmeticMean.Name = "ArithmeticMean";
            this.ArithmeticMean.Size = new System.Drawing.Size(75, 23);
            this.ArithmeticMean.TabIndex = 17;
            this.ArithmeticMean.Text = "Ср.Ариф.";
            this.ArithmeticMean.UseVisualStyleBackColor = true;
            this.ArithmeticMean.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(203, 261);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(75, 23);
            this.Mod.TabIndex = 18;
            this.Mod.Text = "Модуль";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // PointAngle
            // 
            this.PointAngle.Location = new System.Drawing.Point(203, 291);
            this.PointAngle.Name = "PointAngle";
            this.PointAngle.Size = new System.Drawing.Size(75, 23);
            this.PointAngle.TabIndex = 19;
            this.PointAngle.Text = "1/x";
            this.PointAngle.UseVisualStyleBackColor = true;
            this.PointAngle.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // RemainDivision
            // 
            this.RemainDivision.Location = new System.Drawing.Point(203, 321);
            this.RemainDivision.Name = "RemainDivision";
            this.RemainDivision.Size = new System.Drawing.Size(75, 23);
            this.RemainDivision.TabIndex = 20;
            this.RemainDivision.Text = "Ост.дел.";
            this.RemainDivision.UseVisualStyleBackColor = true;
            this.RemainDivision.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(302, 51);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 21;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(302, 81);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 22;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(302, 111);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 23;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(302, 141);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 24;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(302, 171);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 25;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(302, 201);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 26;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(302, 231);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 27;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(302, 261);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 28;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(302, 291);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 29;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(302, 321);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 30;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.RemainDivision);
            this.Controls.Add(this.PointAngle);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.ArithmeticMean);
            this.Controls.Add(this.Arcctan);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Ctan);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondField);
            this.Controls.Add(this.FirstField);
            this.Name = "Form1";
            this.Text = "Калькулятор Богов";
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
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Exponent;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Ctan;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Arcctan;
        private System.Windows.Forms.Button ArithmeticMean;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button PointAngle;
        private System.Windows.Forms.Button RemainDivision;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label1;
    }
}

