namespace Goods2
{
    partial class EditGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.kleinkindDataSet = new Goods2.kleinkindDataSet();
            this.show_GoodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.show_GoodsTableAdapter1 = new Goods2.kleinkindDataSetTableAdapters.Show_GoodsTableAdapter();
            this.tableAdapterManager1 = new Goods2.kleinkindDataSetTableAdapters.TableAdapterManager();
            this.show_GoodsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_GoodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_GoodsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(904, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Goods2.Properties.Resources.Open_folder_add_icon__1_;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Goods2.Properties.Resources.folder_delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // kleinkindDataSet
            // 
            this.kleinkindDataSet.DataSetName = "kleinkindDataSet";
            this.kleinkindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // show_GoodsBindingSource1
            // 
            this.show_GoodsBindingSource1.DataMember = "Show_Goods";
            this.show_GoodsBindingSource1.DataSource = this.kleinkindDataSet;
            // 
            // show_GoodsTableAdapter1
            // 
            this.show_GoodsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoryTableAdapter = null;
            this.tableAdapterManager1.ClientAdressTableAdapter = null;
            this.tableAdapterManager1.ClientNameTableAdapter = null;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.ColorTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.GoodsNameTableAdapter = null;
            this.tableAdapterManager1.GoodsTableAdapter = null;
            this.tableAdapterManager1.LinkTableAdapter = null;
            this.tableAdapterManager1.PurchaseTableAdapter = null;
            this.tableAdapterManager1.SaleTableAdapter = null;
            this.tableAdapterManager1.SizeTableAdapter = null;
            this.tableAdapterManager1.UnitTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Goods2.kleinkindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // show_GoodsDataGridView1
            // 
            this.show_GoodsDataGridView1.AutoGenerateColumns = false;
            this.show_GoodsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_GoodsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.show_GoodsDataGridView1.DataSource = this.show_GoodsBindingSource1;
            this.show_GoodsDataGridView1.Location = new System.Drawing.Point(0, 28);
            this.show_GoodsDataGridView1.Name = "show_GoodsDataGridView1";
            this.show_GoodsDataGridView1.Size = new System.Drawing.Size(897, 363);
            this.show_GoodsDataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Наим-е";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn11.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn12.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn13.HeaderText = "Размер";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Counts";
            this.dataGridViewTextBoxColumn14.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn15.HeaderText = "Ед. Изм.";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Link";
            this.dataGridViewTextBoxColumn16.FillWeight = 250F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Ссылка";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn16.Width = 250;
            // 
            // EditGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 393);
            this.Controls.Add(this.show_GoodsDataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EditGoods";
            this.Text = "Редактирор товаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditGoods_FormClosing);
            this.Load += new System.EventHandler(this.Edit_Goods_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_GoodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_GoodsDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private kleinkindDataSet kleinkindDataSet;
        private System.Windows.Forms.BindingSource show_GoodsBindingSource1;
        private kleinkindDataSetTableAdapters.Show_GoodsTableAdapter show_GoodsTableAdapter1;
        private kleinkindDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView show_GoodsDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn16;
    }
}