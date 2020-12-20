using System;
using System.Data;
using System.Data.SqlClient;
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
            Hide();
            var f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connetionString =
                @"Data Source=BORA-HOME\SQLEXPRESS;Initial Catalog=RestoranApp;Trusted_Connection=True";
            var cnn = new SqlConnection(connetionString);


            try
            {
                var Naziv = Convert.ToString(textBoxNaziv.Text);
                var Cena = Convert.ToInt32(textBoxCena.Text);

                cnn.Open();


                var adapter = new SqlDataAdapter();

                var sql = "INSERT INTO Menu ([Name], [Price]) VALUES ('" + Naziv + "'," + Cena + ")";

                var command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();

                MessageBox.Show("Uspesno dodavanje", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Neuspesno dodavanje", "Neuspeh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxCena.Text = string.Empty;
                textBoxNaziv.Text = string.Empty;
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f1 = new PostojeciMeniForm();
            f1.Show();
            Close();
        }
    }
}