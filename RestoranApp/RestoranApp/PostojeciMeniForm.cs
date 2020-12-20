using System;
using System.Windows.Forms;

namespace RestoranApp
{
    public partial class PostojeciMeniForm : Form
    {
        public PostojeciMeniForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var f2 = new JelovnikForm();
            f2.Show();
        }

        private void PostojeciMeniForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoranAppDataSet.Menu' table. You can move, or remove it, as needed.
            menuTableAdapter.Fill(restoranAppDataSet.Menu);
        }
    }
}