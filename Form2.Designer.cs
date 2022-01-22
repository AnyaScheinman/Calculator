namespace InClass1_Calculator
{
    partial class Form2
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
            this.txtOperand = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDigit3 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAddOperator = new System.Windows.Forms.Button();
            this.btnSubtractionOperator = new System.Windows.Forms.Button();
            this.btnDivisionOperator = new System.Windows.Forms.Button();
            this.btnMultiplicationOperator = new System.Windows.Forms.Button();
            this.btnDigit9 = new System.Windows.Forms.Button();
            this.btnDigit4 = new System.Windows.Forms.Button();
            this.btnDigit1 = new System.Windows.Forms.Button();
            this.btnDigit6 = new System.Windows.Forms.Button();
            this.btnDigit8 = new System.Windows.Forms.Button();
            this.btnDigit5 = new System.Windows.Forms.Button();
            this.btnDigit2 = new System.Windows.Forms.Button();
            this.btnDigit0 = new System.Windows.Forms.Button();
            this.btnDigit7 = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOperand
            // 
            this.txtOperand.Location = new System.Drawing.Point(14, 34);
            this.txtOperand.Name = "txtOperand";
            this.txtOperand.ReadOnly = true;
            this.txtOperand.Size = new System.Drawing.Size(329, 27);
            this.txtOperand.TabIndex = 37;
            this.txtOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOperand.TextChanged += new System.EventHandler(this.txtOperand_TextChanged);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.ForeColor = System.Drawing.Color.Black;
            this.btnEqual.Location = new System.Drawing.Point(276, 381);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(67, 68);
            this.btnEqual.TabIndex = 36;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDigit3
            // 
            this.btnDigit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit3.ForeColor = System.Drawing.Color.Black;
            this.btnDigit3.Location = new System.Drawing.Point(168, 303);
            this.btnDigit3.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit3.Name = "btnDigit3";
            this.btnDigit3.Size = new System.Drawing.Size(67, 68);
            this.btnDigit3.TabIndex = 35;
            this.btnDigit3.Text = "3";
            this.btnDigit3.UseVisualStyleBackColor = true;
            this.btnDigit3.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.ForeColor = System.Drawing.Color.Black;
            this.btnDecimal.Location = new System.Drawing.Point(168, 381);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(5);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(67, 68);
            this.btnDecimal.TabIndex = 34;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnAddOperator
            // 
            this.btnAddOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddOperator.ForeColor = System.Drawing.Color.Black;
            this.btnAddOperator.Location = new System.Drawing.Point(276, 69);
            this.btnAddOperator.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddOperator.Name = "btnAddOperator";
            this.btnAddOperator.Size = new System.Drawing.Size(67, 68);
            this.btnAddOperator.TabIndex = 33;
            this.btnAddOperator.Text = "+";
            this.btnAddOperator.UseVisualStyleBackColor = true;
            this.btnAddOperator.Click += new System.EventHandler(this.btnOperationAdd_Click);
            // 
            // btnSubtractionOperator
            // 
            this.btnSubtractionOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubtractionOperator.ForeColor = System.Drawing.Color.Black;
            this.btnSubtractionOperator.Location = new System.Drawing.Point(276, 147);
            this.btnSubtractionOperator.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubtractionOperator.Name = "btnSubtractionOperator";
            this.btnSubtractionOperator.Size = new System.Drawing.Size(67, 68);
            this.btnSubtractionOperator.TabIndex = 32;
            this.btnSubtractionOperator.Text = "-";
            this.btnSubtractionOperator.UseVisualStyleBackColor = true;
            this.btnSubtractionOperator.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnDivisionOperator
            // 
            this.btnDivisionOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivisionOperator.ForeColor = System.Drawing.Color.Black;
            this.btnDivisionOperator.Location = new System.Drawing.Point(276, 303);
            this.btnDivisionOperator.Margin = new System.Windows.Forms.Padding(5);
            this.btnDivisionOperator.Name = "btnDivisionOperator";
            this.btnDivisionOperator.Size = new System.Drawing.Size(67, 68);
            this.btnDivisionOperator.TabIndex = 31;
            this.btnDivisionOperator.Text = "/";
            this.btnDivisionOperator.UseVisualStyleBackColor = true;
            this.btnDivisionOperator.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplicationOperator
            // 
            this.btnMultiplicationOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicationOperator.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicationOperator.Location = new System.Drawing.Point(276, 225);
            this.btnMultiplicationOperator.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultiplicationOperator.Name = "btnMultiplicationOperator";
            this.btnMultiplicationOperator.Size = new System.Drawing.Size(67, 68);
            this.btnMultiplicationOperator.TabIndex = 30;
            this.btnMultiplicationOperator.Text = "*";
            this.btnMultiplicationOperator.UseVisualStyleBackColor = true;
            this.btnMultiplicationOperator.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDigit9
            // 
            this.btnDigit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit9.ForeColor = System.Drawing.Color.Black;
            this.btnDigit9.Location = new System.Drawing.Point(168, 147);
            this.btnDigit9.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit9.Name = "btnDigit9";
            this.btnDigit9.Size = new System.Drawing.Size(67, 68);
            this.btnDigit9.TabIndex = 29;
            this.btnDigit9.Text = "9";
            this.btnDigit9.UseVisualStyleBackColor = true;
            this.btnDigit9.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit4
            // 
            this.btnDigit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit4.ForeColor = System.Drawing.Color.Black;
            this.btnDigit4.Location = new System.Drawing.Point(14, 225);
            this.btnDigit4.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit4.Name = "btnDigit4";
            this.btnDigit4.Size = new System.Drawing.Size(67, 68);
            this.btnDigit4.TabIndex = 28;
            this.btnDigit4.Text = "4";
            this.btnDigit4.UseVisualStyleBackColor = true;
            this.btnDigit4.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit1
            // 
            this.btnDigit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit1.ForeColor = System.Drawing.Color.Black;
            this.btnDigit1.Location = new System.Drawing.Point(14, 303);
            this.btnDigit1.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit1.Name = "btnDigit1";
            this.btnDigit1.Size = new System.Drawing.Size(67, 68);
            this.btnDigit1.TabIndex = 27;
            this.btnDigit1.Text = "1";
            this.btnDigit1.UseVisualStyleBackColor = true;
            this.btnDigit1.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit6
            // 
            this.btnDigit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit6.ForeColor = System.Drawing.Color.Black;
            this.btnDigit6.Location = new System.Drawing.Point(168, 225);
            this.btnDigit6.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit6.Name = "btnDigit6";
            this.btnDigit6.Size = new System.Drawing.Size(67, 68);
            this.btnDigit6.TabIndex = 26;
            this.btnDigit6.Text = "6";
            this.btnDigit6.UseVisualStyleBackColor = true;
            this.btnDigit6.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit8
            // 
            this.btnDigit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit8.ForeColor = System.Drawing.Color.Black;
            this.btnDigit8.Location = new System.Drawing.Point(91, 147);
            this.btnDigit8.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit8.Name = "btnDigit8";
            this.btnDigit8.Size = new System.Drawing.Size(67, 68);
            this.btnDigit8.TabIndex = 25;
            this.btnDigit8.Text = "8";
            this.btnDigit8.UseVisualStyleBackColor = true;
            this.btnDigit8.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit5
            // 
            this.btnDigit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit5.ForeColor = System.Drawing.Color.Black;
            this.btnDigit5.Location = new System.Drawing.Point(91, 225);
            this.btnDigit5.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit5.Name = "btnDigit5";
            this.btnDigit5.Size = new System.Drawing.Size(67, 68);
            this.btnDigit5.TabIndex = 24;
            this.btnDigit5.Text = "5";
            this.btnDigit5.UseVisualStyleBackColor = true;
            this.btnDigit5.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit2
            // 
            this.btnDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit2.ForeColor = System.Drawing.Color.Black;
            this.btnDigit2.Location = new System.Drawing.Point(91, 303);
            this.btnDigit2.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit2.Name = "btnDigit2";
            this.btnDigit2.Size = new System.Drawing.Size(67, 68);
            this.btnDigit2.TabIndex = 23;
            this.btnDigit2.Text = "2";
            this.btnDigit2.UseVisualStyleBackColor = true;
            this.btnDigit2.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit0
            // 
            this.btnDigit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit0.ForeColor = System.Drawing.Color.Black;
            this.btnDigit0.Location = new System.Drawing.Point(91, 381);
            this.btnDigit0.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit0.Name = "btnDigit0";
            this.btnDigit0.Size = new System.Drawing.Size(67, 68);
            this.btnDigit0.TabIndex = 22;
            this.btnDigit0.Text = "0";
            this.btnDigit0.UseVisualStyleBackColor = true;
            this.btnDigit0.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnDigit7
            // 
            this.btnDigit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDigit7.ForeColor = System.Drawing.Color.Black;
            this.btnDigit7.Location = new System.Drawing.Point(14, 147);
            this.btnDigit7.Margin = new System.Windows.Forms.Padding(5);
            this.btnDigit7.Name = "btnDigit7";
            this.btnDigit7.Size = new System.Drawing.Size(67, 68);
            this.btnDigit7.TabIndex = 21;
            this.btnDigit7.Text = "7";
            this.btnDigit7.UseVisualStyleBackColor = true;
            this.btnDigit7.Click += new System.EventHandler(this.digitClickHandler);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearEntry.ForeColor = System.Drawing.Color.Black;
            this.btnClearEntry.Location = new System.Drawing.Point(91, 69);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(67, 68);
            this.btnClearEntry.TabIndex = 20;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(14, 69);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 68);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(12, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 38;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 500);
            this.Controls.Add(this.result);
            this.Controls.Add(this.txtOperand);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDigit3);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnAddOperator);
            this.Controls.Add(this.btnSubtractionOperator);
            this.Controls.Add(this.btnDivisionOperator);
            this.Controls.Add(this.btnMultiplicationOperator);
            this.Controls.Add(this.btnDigit9);
            this.Controls.Add(this.btnDigit4);
            this.Controls.Add(this.btnDigit1);
            this.Controls.Add(this.btnDigit6);
            this.Controls.Add(this.btnDigit8);
            this.Controls.Add(this.btnDigit5);
            this.Controls.Add(this.btnDigit2);
            this.Controls.Add(this.btnDigit0);
            this.Controls.Add(this.btnDigit7);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnClear);
            this.Name = "Form2";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.digitClickHandler);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOperand;
        private Button btnEqual;
        private Button btnDigit3;
        private Button btnDecimal;
        private Button btnAddOperator;
        private Button btnSubtractionOperator;
        private Button btnDivisionOperator;
        private Button btnMultiplicationOperator;
        private Button btnDigit9;
        private Button btnDigit4;
        private Button btnDigit1;
        private Button btnDigit6;
        private Button btnDigit8;
        private Button btnDigit5;
        private Button btnDigit2;
        private Button btnDigit0;
        private Button btnDigit7;
        private Button btnClearEntry;
        private Button btnClear;
        private Label result;
    }
}