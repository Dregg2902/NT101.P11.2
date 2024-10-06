using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenère_Encrypt
{
    public partial class Vigenère : Form
    {
        public Vigenère()
        {
            InitializeComponent();
        }
        // Hàm mã hóa Vigenère
        public static string Encrypt(string text, string key)
        {
            string result = "";
            key = key.ToUpper();
            int keyIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                // Kiểm tra nếu ký tự là chữ cái
                if (char.IsLetter(currentChar))
                {
                    bool isUpper = char.IsUpper(currentChar);
                    char offset = isUpper ? 'A' : 'a';
                    char keyChar = key[keyIndex % key.Length];

                    // Mã hóa ký tự bằng Vigenère
                    char encryptedChar = (char)((currentChar + keyChar - 2 * offset) % 26 + offset);
                    result += encryptedChar;

                    keyIndex++; // Chuyển sang ký tự tiếp theo trong từ khóa
                }
                else
                {
                    // Giữ nguyên ký tự nếu không phải là chữ cái
                    result += currentChar;
                }
            }

            return result;
        }

        // Hàm giải mã Vigenère
        public static string Decrypt(string cipherText, string key)
        {
            string result = "";
            key = key.ToUpper();
            int keyIndex = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                char currentChar = cipherText[i];

                if (char.IsLetter(currentChar))
                {
                    bool isUpper = char.IsUpper(currentChar);
                    char offset = isUpper ? 'A' : 'a';
                    char keyChar = key[keyIndex % key.Length];

                    // Giải mã ký tự bằng Vigenère
                    char decryptedChar = (char)((currentChar - keyChar + 26) % 26 + offset);
                    result += decryptedChar;

                    keyIndex++;
                }
                else
                {
                    result += currentChar;
                }
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Encrypt(richTextBox1.Text, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Decrypt(richTextBox1.Text, textBox1.Text);
        }
    }
}
