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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox2.Text = Chansonclass.chansons;
            textBox1.Text = Chansonclass.chanteur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("veuillez ne pas laisser des champs vides");
            }
            else
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                    //This is my update query in which i am taking input from the user through windows forms and update the record. 
                     
                    string Query = "update minichat set pseudo='" + textBox1.Text.Replace("'", "\\'") + "',message='" +   textBox2.Text.Replace("'", "\\'") + "'where id='" + Chansonclass.id + "';";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Donnée mise à jour\n Appuiez sur rafrachir pour voir le changement");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();//Connection closed here 
                    Form5 form = new Form5();
                    form.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Dispose();
                Form5 forms = new Form5();
                forms.Close();
            }
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("veuillez ne pas laisser des champs vides");
            }
            else
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                    //This is my update query in which i am taking input from the user through windows forms and update the record. 

                    string Query = "update minichat set pseudo='" + textBox1.Text.Replace("'", "\\'") + "',message='" + textBox2.Text.Replace("'", "\\'") + "'where id='" + Chansonclass.id + "';";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Donnée mise à jour\n Appuiez sur rafrachir pour voir le changement");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();//Connection closed here 
                    Form5 form = new Form5();
                    form.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Dispose();
                Form5 forms = new Form5();
                forms.Close();
            }
        }
    }
}
