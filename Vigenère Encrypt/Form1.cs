namespace Vigenère_Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string text = "";
        string key = " ";

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            text = richTextBox1.Text;
            int n = int.Parse(textBox1.Text);
            for (int i = 0;i < text.Length; i = i + n) 
            {
                string chuoicat = "";
                if (i+n < text.Length) { chuoicat= text.Substring(i,n); }
                else 
                { 
                    chuoicat = text.Substring(i,text.Length-i);
                    string spaces = new string(' ', n-(text.Length-i));
                    chuoicat += spaces;
                }
                string[] so = textBox2.Text.Split(',');
                int[] positions = new int[so.Length];
                for (int j = 0;j< so.Length; j++)
                {
                    positions[j] = int.Parse(so[j]);
                } 
                // Tạo chuỗi mới với các ký tự được hoán đổi
                char[] newString = new char[positions.Length];

                // Hoán đổi vị trí ký tự trong originalString
                for (int j = 0; j < positions.Length; j++)
                {
                    // positions[i] - 1 vì mảng bắt đầu từ 0, trong khi chuỗi của chúng ta bắt đầu từ 1
                    newString[j] = chuoicat[positions[j]-1];
                }
                // Chuyển đổi mảng ký tự trở lại thành chuỗi
                string result = new string(newString);
                richTextBox3.Text += "|"+result;
            }
            richTextBox3.Text += "|";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            List<int> numbers = Enumerable.Range(1, n).ToList();

            // Xáo trộn danh sách
            Random random = new Random();
            for (int i = numbers.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                // Hoán đổi vị trí i và j
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            // Chuyển danh sách thành chuỗi
            string result = string.Join(",", numbers);
            textBox2.Text = result;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Hủy sự kiện nếu ký tự không hợp lệ
            }
        }
    }
}
