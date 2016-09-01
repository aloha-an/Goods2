namespace Goods2
{
    partial class ViewPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.show_PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.showPurchaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kleinkindDataSet = new Goods2.kleinkindDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.show_PurchaseTableAdapter = new Goods2.kleinkindDataSetTableAdapters.Show_PurchaseTableAdapter();
            this.tableAdapterManager = new Goods2.kleinkindDataSetTableAdapters.TableAdapterManager();
            this.PurchaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.GoodsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.show_PurchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPurchaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // show_PurchaseDataGridView
            // 
            this.show_PurchaseDataGridView.AllowUserToAddRows = false;
            this.show_PurchaseDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.show_PurchaseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.show_PurchaseDataGridView.AutoGenerateColumns = false;
            this.show_PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_PurchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseId,
            this.Name,
            this.Counts,
            this.Unit,
            this.PriceUS,
            this.PriceUA,
            this.dateDataGridViewTextBoxColumn,
            this.Exchange,
            this.SummUS,
            this.SummUA,
            this.Color,
            this.Size,
            this.Category,
            this.Link,
            this.GoodsId});
            this.show_PurchaseDataGridView.DataSource = this.showPurchaseBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_PurchaseDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.show_PurchaseDataGridView.Location = new System.Drawing.Point(0, 63);
            this.show_PurchaseDataGridView.Name = "show_PurchaseDataGridView";
            this.show_PurchaseDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_PurchaseDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.show_PurchaseDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.show_PurchaseDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.show_PurchaseDataGridView.Size = new System.Drawing.Size(1214, 311);
            this.show_PurchaseDataGridView.TabIndex = 2;
            // 
            // showPurchaseBindingSource1
            // 
            this.showPurchaseBindingSource1.DataMember = "Show_Purchase";
            this.showPurchaseBindingSource1.DataSource = this.kleinkindDataSet;
            // 
            // kleinkindDataSet
            // 
            this.kleinkindDataSet.DataSetName = "kleinkindDataSet";
            this.kleinkindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отобразить все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отобразить за период";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Конец периода:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Начало периода:";
            // 
            // show_PurchaseTableAdapter
            // 
            this.show_PurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClientAdressTableAdapter = null;
            this.tableAdapterManager.ClientNameTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ColorTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GoodsNameTableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.LinkTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.SizeTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Goods2.kleinkindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PurchaseId
            // 
            this.PurchaseId.DataPropertyName = "PurchaseId";
            this.PurchaseId.HeaderText = "PurchaseId";
            this.PurchaseId.Name = "PurchaseId";
            this.PurchaseId.ReadOnly = true;
            this.PurchaseId.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Name.FillWeight = 120F;
            this.Name.HeaderText = "Наим-е";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 120;
            // 
            // Counts
            // 
            this.Counts.DataPropertyName = "Counts";
            this.Counts.FillWeight = 50F;
            this.Counts.HeaderText = "Кол-во";
            this.Counts.Name = "Counts";
            this.Counts.ReadOnly = true;
            this.Counts.Width = 50;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.FillWeight = 40F;
            this.Unit.HeaderText = "Ед. Изм.";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 40;
            // 
            // PriceUS
            // 
            this.PriceUS.DataPropertyName = "PriceUS";
            this.PriceUS.FillWeight = 50F;
            this.PriceUS.HeaderText = "Цена, $";
            this.PriceUS.Name = "PriceUS";
            this.PriceUS.ReadOnly = true;
            this.PriceUS.Width = 50;
            // 
            // PriceUA
            // 
            this.PriceUA.DataPropertyName = "PriceUA";
            this.PriceUA.FillWeight = 60F;
            this.PriceUA.HeaderText = "Цена, грн";
            this.PriceUA.Name = "PriceUA";
            this.PriceUA.ReadOnly = true;
            this.PriceUA.Width = 60;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 80F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата покупки";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 80;
            // 
            // Exchange
            // 
            this.Exchange.DataPropertyName = "Exchange";
            this.Exchange.FillWeight = 70F;
            this.Exchange.HeaderText = "Курс $, грн";
            this.Exchange.Name = "Exchange";
            this.Exchange.ReadOnly = true;
            this.Exchange.Width = 70;
            // 
            // SummUS
            // 
            this.SummUS.DataPropertyName = "SummUS";
            this.SummUS.FillWeight = 70F;
            this.SummUS.HeaderText = "Сумма, $";
            this.SummUS.Name = "SummUS";
            this.SummUS.ReadOnly = true;
            this.SummUS.Width = 70;
            // 
            // SummUA
            // 
            this.SummUA.DataPropertyName = "SummUA";
            this.SummUA.FillWeight = 70F;
            this.SummUA.HeaderText = "Сумма, грн";
            this.SummUA.Name = "SummUA";
            this.SummUA.ReadOnly = true;
            this.SummUA.Width = 70;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.FillWeight = 80F;
            this.Size.HeaderText = "Размер";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 80;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.DataPropertyName = "Link";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Link.DefaultCellStyle = dataGridViewCellStyle3;
            this.Link.FillWeight = 280F;
            this.Link.HeaderText = "Ссылка";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Width = 280;
            // 
            // GoodsId
            // 
            this.GoodsId.DataPropertyName = "GoodsId";
            this.GoodsId.HeaderText = "GoodsId";
            this.GoodsId.Name = "GoodsId";
            this.GoodsId.ReadOnly = true;
            this.GoodsId.Visible = false;
            // 
            // ViewPurchase
            // 
            this.ClientSize = new System.Drawing.Size(1216, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_PurchaseDataGridView);
         //   this.Name = "ViewPurchase";
            this.Text = "Просмотр покупок";
            this.Load += new System.EventHandler(this.ViewPurchase_Load);
            this.Resize += new System.EventHandler(this.ViewPurchase_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.show_PurchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPurchaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kleinkindDataSet kleinkindDataSet;
        private kleinkindDataSetTableAdapters.Show_PurchaseTableAdapter show_PurchaseTableAdapter;
        private kleinkindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView show_PurchaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource showPurchaseBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsId;
    }
}