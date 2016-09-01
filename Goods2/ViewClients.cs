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
    public partial class ViewClients : Form
    {
        public ViewClients()
        {
            InitializeComponent();
        }

        private void ShowCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kleinkindDataSet.Show_Clients' table. You can move, or remove it, as needed.
            this.show_ClientsTableAdapter.Fill(this.kleinkindDataSet.Show_Clients);
        }

        private void ViewClients_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Width = this.Width - 19;
            this.dataGridView1.Height = this.Height - 40;
        }
    }
}
