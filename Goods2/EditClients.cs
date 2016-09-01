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
    public partial class EditClients : Form
    {
        public EditClients()
        {
            InitializeComponent();
        }

        private void EditCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Clients' table. You can move, or remove it, as needed.
            this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddClient newForm = new AddClient();
            newForm.Owner = this;
            newForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int index = this.show_ClientsDataGridView.CurrentRow.Index;
            int value = Convert.ToInt32(show_ClientsDataGridView[0, index].Value);
            DelRow(value);
        }

        private void show_ClientsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                    SqlCommand myCommand = new SqlCommand("Edit_Client", cn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@ID", Convert.ToString(show_ClientsDataGridView[0, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Name", Convert.ToString(show_ClientsDataGridView[1, e.RowIndex].Value));
                    myCommand.Parameters.AddWithValue("@Adress", Convert.ToString(show_ClientsDataGridView[2, e.RowIndex].Value));
                    cn.Open();
                    myCommand.ExecuteNonQuery();
                    this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
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
                        SqlCommand myCommand = new SqlCommand("Del_Client", cn);
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@ID", value);

                        cn.Open();
                        myCommand.ExecuteNonQuery();
                        this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
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
               // this.show_ClientsBindingSource.RemoveCurrent();
            }
        }

        public void ReLoad()
        {
            this.Refresh();
            this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
            int k = show_ClientsDataGridView.Rows.Count;
            if (k > 5)
                show_ClientsDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
        }

        private void EditClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm m = this.Owner as StartForm;
            m.ReLoad_Clients();
        }
    }
}
