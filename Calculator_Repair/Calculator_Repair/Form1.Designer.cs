namespace Calculator_Repair
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonClear = new Button();
            button0 = new Button();
            buttonDot = new Button();
            buttonTotal = new Button();
            buttonDivide = new Button();
            buttonMinus = new Button();
            buttonMultiplication = new Button();
            buttonEqual = new Button();
            txtDisplay = new TextBox();
            buttonPositiveAndNegative = new Button();
            buttonPercent = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 216);
            button1.Name = "button1";
            button1.Size = new Size(49, 39);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(68, 216);
            button2.Name = "button2";
            button2.Size = new Size(49, 39);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(123, 216);
            button3.Name = "button3";
            button3.Size = new Size(49, 39);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(13, 171);
            button4.Name = "button4";
            button4.Size = new Size(49, 39);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(68, 171);
            button5.Name = "button5";
            button5.Size = new Size(49, 39);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(123, 171);
            button6.Name = "button6";
            button6.Size = new Size(49, 39);
            button6.TabIndex = 3;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(13, 126);
            button7.Name = "button7";
            button7.Size = new Size(49, 39);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(68, 126);
            button8.Name = "button8";
            button8.Size = new Size(49, 39);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(123, 126);
            button9.Name = "button9";
            button9.Size = new Size(49, 39);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(13, 81);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(49, 39);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "AC";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // button0
            // 
            button0.Location = new Point(68, 261);
            button0.Name = "button0";
            button0.Size = new Size(49, 39);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(123, 261);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(49, 39);
            buttonDot.TabIndex = 9;
            buttonDot.Text = ",";
            buttonDot.UseVisualStyleBackColor = true;
            // 
            // buttonTotal
            // 
            buttonTotal.Location = new Point(177, 216);
            buttonTotal.Name = "buttonTotal";
            buttonTotal.Size = new Size(49, 39);
            buttonTotal.TabIndex = 15;
            buttonTotal.Text = "+";
            buttonTotal.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(177, 81);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(49, 39);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(177, 171);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(49, 39);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.Location = new Point(177, 126);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(49, 39);
            buttonMultiplication.TabIndex = 12;
            buttonMultiplication.Text = "x";
            buttonMultiplication.UseVisualStyleBackColor = true;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(177, 261);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(49, 39);
            buttonEqual.TabIndex = 16;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            txtDisplay.Enabled = false;
            txtDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(214, 43);
            txtDisplay.TabIndex = 17;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonPositiveAndNegative
            // 
            buttonPositiveAndNegative.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPositiveAndNegative.Location = new Point(68, 81);
            buttonPositiveAndNegative.Name = "buttonPositiveAndNegative";
            buttonPositiveAndNegative.Size = new Size(49, 39);
            buttonPositiveAndNegative.TabIndex = 18;
            buttonPositiveAndNegative.Text = "+/-";
            buttonPositiveAndNegative.UseVisualStyleBackColor = true;
            buttonPositiveAndNegative.Click += buttonPositiveAndNegative_Click;
            // 
            // buttonPercent
            // 
            buttonPercent.Location = new Point(122, 81);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(49, 39);
            buttonPercent.TabIndex = 19;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // button12
            // 
            button12.Enabled = false;
            button12.Location = new Point(13, 261);
            button12.Name = "button12";
            button12.Size = new Size(49, 39);
            button12.TabIndex = 20;
            button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 318);
            Controls.Add(button12);
            Controls.Add(buttonPercent);
            Controls.Add(buttonPositiveAndNegative);
            Controls.Add(txtDisplay);
            Controls.Add(buttonEqual);
            Controls.Add(buttonTotal);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMinus);
            Controls.Add(buttonMultiplication);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(buttonDot);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonClear;
        private Button button0;
        private Button buttonDot;
        private Button buttonTotal;
        private Button buttonDivide;
        private Button buttonMinus;
        private Button buttonMultiplication;
        private Button buttonEqual;
        private TextBox txtDisplay;
        private Button buttonPositiveAndNegative;
        private Button buttonPercent;
        private Button button12;
    }
}