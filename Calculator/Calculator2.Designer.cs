using System;

namespace Calculator
{
    partial class CalculatorForm
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
            this.buttonPercentage = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPercentage
            // 
            this.buttonPercentage.BackColor = System.Drawing.Color.DimGray;
            this.buttonPercentage.FlatAppearance.BorderSize = 0;
            this.buttonPercentage.ForeColor = System.Drawing.Color.White;
            this.buttonPercentage.Location = new System.Drawing.Point(85, 167);
            this.buttonPercentage.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPercentage.Name = "buttonPercentage";
            this.buttonPercentage.Size = new System.Drawing.Size(82, 57);
            this.buttonPercentage.TabIndex = 0;
            this.buttonPercentage.Text = "%";
            this.buttonPercentage.UseVisualStyleBackColor = false;
            this.buttonPercentage.Click += new System.EventHandler(this.getPercentageValue);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.BackColor = System.Drawing.Color.DimGray;
            this.clearEntryButton.FlatAppearance.BorderSize = 0;
            this.clearEntryButton.ForeColor = System.Drawing.Color.White;
            this.clearEntryButton.Location = new System.Drawing.Point(168, 167);
            this.clearEntryButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(82, 57);
            this.clearEntryButton.TabIndex = 1;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = false;
            this.clearEntryButton.Click += new System.EventHandler(this.ClearEntry);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.DimGray;
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.ForeColor = System.Drawing.Color.White;
            this.buttonDivide.Location = new System.Drawing.Point(334, 167);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(82, 57);
            this.buttonDivide.TabIndex = 3;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.Operation_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DimGray;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(251, 167);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 57);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearAllData);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.DimGray;
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.ForeColor = System.Drawing.Color.White;
            this.buttonMultiply.Location = new System.Drawing.Point(334, 225);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(82, 57);
            this.buttonMultiply.TabIndex = 7;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.Operation_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.Gray;
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.ForeColor = System.Drawing.Color.White;
            this.buttonNine.Location = new System.Drawing.Point(251, 225);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(82, 57);
            this.buttonNine.TabIndex = 6;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.Gray;
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.ForeColor = System.Drawing.Color.White;
            this.buttonEight.Location = new System.Drawing.Point(168, 225);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(82, 57);
            this.buttonEight.TabIndex = 5;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.Gray;
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.ForeColor = System.Drawing.Color.White;
            this.buttonSeven.Location = new System.Drawing.Point(85, 225);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(82, 57);
            this.buttonSeven.TabIndex = 4;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(334, 341);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 57);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.Operation_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.Gray;
            this.buttonThree.FlatAppearance.BorderSize = 0;
            this.buttonThree.ForeColor = System.Drawing.Color.White;
            this.buttonThree.Location = new System.Drawing.Point(251, 341);
            this.buttonThree.Margin = new System.Windows.Forms.Padding(5);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(82, 57);
            this.buttonThree.TabIndex = 14;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.Gray;
            this.buttonTwo.FlatAppearance.BorderSize = 0;
            this.buttonTwo.ForeColor = System.Drawing.Color.White;
            this.buttonTwo.Location = new System.Drawing.Point(168, 341);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(82, 57);
            this.buttonTwo.TabIndex = 13;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.Gray;
            this.buttonOne.FlatAppearance.BorderSize = 0;
            this.buttonOne.ForeColor = System.Drawing.Color.White;
            this.buttonOne.Location = new System.Drawing.Point(85, 341);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(82, 57);
            this.buttonOne.TabIndex = 12;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.DimGray;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.ForeColor = System.Drawing.Color.White;
            this.buttonMinus.Location = new System.Drawing.Point(334, 283);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(82, 57);
            this.buttonMinus.TabIndex = 11;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.Gray;
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.ForeColor = System.Drawing.Color.White;
            this.buttonSix.Location = new System.Drawing.Point(251, 283);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(82, 57);
            this.buttonSix.TabIndex = 10;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.Gray;
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.ForeColor = System.Drawing.Color.White;
            this.buttonFive.Location = new System.Drawing.Point(168, 283);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(82, 57);
            this.buttonFive.TabIndex = 9;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.Gray;
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.ForeColor = System.Drawing.Color.White;
            this.buttonFour.Location = new System.Drawing.Point(85, 283);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(82, 57);
            this.buttonFour.TabIndex = 8;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.ForeColor = System.Drawing.Color.Black;
            this.buttonEqual.Location = new System.Drawing.Point(334, 398);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(82, 57);
            this.buttonEqual.TabIndex = 19;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.get_Result_);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.Gray;
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.ForeColor = System.Drawing.Color.White;
            this.buttonDot.Location = new System.Drawing.Point(251, 398);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(82, 57);
            this.buttonDot.TabIndex = 18;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.Gray;
            this.buttonZero.FlatAppearance.BorderSize = 0;
            this.buttonZero.ForeColor = System.Drawing.Color.White;
            this.buttonZero.Location = new System.Drawing.Point(168, 398);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(5);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(82, 57);
            this.buttonZero.TabIndex = 17;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.BackColor = System.Drawing.Color.Gray;
            this.buttonNegative.FlatAppearance.BorderSize = 0;
            this.buttonNegative.ForeColor = System.Drawing.Color.White;
            this.buttonNegative.Location = new System.Drawing.Point(85, 398);
            this.buttonNegative.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(82, 57);
            this.buttonNegative.TabIndex = 16;
            this.buttonNegative.Text = "+/-";
            this.buttonNegative.UseVisualStyleBackColor = false;
            this.buttonNegative.Click += new System.EventHandler(this.negativeOperation_Click);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(86, 109);
            this.resultBox.MinimumSize = new System.Drawing.Size(4, 50);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(330, 49);
            this.resultBox.TabIndex = 20;
            this.resultBox.Tag = "0";
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.Color.White;
            this.displayBox.Location = new System.Drawing.Point(85, 53);
            this.displayBox.MinimumSize = new System.Drawing.Size(4, 50);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(330, 24);
            this.displayBox.TabIndex = 21;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(501, 509);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.buttonPercentage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button buttonPercentage;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox displayBox;
    }
}

