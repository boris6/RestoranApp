using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranApp
{
    public partial class FormKonobari : Form
    {
        public FormKonobari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = Convert.ToString(textBox1.Text);
            string LastName = Convert.ToString(textBox2.Text);
            int jmbg = Convert.ToInt32(textBox3.Text);
        }
    }
}
