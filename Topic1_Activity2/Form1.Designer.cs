namespace Topic1_Activity2
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
            fahrenhietLabel = new Label();
            celsiusLabel = new Label();
            celsiusInput = new TextBox();
            fahrenhietOutput = new Label();
            convertButton = new Button();
            SuspendLayout();
            // 
            // fahrenhietLabel
            // 
            fahrenhietLabel.AutoSize = true;
            fahrenhietLabel.Location = new Point(176, 115);
            fahrenhietLabel.Name = "fahrenhietLabel";
            fahrenhietLabel.Size = new Size(88, 20);
            fahrenhietLabel.TabIndex = 0;
            fahrenhietLabel.Text = "Output in F°";
            // 
            // celsiusLabel
            // 
            celsiusLabel.AutoSize = true;
            celsiusLabel.Location = new Point(129, 63);
            celsiusLabel.Name = "celsiusLabel";
            celsiusLabel.Size = new Size(135, 20);
            celsiusLabel.TabIndex = 1;
            celsiusLabel.Text = "Input degrees in C°";
            // 
            // celsiusInput
            // 
            celsiusInput.Location = new Point(280, 60);
            celsiusInput.Name = "celsiusInput";
            celsiusInput.Size = new Size(125, 27);
            celsiusInput.TabIndex = 2;
            // 
            // fahrenhietOutput
            // 
            fahrenhietOutput.BackColor = SystemColors.Window;
            fahrenhietOutput.BorderStyle = BorderStyle.FixedSingle;
            fahrenhietOutput.Location = new Point(280, 107);
            fahrenhietOutput.Name = "fahrenhietOutput";
            fahrenhietOutput.Size = new Size(125, 28);
            fahrenhietOutput.TabIndex = 3;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(236, 191);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(94, 29);
            convertButton.TabIndex = 4;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 291);
            Controls.Add(convertButton);
            Controls.Add(fahrenhietOutput);
            Controls.Add(celsiusInput);
            Controls.Add(celsiusLabel);
            Controls.Add(fahrenhietLabel);
            Name = "Form1";
            Text = "Celsius to Fahrenhiet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fahrenhietLabel;
        private Label celsiusLabel;
        private TextBox celsiusInput;
        private Label fahrenhietOutput;
        private Button convertButton;
    }
}