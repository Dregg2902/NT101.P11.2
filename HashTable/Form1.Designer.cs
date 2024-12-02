namespace HashTable
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(227, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(695, 112);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 3);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "Input";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(3, 46);
            button1.Name = "button1";
            button1.Size = new Size(171, 32);
            button1.TabIndex = 2;
            button1.Text = "Load file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Text String", "Hex String", "File" });
            comboBox1.Location = new Point(3, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Text String";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(3, 80);
            button2.Name = "button2";
            button2.Size = new Size(171, 32);
            button2.TabIndex = 4;
            button2.Text = "HASH";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(100, 173);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(822, 112);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(100, 291);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(822, 112);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(100, 409);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(822, 112);
            richTextBox4.TabIndex = 7;
            richTextBox4.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 213);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 8;
            label2.Text = "MD5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 338);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 9;
            label3.Text = "SHA-1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 445);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 10;
            label4.Text = "SHA-256";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 524);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
