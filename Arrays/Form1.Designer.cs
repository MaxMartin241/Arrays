namespace Arrays
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
            this.runButton = new System.Windows.Forms.Button();
            this.array1Label = new System.Windows.Forms.Label();
            this.array2Label = new System.Windows.Forms.Label();
            this.array1ReverseLabel = new System.Windows.Forms.Label();
            this.highestNumberLabel = new System.Windows.Forms.Label();
            this.avrageLabel = new System.Windows.Forms.Label();
            this.sumOfAllEvenNums = new System.Windows.Forms.Label();
            this.numOf3Label = new System.Windows.Forms.Label();
            this.numOfMatchingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Goldenrod;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(-11, -4);
            this.runButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(310, 101);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // array1Label
            // 
            this.array1Label.AutoSize = true;
            this.array1Label.Location = new System.Drawing.Point(77, 125);
            this.array1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.array1Label.Name = "array1Label";
            this.array1Label.Size = new System.Drawing.Size(0, 13);
            this.array1Label.TabIndex = 1;
            // 
            // array2Label
            // 
            this.array2Label.AutoSize = true;
            this.array2Label.Location = new System.Drawing.Point(77, 158);
            this.array2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.array2Label.Name = "array2Label";
            this.array2Label.Size = new System.Drawing.Size(0, 13);
            this.array2Label.TabIndex = 2;
            // 
            // array1ReverseLabel
            // 
            this.array1ReverseLabel.AutoSize = true;
            this.array1ReverseLabel.Location = new System.Drawing.Point(77, 188);
            this.array1ReverseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.array1ReverseLabel.Name = "array1ReverseLabel";
            this.array1ReverseLabel.Size = new System.Drawing.Size(0, 13);
            this.array1ReverseLabel.TabIndex = 3;
            this.array1ReverseLabel.Click += new System.EventHandler(this.array1ReverseLabel_Click);
            // 
            // highestNumberLabel
            // 
            this.highestNumberLabel.AutoSize = true;
            this.highestNumberLabel.Location = new System.Drawing.Point(468, 84);
            this.highestNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highestNumberLabel.Name = "highestNumberLabel";
            this.highestNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.highestNumberLabel.TabIndex = 4;
            // 
            // avrageLabel
            // 
            this.avrageLabel.AutoSize = true;
            this.avrageLabel.Location = new System.Drawing.Point(468, 125);
            this.avrageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avrageLabel.Name = "avrageLabel";
            this.avrageLabel.Size = new System.Drawing.Size(0, 13);
            this.avrageLabel.TabIndex = 5;
            // 
            // sumOfAllEvenNums
            // 
            this.sumOfAllEvenNums.AutoSize = true;
            this.sumOfAllEvenNums.Location = new System.Drawing.Point(468, 173);
            this.sumOfAllEvenNums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sumOfAllEvenNums.Name = "sumOfAllEvenNums";
            this.sumOfAllEvenNums.Size = new System.Drawing.Size(0, 13);
            this.sumOfAllEvenNums.TabIndex = 6;
            // 
            // numOf3Label
            // 
            this.numOf3Label.AutoSize = true;
            this.numOf3Label.Location = new System.Drawing.Point(468, 229);
            this.numOf3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numOf3Label.Name = "numOf3Label";
            this.numOf3Label.Size = new System.Drawing.Size(0, 13);
            this.numOf3Label.TabIndex = 7;
            // 
            // numOfMatchingLabel
            // 
            this.numOfMatchingLabel.AutoSize = true;
            this.numOfMatchingLabel.Location = new System.Drawing.Point(468, 280);
            this.numOfMatchingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numOfMatchingLabel.Name = "numOfMatchingLabel";
            this.numOfMatchingLabel.Size = new System.Drawing.Size(0, 13);
            this.numOfMatchingLabel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(295, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 370);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfMatchingLabel);
            this.Controls.Add(this.numOf3Label);
            this.Controls.Add(this.sumOfAllEvenNums);
            this.Controls.Add(this.avrageLabel);
            this.Controls.Add(this.highestNumberLabel);
            this.Controls.Add(this.array1ReverseLabel);
            this.Controls.Add(this.array2Label);
            this.Controls.Add(this.array1Label);
            this.Controls.Add(this.runButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label array1Label;
        private System.Windows.Forms.Label array2Label;
        private System.Windows.Forms.Label array1ReverseLabel;
        private System.Windows.Forms.Label highestNumberLabel;
        private System.Windows.Forms.Label avrageLabel;
        private System.Windows.Forms.Label sumOfAllEvenNums;
        private System.Windows.Forms.Label numOf3Label;
        private System.Windows.Forms.Label numOfMatchingLabel;
        private System.Windows.Forms.Label label1;
    }
}

