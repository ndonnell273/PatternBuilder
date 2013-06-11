namespace PatternBuilderStarter
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
            this.widthStitchesInput = new System.Windows.Forms.TextBox();
            this.wSLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.sizeStitchesInput = new System.Windows.Forms.TextBox();
            this.sizeStitchesLabel = new System.Windows.Forms.Label();
            this.goalWidthLabel = new System.Windows.Forms.Label();
            this.goalWidthInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // widthStitchesInput
            // 
            this.widthStitchesInput.Location = new System.Drawing.Point(668, 55);
            this.widthStitchesInput.Name = "widthStitchesInput";
            this.widthStitchesInput.Size = new System.Drawing.Size(262, 20);
            this.widthStitchesInput.TabIndex = 0;
            // 
            // wSLabel
            // 
            this.wSLabel.AutoSize = true;
            this.wSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wSLabel.Location = new System.Drawing.Point(313, 46);
            this.wSLabel.Name = "wSLabel";
            this.wSLabel.Size = new System.Drawing.Size(302, 29);
            this.wSLabel.TabIndex = 1;
            this.wSLabel.Text = "# of stitches wide in swatch";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(492, 160);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(123, 36);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(529, 258);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 3;
            // 
            // sizeStitchesInput
            // 
            this.sizeStitchesInput.Location = new System.Drawing.Point(668, 90);
            this.sizeStitchesInput.Name = "sizeStitchesInput";
            this.sizeStitchesInput.Size = new System.Drawing.Size(262, 20);
            this.sizeStitchesInput.TabIndex = 5;
            // 
            // sizeStitchesLabel
            // 
            this.sizeStitchesLabel.AutoSize = true;
            this.sizeStitchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeStitchesLabel.Location = new System.Drawing.Point(313, 84);
            this.sizeStitchesLabel.Name = "sizeStitchesLabel";
            this.sizeStitchesLabel.Size = new System.Drawing.Size(263, 25);
            this.sizeStitchesLabel.TabIndex = 6;
            this.sizeStitchesLabel.Text = "# of inches wide in swatch";
            // 
            // goalWidthLabel
            // 
            this.goalWidthLabel.AutoSize = true;
            this.goalWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalWidthLabel.Location = new System.Drawing.Point(319, 123);
            this.goalWidthLabel.Name = "goalWidthLabel";
            this.goalWidthLabel.Size = new System.Drawing.Size(118, 25);
            this.goalWidthLabel.TabIndex = 7;
            this.goalWidthLabel.Text = "Goal Width";
            // 
            // goalWidthInput
            // 
            this.goalWidthInput.Location = new System.Drawing.Point(671, 123);
            this.goalWidthInput.Name = "goalWidthInput";
            this.goalWidthInput.Size = new System.Drawing.Size(258, 20);
            this.goalWidthInput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 311);
            this.Controls.Add(this.goalWidthInput);
            this.Controls.Add(this.goalWidthLabel);
            this.Controls.Add(this.sizeStitchesLabel);
            this.Controls.Add(this.sizeStitchesInput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.wSLabel);
            this.Controls.Add(this.widthStitchesInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthStitchesInput;
        private System.Windows.Forms.Label wSLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox sizeStitchesInput;
        private System.Windows.Forms.Label sizeStitchesLabel;
        private System.Windows.Forms.Label goalWidthLabel;
        private System.Windows.Forms.TextBox goalWidthInput;
    }
}

