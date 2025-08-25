namespace SimpleCalc
{
    partial class Form_Horie
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
            Input1TextBox = new TextBox();
            plusLabel = new Label();
            Input2TextBox = new TextBox();
            equalLabel = new Label();
            answerTextBox = new TextBox();
            CalcButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // Input1TextBox
            // 
            Input1TextBox.Location = new Point(33, 75);
            Input1TextBox.Name = "Input1TextBox";
            Input1TextBox.Size = new Size(128, 27);
            Input1TextBox.TabIndex = 0;
            // 
            // plusLabel
            // 
            plusLabel.AutoSize = true;
            plusLabel.Location = new Point(197, 81);
            plusLabel.Name = "plusLabel";
            plusLabel.Size = new Size(19, 20);
            plusLabel.TabIndex = 1;
            plusLabel.Text = "+";
            // 
            // Input2TextBox
            // 
            Input2TextBox.Location = new Point(244, 76);
            Input2TextBox.Name = "Input2TextBox";
            Input2TextBox.Size = new Size(145, 27);
            Input2TextBox.TabIndex = 2;
            // 
            // equalLabel
            // 
            equalLabel.AutoSize = true;
            equalLabel.Location = new Point(427, 80);
            equalLabel.Name = "equalLabel";
            equalLabel.Size = new Size(19, 20);
            equalLabel.TabIndex = 3;
            equalLabel.Text = "=";
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(477, 78);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(146, 27);
            answerTextBox.TabIndex = 4;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(33, 177);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(590, 42);
            CalcButton.TabIndex = 5;
            CalcButton.Text = "計算する";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += CalcButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = SystemColors.ControlText;
            errorLabel.Location = new Point(33, 129);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(103, 20);
            errorLabel.TabIndex = 6;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // Form_Horie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 257);
            Controls.Add(errorLabel);
            Controls.Add(CalcButton);
            Controls.Add(answerTextBox);
            Controls.Add(equalLabel);
            Controls.Add(Input2TextBox);
            Controls.Add(plusLabel);
            Controls.Add(Input1TextBox);
            Name = "Form_Horie";
            Padding = new Padding(2);
            Text = "簡単計算プログラム";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input1TextBox;
        private Label plusLabel;
        private TextBox Input2TextBox;
        private Label equalLabel;
        private TextBox answerTextBox;
        private Button CalcButton;
        private Label errorLabel;
    }
}
