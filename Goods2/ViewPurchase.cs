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
    public partial class ViewPurchase : Form
    {
        private string Start;
        private string End;
        public ViewPurchase()
        {
            InitializeComponent();
            Start = "01.01.1900";
            End = "31.12.2050";
        }

        private void ViewPurchase_Resize(object sender, EventArgs e)
        {
            this.show_PurchaseDataGridView.Width = this.Width - 19;
            this.show_PurchaseDataGridView.Height = this.Height - 40;
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
        }

        private void ViewPurchase_Load(object sender, EventArgs e)
        {
            this.show_PurchaseTableAdapter.Fill(this.kleinkindDataSet.Show_Purchase, Start, End);
        }
    }
}
