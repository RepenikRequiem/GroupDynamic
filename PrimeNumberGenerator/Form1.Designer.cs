namespace PrimeNumberGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // inputTextBox
            this.inputTextBox.Location = new System.Drawing.Point(20, 30);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(150, 20);

            // resultTextBox
            this.resultTextBox.Location = new System.Drawing.Point(20, 90);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(250, 50);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultTextBox.WordWrap = false;


            // generateButton
            this.generateButton.Location = new System.Drawing.Point(180, 25);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 30);
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);

            // clearButton
            this.clearButton.Location = new System.Drawing.Point(100, 150);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 30);
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);

            // label
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(220, 13);
            this.label.Text = "Введите номер простого числа (n > 0):";

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.label);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Генератор простых чисел";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
