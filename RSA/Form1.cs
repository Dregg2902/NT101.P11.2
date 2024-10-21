using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi người dùng nhấn nút "Generate Keys"
        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            try
            {
                BigInteger p, q, ee;
                int i = 0;

                // Kiểm tra nếu người dùng không nhập p, q thì tự động sinh ra
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    p = GenerateRandomPrime();
                    textBox1.Text = p.ToString();
                    q = GenerateRandomPrime();
                    textBox2 .Text = q.ToString();
                    ee = 65537; // Giá trị thường dùng cho e
                    textBox3.Text = ee.ToString();
                }
                else
                {
                    p = BigInteger.Parse(textBox1.Text);
                    q = BigInteger.Parse(textBox2.Text);  
                    if (IsProbablePrime(p, 100) == false)
                    {
                        richTextBox1.Text += "p không phải là số nguyên tố \r\n";
                        i++;
                    }
                    if (IsProbablePrime(q, 100) == false)
                    {
                        richTextBox1.Text += "q không phải là số nguyên tố";
                        i++;
                    }
                    if (string.IsNullOrWhiteSpace(textBox3.Text) || !BigInteger.TryParse(textBox3.Text, out ee))
                    {
                        throw new ArgumentException("E must be a valid integer.");
                    }
                }
                if (i == 0)
                {
                    var keys = GenerateRSAKeys(p, q, ee);
                    txtPublicKey.Text = $"Public Key (e, n): ({keys.PublicKey.e}, {keys.PublicKey.n})";
                    txtPrivateKey.Text = $"Private Key (d, n): ({keys.PrivateKey.d}, {keys.PrivateKey.n})";

                    txtModulus.Text = keys.PublicKey.n.ToString();
                    textBox4.Text = ee.ToString();
                    textBox5.Text = keys.PrivateKey.d.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Hàm tạo khóa RSA từ p, q và e
        private (PublicKey PublicKey, PrivateKey PrivateKey) GenerateRSAKeys(BigInteger p, BigInteger q, BigInteger e)
        {
            BigInteger n = p * q;
            BigInteger phi = (p - 1) * (q - 1);
            BigInteger d = ModInverse(e, phi);
            return (new PublicKey(e, n), new PrivateKey(d, n));
        }

        private BigInteger GenerateRandomPrime()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                while (true)
                {
                    Random a = new Random();
                    int b;
                    b=a.Next(1,15);
                    byte[] bytes = new byte[b];
                    rng.GetBytes(bytes);
                    BigInteger randomNum = BigInteger.Abs(new BigInteger(bytes));

                    if (IsProbablePrime(randomNum,100))
                    {
                        return randomNum;
                    }
                }
            }
        }

        public bool IsProbablePrime(BigInteger source, int certainty)
        {
            if (source == 2 || source == 3)
                return true;
            if (source < 2 || source % 2 == 0)
                return false;

            BigInteger d = source - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[source.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= source - 2);

                BigInteger x = BigInteger.ModPow(a, d, source);
                if (x == 1 || x == source - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1)
                        return false;
                    if (x == source - 1)
                        break;
                }

                if (x != source - 1)
                    return false;
            }

            return true;
        }

            private BigInteger BigIntegerSqrt(BigInteger number)
        {
            if (number == 0) return 0;
            if (number > 0)
            {
                BigInteger n = (number / 2) + 1;
                BigInteger n1 = (n + (number / n)) / 2;
                while (n1 < n)
                {
                    n = n1;
                    n1 = (n + (number / n)) / 2;
                }
                return n;
            }
            throw new ArgumentException("Negative argument.");
        }

        private BigInteger ModInverse(BigInteger e, BigInteger phi)
        {
            BigInteger t = 0, newT = 1;
            BigInteger r = phi, newR = e;
            while (newR != 0)
            {
                BigInteger quotient = r / newR;

                (t, newT) = (newT, t - quotient * newT);
                (r, newR) = (newR, r - quotient * newR);
            }
            if (r > 1) throw new ArgumentException("E has no modular inverse.");
            if (t < 0) t += phi;
            return t;
        }

        // Hàm mã hóa chuỗi
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessage.Text;

                // Chuyển đổi chuỗi thành các giá trị số nguyên
                BigInteger publicKey = BigInteger.Parse(textBox4.Text);
                BigInteger modulus = BigInteger.Parse(txtModulus.Text);

                // Mã hóa thông điệp
                string encryptedMessage = Encrypt(message, publicKey, modulus);
                richTextBox1.Text = encryptedMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in encryption: " + ex.Message);
            }
        }

        // Hàm giải mã chuỗi
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string encryptedMessage = richTextBox1.Text;

                BigInteger privateKey = BigInteger.Parse(textBox5.Text);
                BigInteger modulus = BigInteger.Parse(txtModulus.Text);

                // Giải mã thông điệp
                string decryptedMessage = Decrypt(encryptedMessage, privateKey, modulus);
                MessageBox.Show("Decrypted Message: " + decryptedMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in decryption: " + ex.Message);
            }
        }

        // Hàm mã hóa
        private string Encrypt(string message, BigInteger publicKey, BigInteger modulus)
        {
            StringBuilder encryptedValues = new StringBuilder();

            // Mã hóa từng ký tự
            foreach (char c in message)
            {
                BigInteger m = (BigInteger)c; // Mã ASCII của ký tự
                BigInteger cEncrypted = BigInteger.ModPow(m, publicKey, modulus); // Mã hóa
                encryptedValues.Append(cEncrypted.ToString() + " "); // Thêm vào chuỗi kết quả
            }

            return encryptedValues.ToString().Trim(); // Trả về chuỗi thập phân
        }

        // Hàm giải mã
        private string Decrypt(string encryptedMessage, BigInteger privateKey, BigInteger modulus)
        {
            StringBuilder decryptedMessage = new StringBuilder();

            // Chia tách các giá trị mã hóa
            string[] encryptedValues = encryptedMessage.Split(' ');

            // Giải mã từng giá trị
            foreach (string value in encryptedValues)
            {
                if (BigInteger.TryParse(value, out BigInteger cEncrypted))
                {
                    BigInteger mDecrypted = BigInteger.ModPow(cEncrypted, privateKey, modulus); // Giải mã
                    decryptedMessage.Append((char)mDecrypted); // Chuyển đổi về ký tự
                }
            }

            return decryptedMessage.ToString(); // Trả về thông điệp đã giải mã
        }

        public class PublicKey
        {
            public BigInteger e { get; }
            public BigInteger n { get; }

            public PublicKey(BigInteger e, BigInteger n)
            {
                this.e = e;
                this.n = n;
            }
        }

        public class PrivateKey
        {
            public BigInteger d { get; }
            public BigInteger n { get; }

            public PrivateKey(BigInteger d, BigInteger n)
            {
                this.d = d;
                this.n = n;
            }
        }
    }
}
