
namespace WindowsFormsCalculatorApplication
{
    partial class Form1
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
            this.lblCalculator = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.txtBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.txtBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.rbtnAddition = new System.Windows.Forms.RadioButton();
            this.rbtnSubtraction = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplication = new System.Windows.Forms.RadioButton();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalculator
            // 
            this.lblCalculator.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculator.Location = new System.Drawing.Point(319, 27);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(130, 34);
            this.lblCalculator.TabIndex = 0;
            this.lblCalculator.Text = "Calculator";
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.Location = new System.Drawing.Point(110, 86);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(138, 19);
            this.lblFirstNumber.TabIndex = 1;
            this.lblFirstNumber.Text = "Enter the first number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.Location = new System.Drawing.Point(110, 136);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(159, 19);
            this.lblSecondNumber.TabIndex = 2;
            this.lblSecondNumber.Text = "Enter the second number";
            // 
            // txtBoxFirstNumber
            // 
            this.txtBoxFirstNumber.Location = new System.Drawing.Point(323, 85);
            this.txtBoxFirstNumber.Name = "txtBoxFirstNumber";
            this.txtBoxFirstNumber.Size = new System.Drawing.Size(167, 20);
            this.txtBoxFirstNumber.TabIndex = 3;
            // 
            // txtBoxSecondNumber
            // 
            this.txtBoxSecondNumber.Location = new System.Drawing.Point(323, 137);
            this.txtBoxSecondNumber.Name = "txtBoxSecondNumber";
            this.txtBoxSecondNumber.Size = new System.Drawing.Size(167, 20);
            this.txtBoxSecondNumber.TabIndex = 4;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(110, 190);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(139, 19);
            this.lblOperation.TabIndex = 5;
            this.lblOperation.Text = "Choose the operation";
            // 
            // rbtnAddition
            // 
            this.rbtnAddition.AutoSize = true;
            this.rbtnAddition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAddition.Location = new System.Drawing.Point(323, 190);
            this.rbtnAddition.Name = "rbtnAddition";
            this.rbtnAddition.Size = new System.Drawing.Size(79, 23);
            this.rbtnAddition.TabIndex = 6;
            this.rbtnAddition.TabStop = true;
            this.rbtnAddition.Text = "Addition";
            this.rbtnAddition.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtraction
            // 
            this.rbtnSubtraction.AutoSize = true;
            this.rbtnSubtraction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubtraction.Location = new System.Drawing.Point(408, 190);
            this.rbtnSubtraction.Name = "rbtnSubtraction";
            this.rbtnSubtraction.Size = new System.Drawing.Size(96, 23);
            this.rbtnSubtraction.TabIndex = 7;
            this.rbtnSubtraction.TabStop = true;
            this.rbtnSubtraction.Text = "Subtraction";
            this.rbtnSubtraction.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplication
            // 
            this.rbtnMultiplication.AutoSize = true;
            this.rbtnMultiplication.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiplication.Location = new System.Drawing.Point(510, 190);
            this.rbtnMultiplication.Name = "rbtnMultiplication";
            this.rbtnMultiplication.Size = new System.Drawing.Size(108, 23);
            this.rbtnMultiplication.TabIndex = 8;
            this.rbtnMultiplication.TabStop = true;
            this.rbtnMultiplication.Text = "Multiplication";
            this.rbtnMultiplication.UseVisualStyleBackColor = true;
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDivision.Location = new System.Drawing.Point(624, 190);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(75, 23);
            this.rbtnDivision.TabIndex = 9;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "Division";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(314, 259);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(124, 28);
            this.btnResult.TabIndex = 10;
            this.btnResult.Text = "Calculate Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.rbtnDivision);
            this.Controls.Add(this.rbtnMultiplication);
            this.Controls.Add(this.rbtnSubtraction);
            this.Controls.Add(this.rbtnAddition);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.txtBoxSecondNumber);
            this.Controls.Add(this.txtBoxFirstNumber);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.lblCalculator);
            this.Name = "Form1";
            this.Text = "CalculatorApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.TextBox txtBoxFirstNumber;
        private System.Windows.Forms.TextBox txtBoxSecondNumber;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.RadioButton rbtnAddition;
        private System.Windows.Forms.RadioButton rbtnSubtraction;
        private System.Windows.Forms.RadioButton rbtnMultiplication;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.Button btnResult;
    }
}

