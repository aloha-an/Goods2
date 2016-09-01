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
    public partial class ViewSale : Form
    {
        private string Start;
        private string End;
        public ViewSale()
        {
            InitializeComponent();
            Start = "01.01.1900";
            End = "31.12.2050";
        }

        private void ViewSale_Resize(object sender, EventArgs e)
        {
            this.show_SaleDataGridView.Width = this.Width - 19;
            this.show_SaleDataGridView.Height = this.Height - 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value > dateTimePicker1.Value)
            {
                Start = dateTimePicker1.Value.Date.ToString("dd.MM.yyyy");
                End = dateTimePicker2.Value.Date.ToString("dd.MM.yyyy");
            }
            else
                MessageBox.Show("Проверьте выбраные даты");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start = "01.01.1900";
            End = "31.12.2050";
          //  this.ViewSale_Load(sender,e);
        }

        private void ViewSale_Load(object sender, EventArgs e)
        {
            this.show_SaleTableAdapter.Fill(this.kleinkindDataSet.Show_Sale, Start, End);
        }
    }
}
