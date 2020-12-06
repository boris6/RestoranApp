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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesta_Click(object sender, EventArgs e)
        {
            FormMesta f1 = new FormMesta();
            f1.Show();
            this.Hide();

            

        }

        private void btnJelovnik_Click(object sender, EventArgs e)
        {

            JelovnikForm f2 = new JelovnikForm();
            f2.Show();
            this.Hide();
        }
            
 
        

        private void btnKonobari_Click(object sender, EventArgs e)
        {
            FormKonobari fr = new FormKonobari();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRestoran f3 = new FormRestoran();
            f3.Show();
            this.Hide();
        }
    }
}
