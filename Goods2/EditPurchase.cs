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
    public partial class EditPurchase : Form
    {
        public EditPurchase()
        {
            InitializeComponent();
        }

        private void EditPurchase_Load(object sender, EventArgs e)
        {
            this.show_PurchaseTableAdapter.Fill(this.kleinkindDataSet.Show_Purchase, "1900-01-01", "2050-12-31");
        }
        private void EditPurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm m = this.Owner as StartForm;
            m.ReLoad_Purchase();
        }

        public void ReLoad()
        {
            this.Refresh();
            this.show_PurchaseTableAdapter.Fill(this.kleinkindDataSet.Show_Purchase, "1900-01-01", "2050-12-31");
            int k = show_PurchaseDataGridView.Rows.Count;
            if (k > 5)
                show_PurchaseDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
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
                        SqlCommand myCommand = new SqlCommand("Del_Purchase", cn);
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@ID", value);

                        cn.Open();
                        myCommand.ExecuteNonQuery();
                        this.show_PurchaseTableAdapter.Fill(this.kleinkindDataSet.Show_Purchase, "1900-01-01", "2050-12-31");
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
              //  this.show_PurchaseBindingSource.RemoveCurrent();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddPurchase newForm = new AddPurchase();
            newForm.Owner = this;
            newForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int index = this.show_PurchaseDataGridView.CurrentRow.Index;
            int value = Convert.ToInt32(show_PurchaseDataGridView[0, index].Value);
            DelRow(value);
        }
    }
}
