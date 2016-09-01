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
    public partial class AddPurchase : Form
    {
        private int goodsIndexRow;
        public AddPurchase()
        {
            goodsIndexRow = -1;
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Goods' table. You can move, or remove it, as needed.
            this.show_GoodsTableAdapter.Fill(this.kleinkindDataSet.Show_Goods);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGoods newForm = new AddGoods();
            newForm.Owner = this;
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (goodsIndexRow == -1)
            {
                if (show_GoodsDataGridView.RowCount == 0)
                    MessageBox.Show("Добавьте товар");
                else
                    MessageBox.Show("Вы не выбрали товар");
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
                    SqlCommand myCommand = new SqlCommand("Add_Purchase", cn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@Goods", goodsIndexRow);
                    myCommand.Parameters.AddWithValue("@Counts", Convert.ToInt32(textBox1.Text));
                    myCommand.Parameters.AddWithValue("@PriceUS", Convert.ToDecimal(textBox2.Text));
                    myCommand.Parameters.AddWithValue("@Exchange", Convert.ToDecimal(textBox3.Text));
                    myCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                    cn.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                 catch(FormatException)
                {
                    MessageBox.Show("Вы ввели некорректные данные");
                }
                finally
                {
                    cn.Close();
                }
            }
            textBox1.Text = ""; textBox2.Text = ""; dateTimePicker1.Value=DateTime.Now;
            EditPurchase main = this.Owner as EditPurchase;
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
            this.show_GoodsTableAdapter.Fill(this.kleinkindDataSet.Show_Goods);
            int k = show_GoodsDataGridView.Rows.Count;
            if (k > 5)
                show_GoodsDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
            goodsIndexRow = show_GoodsDataGridView.RowCount - 1;
        }

        private void show_GoodsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            goodsIndexRow=Convert.ToInt32(show_GoodsDataGridView[0,show_GoodsDataGridView.CurrentRow.Index].Value);
        }
    }
}
