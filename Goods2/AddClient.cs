using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Goods2
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            comboBox1.Text = ""; comboBox2.Text = "";
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.ViewClientAdress' table. You can move, or remove it, as needed.
            this.viewClientAdressTableAdapter.Fill(this.kleinkindDataSet.ViewClientAdress);
            // TODO: This line of code loads data into the 'kleinkindDataSet.ViewClientName' table. You can move, or remove it, as needed.
            this.viewClientNameTableAdapter.Fill(this.kleinkindDataSet.ViewClientName);

        }

        public bool EventOK()
        {
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder connect =
               new SqlConnectionStringBuilder();
            connect.InitialCatalog = "kleinkind";
            connect.DataSource = @"ALEKSEY-PC";
            connect.ConnectTimeout = 30;
            connect.IntegratedSecurity = true;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    SqlCommand myCommand = new SqlCommand("Add_Client", cn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@Name", comboBox1.Text);
                    myCommand.Parameters.AddWithValue("@Adress", comboBox2.Text);
                    cn.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Протоколировать исключение
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Гарантировать освобождение подключения
                    cn.Close();
                }
            }
            comboBox1.Text = ""; comboBox2.Text = "";
            EventOK();
            EditClients main = this.Owner as EditClients;
            main.ReLoad();
            Close();
        }

    
    }
}
