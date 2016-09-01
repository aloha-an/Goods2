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
    public partial class AddSale : Form
    {
        private int goodsIndexRow;
        private int clientsIndexRow;
        public AddSale()
        {
            InitializeComponent();
            goodsIndexRow = -1;
            clientsIndexRow = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Clients' table. You can move, or remove it, as needed.
            this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Goods' table. You can move, or remove it, as needed.
            this.show_GoodsTableAdapter.Fill(this.kleinkindDataSet.Show_Goods);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClient newForm = new AddClient();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (goodsIndexRow == -1)
            {
                if (show_GoodsDataGridView.RowCount == 0)
                    MessageBox.Show("Как можно продавать, ничего не купив?");
                else
                    MessageBox.Show("Вы не выбрали товар");
                return;
            }

            if (clientsIndexRow == -1)
            {
                if (show_ClientsDataGridView.RowCount == 0)
                    MessageBox.Show("У вас еще нет клиентов");
                else
                    MessageBox.Show("Вы не выбрали клиента");
                return;
            }
            SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();
            connect.InitialCatalog = "kleinkind";
            connect.DataSource = @"ALEKSEY-PC";
            connect.ConnectTimeout = 30;
            connect.IntegratedSecurity = true;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    SqlCommand myCommand = new SqlCommand("Add_Sale", cn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@Goods", goodsIndexRow);
                    myCommand.Parameters.AddWithValue("@Counts", Convert.ToInt32(textBox1.Text));
                    myCommand.Parameters.AddWithValue("@PriceUA", Convert.ToDecimal(textBox2.Text));
                    myCommand.Parameters.AddWithValue("@Client", clientsIndexRow);
                    myCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    cn.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Вы ввели некорректные данные");
                }
                finally
                {
                    cn.Close();
                }
            }
            textBox1.Text = ""; textBox2.Text = ""; dateTimePicker1.Value = DateTime.Now;
            EditSale main = this.Owner as EditSale;
            main.ReLoad();
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // DateTime date = dateTimePicker1.Value.Date.ToShortDateString();
            //  dateTimePicker1.Format="yyyy/mm/dd";
            //dateTimePicker1.CustomFormat = ("yyyy/MM/dd");
            //  textBox1.Text = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
                    }
        public void ReLoad()
        {
            this.Refresh();
            this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
            int k = show_ClientsDataGridView.Rows.Count;
            if (k > 5)
                show_ClientsDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
            clientsIndexRow = show_ClientsDataGridView.RowCount - 1;
        }

        private void show_GoodsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            goodsIndexRow = Convert.ToInt32(show_GoodsDataGridView[0, show_GoodsDataGridView.CurrentRow.Index].Value);
        }

        private void show_ClientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clientsIndexRow = Convert.ToInt32(show_ClientsDataGridView[0, show_ClientsDataGridView.CurrentRow.Index].Value);
        }
    }
}
