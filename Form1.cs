using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace travelTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 8 || !textBox3.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            string haradan = comboBox1.Text;
            string haraya = comboBox2.Text;
            string adSoyad = textBox1.Text;
            string telefon = maskedTextBox2.Text;
            string tarix = maskedTextBox1.Text;
            string saat = maskedTextBox3.Text;
            string yer = textBox1.Text;
            string seriya = textBox2.Text;
            string email = textBox3.Text;

            if (haradan == "" || haraya == "" || adSoyad == "")
            {
                MessageBox.Show("Zehmet olmasa bütün vacib xanalari doldurun!", "Xeberdarlq");

            }
            listBox1.Items.Add("Yeni bilet sifarisi:");
            listBox1.Items.Add("Marsrut: " + haradan + " ? " + haraya);
            listBox1.Items.Add("Tarix v? saat: " + tarix + " | " + saat);
            listBox1.Items.Add("Yer: " + yer);
            listBox1.Items.Add("Ad Soyad: " + adSoyad);
            listBox1.Items.Add("S?n?d nömr?si: " + seriya);
            listBox1.Items.Add("Telefon: " + telefon);
            listBox1.Items.Add("Email: " + email);
            listBox1.Items.Add("----------------------------");

            MessageBox.Show("Bilet m?lumatlari siyahiya elav? olundu.", "Ugurlu emeliyyat");
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
