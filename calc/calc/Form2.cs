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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            string myStr = selectedRow.Cells[1].Value.ToString();
            myStr = myStr.Replace("\n", Environment.NewLine);
            textBox2.Text = myStr;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
           // label1.Text = connectionclass.user;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Veuillez entrer le mot clé");
            }
            else
            {
                try
                {
                    string MyConnection2 = "database=test;datasource=localhost;port=3306;username=root;password=";
                    //Display query  
                    string Query = "select pseudo,message from minichat where message like '%" + textBox1.Text + "%';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    //  MyConn2.Open();  
                    //For offline connection we weill use  MySqlDataAdapter class.  
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand2;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    dataGridView1.RowTemplate­.Height = 30;
                    dataGridView1.DataSource = dTable;
                    dataGridView1.AllowUserTo­AddRows = false;
                    dataGridView1.AutoSizeCol­umnsMode = DataGridViewAutoSize­ColumnsMode.Fill;
                    // here i have assign dTable object to the dataGridView1 object to display data.               
                    // MyConn2.Close();  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Veuillez entrer le mot clé");
            }
            else
            {
                try
                {
                    string MyConnection2 = "database=test;datasource=localhost;port=3306;username=root;password=";
                    //Display query  
                    string Query = "select pseudo,message from minichat where pseudo like '%" + textBox1.Text + "%';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    //  MyConn2.Open();  
                    //For offline connection we weill use  MySqlDataAdapter class.  
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand2;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    dataGridView1.RowTemplate­.Height = 30;
                    dataGridView1.DataSource = dTable;
                    dataGridView1.AllowUserTo­AddRows = false;
                    dataGridView1.AutoSizeCol­umnsMode = DataGridViewAutoSize­ColumnsMode.Fill;
                    // here i have assign dTable object to the dataGridView1 object to display data.               
                    // MyConn2.Close();  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
