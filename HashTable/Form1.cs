using System.Security.Cryptography;
using System.Text;

namespace HashTable
{
    public partial class Form1 : Form
    {
        public static string ComputeMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Hàm tính giá trị băm SHA-1
        public static string ComputeSHA1(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Hàm tính giá trị băm SHA-256 (SHA-2)
        public static string ComputeSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        public static string AddSpaceEveryTwoCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Sử dụng StringBuilder để tối ưu hóa hiệu suất khi xử lý chuỗi
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);

                // Thêm dấu cách sau mỗi 2 ký tự, trừ khi là ký tự cuối cùng
                if ((i + 1) % 2 == 0 && i != input.Length - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }
        public static string HexStringToText(string hex)
        {
            // Kiểm tra chuỗi hex có hợp lệ không
            if (string.IsNullOrEmpty(hex) || hex.Length % 2 != 0)
                throw new ArgumentException("Chuỗi hex không hợp lệ!");

            // Chuyển từng cặp ký tự hex thành byte
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            // Chuyển mảng byte thành chuỗi văn bản
            return Encoding.UTF8.GetString(bytes);
        }
        static byte[] input = new byte[999];
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "File")
            {
                richTextBox1.ReadOnly = true;
                button1.Enabled = true;
            }
            else
            {
                richTextBox1.ReadOnly = false;
                button1.Enabled = false;
            }
            richTextBox1.Text = "";
        }
        public static string OpenAndReadFile()
        {
            // Tạo hộp thoại OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn file để đọc",
                Filter = "Tất cả các file (*.*)|*.*|File văn bản (*.txt)|*.txt",
                FilterIndex = 1,
                Multiselect = false // Không cho phép chọn nhiều file
            };

            // Hiển thị hộp thoại và kiểm tra người dùng có chọn file không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Console.WriteLine($"Đã chọn file: {filePath}");
                
                try
                {
                    // Đọc và trả về nội dung file
                    input = File.ReadAllBytes(filePath); 
                    return File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Không có file nào được chọn.");
                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Text String")
            {
                string a = richTextBox1.Text;
                richTextBox2.Text = AddSpaceEveryTwoCharacters(ComputeMD5(a).ToUpper());
                richTextBox3.Text = AddSpaceEveryTwoCharacters(ComputeSHA1(a).ToUpper());
                richTextBox4.Text = AddSpaceEveryTwoCharacters(ComputeSHA256(a).ToUpper());
            }
            else if (comboBox1.Text == "Hex String")
            {
                //string a = HexStringToText(richTextBox1.Text);
                string a = richTextBox1.Text;
                string b, c, d;
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(a);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    b = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(a);
                    byte[] hashBytes = sha1.ComputeHash(inputBytes);
                    c = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(a);
                    byte[] hashBytes =  sha256.ComputeHash(inputBytes);
                    d = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
                richTextBox2.Text = AddSpaceEveryTwoCharacters(b.ToUpper());
                richTextBox3.Text = AddSpaceEveryTwoCharacters(c.ToUpper());
                richTextBox4.Text = AddSpaceEveryTwoCharacters(d.ToUpper());
            }
            else if(comboBox1.Text == "File")
            {
                string a = richTextBox1.Text;
                string b, c, d;
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = input;
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    b = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] inputBytes = input;
                    byte[] hashBytes = sha1.ComputeHash(inputBytes);
                    c = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = input;
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    d = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
                richTextBox2.Text = AddSpaceEveryTwoCharacters(b.ToUpper());
                richTextBox3.Text = AddSpaceEveryTwoCharacters(c.ToUpper());
                richTextBox4.Text = AddSpaceEveryTwoCharacters(d.ToUpper());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = OpenAndReadFile();

        }
    }
}
