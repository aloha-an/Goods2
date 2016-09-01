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
    public partial class AddGoods : Form
    {
        public AddGoods()
        {
            InitializeComponent();
            comboBox1.Text = ""; comboBox2.Text = ""; comboBox3.Text = "";
            comboBox4.Text = ""; textBox1.Text = ""; comboBox5.Text = "";
            comboBox6.Text = "";
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
                    SqlCommand myCommand = new SqlCommand("Add_Goods", cn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@Name", comboBox1.Text);
                    myCommand.Parameters.AddWithValue("@Category", comboBox2.Text);
                    myCommand.Parameters.AddWithValue("@Color", comboBox3.Text);
                    myCommand.Parameters.AddWithValue("@Size", comboBox4.Text);
                    myCommand.Parameters.AddWithValue("@Count", Convert.ToInt32(textBox1.Text));
                    myCommand.Parameters.AddWithValue("@Unit", comboBox5.Text);
                    myCommand.Parameters.AddWithValue("@Link", comboBox6.Text);
                    cn.Open();
                    myCommand.ExecuteNonQuery();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Вы ввели недопустимое значение");
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
            comboBox1.Text = ""; comboBox2.Text = ""; comboBox3.Text = "";
            comboBox4.Text = ""; textBox1.Text = ""; comboBox5.Text = "";
            comboBox6.Text = "";
          //  EventOK();
            EditGoods main = this.Owner as EditGoods;
            main.ReLoad();
            Close();
        }
       
        private void AddGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Link' table. You can move, or remove it, as needed.
            this.linkTableAdapter.Fill(this.kleinkindDataSet.Link);
            // TODO: This line of code loads data into the 'kleinkindDataSet.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.kleinkindDataSet.Unit);
            // TODO: This line of code loads data into the 'kleinkindDataSet.Size' table. You can move, or remove it, as needed.
            this.sizeTableAdapter.Fill(this.kleinkindDataSet.Size);
            // TODO: This line of code loads data into the 'kleinkindDataSet.Color' table. You can move, or remove it, as needed.
            this.colorTableAdapter.Fill(this.kleinkindDataSet.Color);
            // TODO: This line of code loads data into the 'kleinkindDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.kleinkindDataSet.Category);
            // TODO: This line of code loads data into the 'kleinkindDataSet.GoodsName' table. You can move, or remove it, as needed.
            this.goodsNameTableAdapter.Fill(this.kleinkindDataSet.GoodsName);

        }
    }
}
