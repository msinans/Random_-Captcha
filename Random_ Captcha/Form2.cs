using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random__Captcha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "x", "y", "z", "q", "t", "w", "j" };
            string[] sembol3 = { "A", "B", "C", "D", "E", "F", "G" };
            string[] sembol5 = { "&", "^", "£", "₺", "$" };

            Random rnd = new Random();
            int s1, s2, s3, s4, s5;
            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, 6);
            s3 = rnd.Next(0, sembol3.Length);
            s4 = rnd.Next(5, 11);
            s5 = rnd.Next(0, sembol5.Length);

            label1.Text = sembol1[s1] + s2.ToString() + sembol3[s3] + s4.ToString() + sembol5[s5];

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
                MessageBox.Show("Giriş Doğru Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("Hatalı Giriş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
