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
            farenhietLabel = new Label();
            celsiusLabel = new Label();
            celsiusInput = new TextBox();
            farenhietOutput = new Label();
            convertButton = new Button();
            SuspendLayout();
            // 
            // farenhietLabel
            // 
            farenhietLabel.AutoSize = true;
            farenhietLabel.Location = new Point(176, 115);
            farenhietLabel.Name = "farenhietLabel";
            farenhietLabel.Size = new Size(88, 20);
            farenhietLabel.TabIndex = 0;
            farenhietLabel.Text = "Output in F°";
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
            // farenhietOutput
            // 
            farenhietOutput.BackColor = SystemColors.Window;
            farenhietOutput.BorderStyle = BorderStyle.FixedSingle;
            farenhietOutput.Location = new Point(280, 107);
            farenhietOutput.Name = "farenhietOutput";
            farenhietOutput.Size = new Size(125, 28);
            farenhietOutput.TabIndex = 3;
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
            Controls.Add(farenhietOutput);
            Controls.Add(celsiusInput);
            Controls.Add(celsiusLabel);
            Controls.Add(farenhietLabel);
            Name = "Form1";
            Text = "Celsius to Farenhiet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label farenhietLabel;
        private Label celsiusLabel;
        private TextBox celsiusInput;
        private Label farenhietOutput;
        private Button convertButton;
    }
}