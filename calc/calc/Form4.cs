using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace calc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("veuillez remplir deux  champs, laisser vide (password) si pas de mot de passe pour mysql");
            }
            else
            {
                connectionclass.user = textBox1.Text;
                connectionclass.password = textBox2.Text;
                connectionclass.port = textBox3.Text;
                MessageBox.Show("appuyez sur rafraichir pour afficher les données");
                Dispose();
                Form4 forms = new Form4();
                forms.Close();
            }
        }
    }
}
