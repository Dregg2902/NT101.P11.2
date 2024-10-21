namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        private void InitializeComponent()
        {
            lblMessage = new Label();
            txtMessage = new TextBox();
            btnEncrypt = new Button();
            lblEncryptedMessage = new Label();
            btnDecrypt = new Button();
            lblPublicKey = new Label();
            txtPublicKey = new TextBox();
            lblPrivateKey = new Label();
            txtPrivateKey = new TextBox();
            lblModulus = new Label();
            txtModulus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(12, 18);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(108, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Input Message:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(126, 18);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(349, 50);
            txtMessage.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(142, 358);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(132, 60);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // lblEncryptedMessage
            // 
            lblEncryptedMessage.AutoSize = true;
            lblEncryptedMessage.Location = new Point(546, 148);
            lblEncryptedMessage.Name = "lblEncryptedMessage";
            lblEncryptedMessage.Size = new Size(140, 20);
            lblEncryptedMessage.TabIndex = 3;
            lblEncryptedMessage.Text = "Encrypted Message:";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(289, 358);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(132, 60);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // lblPublicKey
            // 
            lblPublicKey.AutoSize = true;
            lblPublicKey.Location = new Point(12, 152);
            lblPublicKey.Name = "lblPublicKey";
            lblPublicKey.Size = new Size(80, 20);
            lblPublicKey.TabIndex = 6;
            lblPublicKey.Text = "Public Key:";
            // 
            // txtPublicKey
            // 
            txtPublicKey.Location = new Point(107, 145);
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.ReadOnly = true;
            txtPublicKey.Size = new Size(345, 27);
            txtPublicKey.TabIndex = 7;
            // 
            // lblPrivateKey
            // 
            lblPrivateKey.AutoSize = true;
            lblPrivateKey.Location = new Point(12, 183);
            lblPrivateKey.Name = "lblPrivateKey";
            lblPrivateKey.Size = new Size(85, 20);
            lblPrivateKey.TabIndex = 8;
            lblPrivateKey.Text = "Private Key:";
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Location = new Point(107, 180);
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.ReadOnly = true;
            txtPrivateKey.Size = new Size(345, 27);
            txtPrivateKey.TabIndex = 9;
            // 
            // lblModulus
            // 
            lblModulus.AutoSize = true;
            lblModulus.Location = new Point(12, 220);
            lblModulus.Name = "lblModulus";
            lblModulus.Size = new Size(69, 20);
            lblModulus.TabIndex = 10;
            lblModulus.Text = "Modulus:";
            // 
            // txtModulus
            // 
            txtModulus.Location = new Point(107, 213);
            txtModulus.Name = "txtModulus";
            txtModulus.ReadOnly = true;
            txtModulus.Size = new Size(345, 27);
            txtModulus.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 21);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 12;
            label1.Text = "p";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 61);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 13;
            label2.Text = "q";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 100);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 14;
            label3.Text = "e";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(570, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(570, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(570, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(726, 21);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Create_Key";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGenerateKeys_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(107, 246);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(345, 27);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 253);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 20;
            label4.Text = "e";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(107, 279);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(345, 27);
            textBox5.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 286);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 22;
            label5.Text = "d";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(546, 171);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(644, 319);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            ClientSize = new Size(1202, 495);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtModulus);
            Controls.Add(lblModulus);
            Controls.Add(txtPrivateKey);
            Controls.Add(lblPrivateKey);
            Controls.Add(txtPublicKey);
            Controls.Add(lblPublicKey);
            Controls.Add(btnDecrypt);
            Controls.Add(lblEncryptedMessage);
            Controls.Add(btnEncrypt);
            Controls.Add(txtMessage);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "RSA Encryption/Decryption";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblEncryptedMessage;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblModulus;
        private System.Windows.Forms.TextBox txtModulus;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private RichTextBox richTextBox1;
    }
}
