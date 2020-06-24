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
using System.IO;

namespace calc
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                //Display query  
                string Query = "select message from minichat where message like '%" + textBox1.Text + "%';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
               // dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("veuillez remplir deux  champs");
            }
            else
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  

                    string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                    //This is my insert query in which i am taking input from the user through windows forms 
                    
                    string Query = "insert into minichat(pseudo,message) values(' " + textBox1.Text.Replace("'", "\\'") + "','" + textBox2.Text.Replace("'", "\\'") + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Insertion de la parole avec succée");
                   
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Dispose();
                Form3 form = new Form3();
                form.Close();
            }

           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("veuillez remplir deux  champs");
            }
            else
            {
                try
                {
                    //This is my connection string i have assigned the database file address path  

                    string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                    //This is my insert query in which i am taking input from the user through windows forms 

                    string Query = "insert into minichat(pseudo,message) values(' " + textBox1.Text.Replace("'", "\\'") + "','" + textBox2.Text.Replace("'", "\\'") + "');";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Insertion de la parole avec succée");

                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Dispose();
                Form3 form = new Form3();
                form.Close();
            }
        }
    }
}
