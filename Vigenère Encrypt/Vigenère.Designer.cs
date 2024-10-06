namespace Vigenère_Encrypt
{
    partial class Vigenère
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(449, 12);
            button1.Name = "button1";
            button1.Size = new Size(133, 124);
            button1.TabIndex = 0;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 221);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(359, 217);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(429, 221);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(359, 217);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(126, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 34);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 39);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 4;
            label1.Text = "KEY";
            // 
            // button2
            // 
            button2.Location = new Point(620, 12);
            button2.Name = "button2";
            button2.Size = new Size(133, 124);
            button2.TabIndex = 5;
            button2.Text = "Decrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Vigenère
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Vigenère";
            Text = "Vigenère";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}