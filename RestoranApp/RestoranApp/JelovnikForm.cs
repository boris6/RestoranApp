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
    public partial class JelovnikForm : Form
    {
        public JelovnikForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Naziv = Convert.ToString(textBoxNaziv.Text);
            int Cena = Convert.ToInt32(textBoxCena.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PostojeciMeniForm f1 = new PostojeciMeniForm();
            f1.Show();
            this.Close();
        }
    }
}
