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
    public partial class StartForm : Form
    {
      //  private SqlConnection connect = null;
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Clients' table. You can move, or remove it, as needed.
            this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Goods' table. You can move, or remove it, as needed.
            this.show_GoodsTableAdapter.Fill(this.kleinkindDataSet.Show_Goods);
            this.show_PurchaseTableAdapter.Fill(this.kleinkindDataSet.Show_Purchase, "01.01.1900", "31.12.2050");
            this.show_SaleTableAdapter.Fill(this.kleinkindDataSet.Show_Sale, "01.01.1900", "31.12.2050");

        }

        private void viewGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewGoods newForm = new ViewGoods();
            newForm.Owner = this;
            newForm.Show();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchase newForm = new ViewPurchase();
            newForm.Show();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSale newForm = new ViewSale();
            newForm.Show();
        }

        private void viewClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewClients newForm = new ViewClients();
            newForm.Show();
        }

        private void editGoodsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditGoods newForm = new EditGoods();
            newForm.Owner = this;
            newForm.Show();
        }

        private void editPurchasesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditPurchase newForm = new EditPurchase();
            newForm.Owner = this;
            newForm.Show();
        }

        private void editSalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditSale newForm = new EditSale();
            newForm.Owner = this;
            newForm.Show();
        }

        private void editClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditClients newForm = new EditClients();
            newForm.Owner = this;
            newForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                    tabControl1.Size = new Size(show_GoodsDataGridView.Size.Width + 8, show_GoodsDataGridView.Size.Height + 8);
                    StartForm.ActiveForm.Size = new Size(tabControl1.Size.Width + 6, tabControl1.Size.Height + 6);
                    break;
                case 1:
                    tabControl1.Size = new Size(show_PurchaseDataGridView.Size.Width + 8, show_PurchaseDataGridView.Size.Height + 8);
                    StartForm.ActiveForm.Size = new Size(tabControl1.Size.Width + 6, tabControl1.Size.Height + 6);
                    break;
                case 2:
                    tabControl1.Size = new Size(show_SaleDataGridView.Size.Width + 18, show_SaleDataGridView.Size.Height + 8);
                    StartForm.ActiveForm.Size = new Size(tabControl1.Size.Width + 6, tabControl1.TabPages[2].Size.Height + 6);
                    break;
                case 3:
                    tabControl1.Size = new Size(show_ClientsDataGridView.Size.Width + 8, show_ClientsDataGridView.Size.Height + 8);
                    StartForm.ActiveForm.Size = new Size(tabControl1.Size.Width + 6, tabControl1.Size.Height + 6);
                    break;
            }
            StartForm.ActiveForm.Refresh();
        }

        public void ReLoad_Goods()
        {
            this.Refresh();
            this.show_GoodsTableAdapter.Fill(this.kleinkindDataSet.Show_Goods);
            int k = show_GoodsDataGridView .Rows.Count;
            if (k > 5)
                show_GoodsDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
        }

        public void ReLoad_Purchase()
        {
            this.Refresh();
            this.show_PurchaseTableAdapter.Fill(this.kleinkindDataSet.Show_Purchase, "01.01.1900", "31.12.2050");
            int k = show_PurchaseDataGridView.Rows.Count;
            if (k > 5)
                show_PurchaseDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
        }

        public void ReLoad_Sale()
        {
            this.Refresh();
            this.show_SaleTableAdapter.Fill(this.kleinkindDataSet.Show_Sale, "01.01.1900", "31.12.2050");
            int k = show_SaleDataGridView.Rows.Count;
            if (k > 5)
                show_SaleDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
        }

        public void ReLoad_Clients()
        {
            this.Refresh();
            this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
            int k = show_ClientsDataGridView.Rows.Count;
            if (k > 5)
                show_ClientsDataGridView.FirstDisplayedScrollingRowIndex = (k - 5);
        }

        private void StartForm_SizeChanged(object sender, EventArgs e)
        {
         //   tabControl1.Size = new Size(StartForm.ActiveForm.Size.Width-6, StartForm.ActiveForm.Size.Height-6);
          //  show_GoodsDataGridView.Size=new Size(tabControl1.Size.Width - 8, tabControl1.Size.Height + 8);
          //  StartForm.ActiveForm.Size = new Size(tabControl1.Size.Width + 6, tabControl1.Size.Height + 6);
        }

        private void StartForm_Resize(object sender, EventArgs e)
        {
          //  tabControl1.Size = new Size(StartForm.ActiveForm.Size.Width - 6, StartForm.ActiveForm.Size.Height - 6);
           // show_GoodsDataGridView.Size = new Size(tabControl1.Size.Width - 8, tabControl1.Size.Height + 8);
        
        }

     

        //DelGoods main = this.Owner as DelGoods;
        //    main.ReLoad();

         //AddGoods newForm = new AddGoods();
         //   newForm.Owner = this;
         //   newForm.Show();
    }
}
