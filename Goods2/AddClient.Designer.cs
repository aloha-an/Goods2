namespace Goods2
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewClientNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kleinkindDataSet = new Goods2.kleinkindDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.viewClientAdressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kleinkindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.viewClientNameTableAdapter = new Goods2.kleinkindDataSetTableAdapters.ViewClientNameTableAdapter();
            this.viewClientAdressTableAdapter = new Goods2.kleinkindDataSetTableAdapters.ViewClientAdressTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientAdressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адресс";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.viewClientNameBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // viewClientNameBindingSource
            // 
            this.viewClientNameBindingSource.DataMember = "ViewClientName";
            this.viewClientNameBindingSource.DataSource = this.kleinkindDataSet;
            // 
            // kleinkindDataSet
            // 
            this.kleinkindDataSet.DataSetName = "kleinkindDataSet";
            this.kleinkindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.viewClientAdressBindingSource;
            this.comboBox2.DisplayMember = "Adress";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(68, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // viewClientAdressBindingSource
            // 
            this.viewClientAdressBindingSource.DataMember = "ViewClientAdress";
            this.viewClientAdressBindingSource.DataSource = this.kleinkindDataSetBindingSource;
            // 
            // kleinkindDataSetBindingSource
            // 
            this.kleinkindDataSetBindingSource.DataSource = this.kleinkindDataSet;
            this.kleinkindDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewClientNameTableAdapter
            // 
            this.viewClientNameTableAdapter.ClearBeforeFill = true;
            // 
            // viewClientAdressTableAdapter
            // 
            this.viewClientAdressTableAdapter.ClearBeforeFill = true;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 181);
            this.MinimumSize = new System.Drawing.Size(345, 181);
            this.Name = "AddClient";
            this.Text = "Добавить клиента";
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewClientNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientAdressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kleinkindDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private kleinkindDataSet kleinkindDataSet;
        private System.Windows.Forms.BindingSource viewClientNameBindingSource;
        private kleinkindDataSetTableAdapters.ViewClientNameTableAdapter viewClientNameTableAdapter;
        private System.Windows.Forms.BindingSource kleinkindDataSetBindingSource;
        private System.Windows.Forms.BindingSource viewClientAdressBindingSource;
        private kleinkindDataSetTableAdapters.ViewClientAdressTableAdapter viewClientAdressTableAdapter;
    }
}