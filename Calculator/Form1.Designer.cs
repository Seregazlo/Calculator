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
            this.Log10 = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.CosH = new System.Windows.Forms.Button();
            this.ArithmeticMean = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.RemainDivision = new System.Windows.Forms.Button();
            this.stx = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.xten = new System.Windows.Forms.Button();
            this.fx = new System.Windows.Forms.Button();
            this.minxy = new System.Windows.Forms.Button();
            this.SinH = new System.Windows.Forms.Button();
            this.maxxy = new System.Windows.Forms.Button();
            this.tanh = new System.Windows.Forms.Button();
            this.xoney = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
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
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(203, 81);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(75, 23);
            this.Log10.TabIndex = 12;
            this.Log10.Text = "log10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.CheckButton_Click_2);
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
            // CosH
            // 
            this.CosH.Location = new System.Drawing.Point(203, 201);
            this.CosH.Name = "CosH";
            this.CosH.Size = new System.Drawing.Size(75, 23);
            this.CosH.TabIndex = 16;
            this.CosH.Text = "cosh()";
            this.CosH.UseVisualStyleBackColor = true;
            this.CosH.Click += new System.EventHandler(this.CheckButton_Click_2);
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
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(203, 291);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(75, 23);
            this.Pow.TabIndex = 19;
            this.Pow.Text = "Возв.в ст.";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.CheckButton_Click);
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
            // stx
            // 
            this.stx.Location = new System.Drawing.Point(302, 51);
            this.stx.Name = "stx";
            this.stx.Size = new System.Drawing.Size(75, 23);
            this.stx.TabIndex = 21;
            this.stx.Text = "2^x";
            this.stx.UseVisualStyleBackColor = true;
            this.stx.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // logxy
            // 
            this.logxy.Location = new System.Drawing.Point(302, 81);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(75, 23);
            this.logxy.TabIndex = 22;
            this.logxy.Text = "logx(y)";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // xten
            // 
            this.xten.Location = new System.Drawing.Point(302, 111);
            this.xten.Name = "xten";
            this.xten.Size = new System.Drawing.Size(75, 23);
            this.xten.TabIndex = 23;
            this.xten.Text = "10^x";
            this.xten.UseVisualStyleBackColor = true;
            this.xten.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // fx
            // 
            this.fx.Location = new System.Drawing.Point(302, 141);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(75, 23);
            this.fx.TabIndex = 24;
            this.fx.Text = "-x";
            this.fx.UseVisualStyleBackColor = true;
            this.fx.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // minxy
            // 
            this.minxy.Location = new System.Drawing.Point(302, 171);
            this.minxy.Name = "minxy";
            this.minxy.Size = new System.Drawing.Size(75, 23);
            this.minxy.TabIndex = 25;
            this.minxy.Text = "min(x,y)";
            this.minxy.UseVisualStyleBackColor = true;
            this.minxy.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // SinH
            // 
            this.SinH.Location = new System.Drawing.Point(302, 201);
            this.SinH.Name = "SinH";
            this.SinH.Size = new System.Drawing.Size(75, 23);
            this.SinH.TabIndex = 26;
            this.SinH.Text = "sinh()";
            this.SinH.UseVisualStyleBackColor = true;
            this.SinH.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // maxxy
            // 
            this.maxxy.Location = new System.Drawing.Point(302, 231);
            this.maxxy.Name = "maxxy";
            this.maxxy.Size = new System.Drawing.Size(75, 23);
            this.maxxy.TabIndex = 27;
            this.maxxy.Text = "max(x,y)";
            this.maxxy.UseVisualStyleBackColor = true;
            this.maxxy.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // tanh
            // 
            this.tanh.Location = new System.Drawing.Point(302, 261);
            this.tanh.Name = "tanh";
            this.tanh.Size = new System.Drawing.Size(75, 23);
            this.tanh.TabIndex = 28;
            this.tanh.Text = "tanh()";
            this.tanh.UseVisualStyleBackColor = true;
            this.tanh.Click += new System.EventHandler(this.CheckButton_Click_2);
            // 
            // xoney
            // 
            this.xoney.Location = new System.Drawing.Point(302, 291);
            this.xoney.Name = "xoney";
            this.xoney.Size = new System.Drawing.Size(75, 23);
            this.xoney.TabIndex = 29;
            this.xoney.Text = "x^(1/y)";
            this.xoney.UseVisualStyleBackColor = true;
            this.xoney.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(302, 321);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 30;
            this.exp.Text = "Exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.CheckButton_Click_2);
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
            this.Controls.Add(this.exp);
            this.Controls.Add(this.xoney);
            this.Controls.Add(this.tanh);
            this.Controls.Add(this.maxxy);
            this.Controls.Add(this.SinH);
            this.Controls.Add(this.minxy);
            this.Controls.Add(this.fx);
            this.Controls.Add(this.xten);
            this.Controls.Add(this.logxy);
            this.Controls.Add(this.stx);
            this.Controls.Add(this.RemainDivision);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.ArithmeticMean);
            this.Controls.Add(this.CosH);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Log10);
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
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button CosH;
        private System.Windows.Forms.Button ArithmeticMean;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button RemainDivision;
        private System.Windows.Forms.Button stx;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button xten;
        private System.Windows.Forms.Button fx;
        private System.Windows.Forms.Button minxy;
        private System.Windows.Forms.Button SinH;
        private System.Windows.Forms.Button maxxy;
        private System.Windows.Forms.Button tanh;
        private System.Windows.Forms.Button xoney;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Label label1;
    }
}

