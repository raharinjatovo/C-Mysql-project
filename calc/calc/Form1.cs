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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                string MyConnection2 = "database=test;datasource=localhost;port="+connectionclass.port+";username="+connectionclass.user+";password="+connectionclass.password+"";
                //Display query  
                string Query = "select id,pseudo,message from minichat;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                // dataGridView1.DataSource = dTable;
                dataGridView1.RowTemplate­.Height = 30;
                dataGridView1.DataSource = dTable;
                dataGridView1.AllowUserTo­AddRows = false;
                dataGridView1.AutoSizeCol­umnsMode = DataGridViewAutoSize­ColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sientificToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    

                }
            }

            //textBox1.Text=listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                
                string value2 = row.Cells[1].Value.ToString();
                //...
                
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forms = new Form2();
            forms.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            label11.Text= selectedRow.Cells[0].Value.ToString();
            //label10.Text= selectedRow.Cells[0].Value.ToString();
            textBox3.Text= selectedRow.Cells[1].Value.ToString();
            textBox1.Text = selectedRow.Cells[2].Value.ToString();

        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 forms1 = new Form3();
            forms1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ContentClick(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(label11.Text))
            {
                MessageBox.Show("veuillez selectionner une chansons");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Voulez-vous  vraiment supprimer :'"+ textBox3.Text+ "'", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    try
                    {
                        string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                        string Query = "delete  from minichat where id='" + this.label11.Text + "';";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("La Chanson a été supprimée avec succès");
                        try
                        {
                            string MyConnection1 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                            //Display query  
                            string Query1 = "select id,pseudo,message from minichat;";
                            MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                            MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                            //  MyConn2.Open();  
                            //For offline connection we weill use  MySqlDataAdapter class.  
                            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                            MyAdapter.SelectCommand = MyCommand1;
                            DataTable dTable = new DataTable();
                            MyAdapter.Fill(dTable);
                            // dataGridView1.DataSource = dTable;
                            dataGridView1.RowTemplate­.Height = 30;
                            dataGridView1.DataSource = dTable;
                            dataGridView1.AllowUserTo­AddRows = false;
                            dataGridView1.AutoSizeCol­umnsMode = DataGridViewAutoSize­ColumnsMode.Fill;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           // connectionclass.user = textBox2.Text;
            Form2 forms = new Form2();
            forms.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 forms = new Form4();
            forms.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
            //Display query  
            string Query = "select id,pseudo,message from minichat;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
           // dataGridView1.DataSource = dTable;
            dataGridView1.RowTemplate­.Height = 30;
            dataGridView1.DataSource = dTable;
            dataGridView1.AllowUserTo­AddRows = false;
            dataGridView1.AutoSizeCol­umnsMode = DataGridViewAutoSize­ColumnsMode.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(label11.Text)|| string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("veuillez selectionner une chansons");
            }
            else
            {
                Chansonclass.chansons = textBox1.Text;
                Chansonclass.chanteur = textBox3.Text;
                Chansonclass.id = label11.Text;
                Form5 forms = new Form5();
                forms.ShowDialog();
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Voulez-vous quitter Tononkira Advantista?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
            else e.Cancel = true;

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Voulez-vous quitter Tononkira Advantista?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
            else
            {
              
            }
        }

        private void receToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 forms = new Form2();
            forms.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(label11.Text))
            {
                MessageBox.Show("veuillez selectionner une chansons");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Voulez-vous  vraiment supprimer :'" + textBox3.Text + "'", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    try
                    {
                        string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
                        string Query = "delete  from minichat where id='" + this.label11.Text + "';";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("La Chanson a été supprimée avec succès");
                        MessageBox.Show("Appuiez sur le boutton rafraichir pour voir le changement");

                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void editerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(label11.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("veuillez selectionner une chansons");
            }
            else
            {
                Chansonclass.chansons = textBox1.Text;
                Chansonclass.chanteur = textBox3.Text;
                Chansonclass.id = label11.Text;
                Form5 forms = new Form5();
                forms.ShowDialog();
            }
        }

        private void rafraichirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "database=test;datasource=localhost;port=" + connectionclass.port + ";username=" + connectionclass.user + ";password=" + connectionclass.password + "";
            //Display query  
            string Query = "select id,pseudo,message from minichat;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //  MyConn2.Open();  
            //For offline connection we weill use  MySqlDataAdapter class.  
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void editerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void aideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Aide aide = new Aide();
            aide.ShowDialog();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
        }
    }
}
