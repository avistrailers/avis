using System;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            do
            {
                progressBar1.Value = n;
                n++;
            } while (n < 100);

            textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
        }

        string hello()
        {
            return "Wilkommen!";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
