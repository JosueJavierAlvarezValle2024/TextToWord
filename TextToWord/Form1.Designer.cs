namespace TextToWord
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
            btnCreateWord = new Button();
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCreateWord
            // 
            btnCreateWord.Location = new Point(483, 192);
            btnCreateWord.Name = "btnCreateWord";
            btnCreateWord.Size = new Size(127, 71);
            btnCreateWord.TabIndex = 0;
            btnCreateWord.Text = "SAVE";
            btnCreateWord.UseVisualStyleBackColor = true;
            btnCreateWord.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(58, 88);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(310, 167);
            txtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 2;
            label1.Text = "Enter Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 152);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 3;
            label2.Text = "Press to button to save";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(665, 311);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(btnCreateWord);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateWord;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
    }
}
