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
    public partial class EditGoods : Form
    {
        public EditGoods()
        {
            InitializeComponent();
        }

        private void Edit_Goods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Goods' table. You can move, or remove it, as needed.
            this.show_GoodsTableAdapter1.Fill(this.kleinkindDataSet.Show_Goods);
        }

        private void show_GoodsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
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
                    //Открыть подключение
                    // Создание объекта команды с помощью конструктора
                    SqlCommand myCommand = new SqlCommand("Edit_Goods", cn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@ID", Convert.ToString(show_GoodsDataGridView1[0, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Name", Convert.ToString(show_GoodsDataGridView1[1, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Category", Convert.ToString(show_GoodsDataGridView1[2, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Color", Convert.ToString(show_GoodsDataGridView1[3, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Size", Convert.ToString(show_GoodsDataGridView1[4, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Count", Convert.ToInt32(show_GoodsDataGridView1[5, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Unit", Convert.ToString(show_GoodsDataGridView1[6, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Link", Convert.ToString(show_GoodsDataGridView1[7, e.RowIndex].Value));
                    cn.Open();
                    myCommand.ExecuteNonQuery();
                    this.show_GoodsTableAdapter1.Fill(this.kleinkindDataSet.Show_Goods);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Некорректно введены данные");
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public void ReLoad()
        {
            this.Refresh();
            this.show_GoodsTableAdapter1.Fill(this.kleinkindDataSet.Show_Goods);
            int k = show_GoodsDataGridView1.Rows.Count;
            if (k > 5)
                show_GoodsDataGridView1.FirstDisplayedScrollingRowIndex = (k - 5);
        }

        private void DelRow(int value)
        {
            SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();
            connect.InitialCatalog = "kleinkind";
            connect.DataSource = @"ALEKSEY-PC";
            connect.ConnectTimeout = 30;
            connect.IntegratedSecurity = true;
            if (MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = connect.ConnectionString;
                    try
                    {
                        //Открыть подключение
                        // Создание объекта команды с помощью конструктора
                        SqlCommand myCommand = new SqlCommand("Del_Goods", cn);
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@ID", value);
                        
                        cn.Open();
                        myCommand.ExecuteNonQuery();
                        this.show_GoodsTableAdapter1.Fill(this.kleinkindDataSet.Show_Goods);
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
               // this.show_GoodsBindingSource1.RemoveCurrent();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddGoods newForm = new AddGoods();
            newForm.Owner = this;
            newForm.Show();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int index = this.show_GoodsDataGridView1.CurrentRow.Index;
            int value = Convert.ToInt32(show_GoodsDataGridView1[0, index].Value);
            DelRow(value);
        }

        private void EditGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm m = this.Owner as StartForm;
            m.ReLoad_Goods();
        }
    }
}
