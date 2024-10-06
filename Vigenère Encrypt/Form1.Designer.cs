namespace Vigenère_Encrypt
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(487, 12);
            button1.Name = "button1";
            button1.Size = new Size(162, 127);
            button1.TabIndex = 0;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(126, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(340, 49);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(12, 217);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(776, 221);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 27);
            textBox1.TabIndex = 7;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(1, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 8;
            label1.Text = "Plaintext";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(1, 70);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 9;
            label2.Text = "d (chỉ nhập số)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(313, 173);
            label3.Name = "label3";
            label3.Size = new Size(162, 38);
            label3.TabIndex = 10;
            label3.Text = "Cyphertext";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 27);
            textBox2.TabIndex = 11;
            // 
            // button3
            // 
            button3.ForeColor = Color.DarkGreen;
            button3.Location = new Point(1, 100);
            button3.Name = "button3";
            button3.Size = new Size(107, 51);
            button3.TabIndex = 13;
            button3.Text = "Random Key";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            ForeColor = Color.DarkGreen;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button3;
    }
}
