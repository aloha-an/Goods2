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
    public partial class EditSale : Form
    {
        public EditSale()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddSale newForm = new AddSale();
            newForm.Owner = this;
            newForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int index = this.show_SaleDataGridView.CurrentRow.Index;
            int value = Convert.ToInt32(show_SaleDataGridView[0, index].Value);
            DelRow(value);
        }

        public void ReLoad()
        {
            this.Refresh();
            this.show_SaleTableAdapter.Fill(this.kleinkindDataSet.Show_Sale, "1900-01-01", "2050-12-31");
            int k = show_SaleDataGridView.Rows.Count;
            if (k > 5)
                show_SaleDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
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
                        SqlCommand myCommand = new SqlCommand("Del_Sale", cn);
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@ID", value);
                        
                        cn.Open();
                        myCommand.ExecuteNonQuery();
                        this.show_SaleTableAdapter.Fill(this.kleinkindDataSet.Show_Sale, "1900-01-01", "2050-12-31");
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
               // this.show_SaleBindingSource.RemoveCurrent();
            }
        }

        private void EditSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm m = this.Owner as StartForm;
            m.ReLoad_Sale();
        }


    }
}
