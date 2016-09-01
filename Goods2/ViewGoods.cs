using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goods2
{
    public partial class ViewGoods : Form
    {
        public ViewGoods()
        {
            InitializeComponent();
          
        }

        private void ViewGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Goods' table. You can move, or remove it, as needed.
            this.show_GoodsTableAdapter.Fill(this.kleinkindDataSet.Show_Goods);
        }

        private void ViewGoods_Resize(object sender, EventArgs e)
        {
            this.show_GoodsDataGridView.Width = this.Width - 19;
            this.show_GoodsDataGridView.Height = this.Height - 40;
        }
    }
}
