namespace WindowsFormsApp1.Заявки
{
    partial class Zayavki
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
            MySql.Data.MySqlClient.MySqlParameter mySqlParameter2 = new MySql.Data.MySqlClient.MySqlParameter();
            this.kursDataSet = new WindowsFormsApp1.KursDataSet();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.orderTypeTableAdapter = new WindowsFormsApp1.KursDataSetTableAdapters.orderTypeTableAdapter();
            this.kursDataSet1 = new WindowsFormsApp1.KursDataSet();
            this.zayavkiTableAdapter = new WindowsFormsApp1.KursDataSetTableAdapters.ZayavkiTableAdapter();
            this.orderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKorderorderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new WindowsFormsApp1.KursDataSetTableAdapters.orderTableAdapter();
            this.orderTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderorderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "server=LAPTOPPC;database=Kurs;Integrated Security=True";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.CommandText = "zayavkiProc";
            this.mySqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            mySqlParameter2.MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.Int32;
            mySqlParameter2.ParameterName = "@id";
            mySqlParameter2.Precision = ((byte)(0));
            mySqlParameter2.Scale = ((byte)(0));
            mySqlParameter2.Size = 0;
            mySqlParameter2.SourceColumn = null;
            mySqlParameter2.SourceVersion = System.Data.DataRowVersion.Default;
            this.mySqlCommand1.Parameters.Add(mySqlParameter2);
            this.mySqlCommand1.Transaction = null;
            // 
            // orderTypeTableAdapter
            // 
            this.orderTypeTableAdapter.ClearBeforeFill = true;
            // 
            // kursDataSet1
            // 
            this.kursDataSet1.DataSetName = "KursDataSet";
            this.kursDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zayavkiTableAdapter
            // 
            this.zayavkiTableAdapter.ClearBeforeFill = true;
            // 
            // orderTypeBindingSource
            // 
            this.orderTypeBindingSource.DataMember = "orderType";
            this.orderTypeBindingSource.DataSource = this.kursDataSet1;
            // 
            // zayavkiBindingSource
            // 
            this.zayavkiBindingSource.DataMember = "Zayavki";
            this.zayavkiBindingSource.DataSource = this.kursDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.типЗаявкиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.idTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zayavkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // типЗаявкиDataGridViewTextBoxColumn
            // 
            this.типЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "Тип заявки";
            this.типЗаявкиDataGridViewTextBoxColumn.HeaderText = "Тип заявки";
            this.типЗаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типЗаявкиDataGridViewTextBoxColumn.Name = "типЗаявкиDataGridViewTextBoxColumn";
            this.типЗаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTypeDataGridViewTextBoxColumn
            // 
            this.idTypeDataGridViewTextBoxColumn.DataPropertyName = "idType";
            this.idTypeDataGridViewTextBoxColumn.HeaderText = "idType";
            this.idTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTypeDataGridViewTextBoxColumn.Name = "idTypeDataGridViewTextBoxColumn";
            this.idTypeDataGridViewTextBoxColumn.Visible = false;
            this.idTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKorderorderTypeBindingSource
            // 
            this.fKorderorderTypeBindingSource.DataMember = "FK_order_orderType";
            this.fKorderorderTypeBindingSource.DataSource = this.orderTypeBindingSource;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderTypeBindingSource1
            // 
            this.orderTypeBindingSource1.DataMember = "orderType";
            this.orderTypeBindingSource1.DataSource = this.kursDataSet1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Данные пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Одобрить заявку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(671, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "Отклонить заявку";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zayavki";
            this.Text = "Zayavki";
            this.Load += new System.EventHandler(this.Zayavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKorderorderTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KursDataSet kursDataSet;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private KursDataSetTableAdapters.orderTypeTableAdapter orderTypeTableAdapter;
        private KursDataSet kursDataSet1;
        private KursDataSetTableAdapters.ZayavkiTableAdapter zayavkiTableAdapter;
        private System.Windows.Forms.BindingSource orderTypeBindingSource;
        private System.Windows.Forms.BindingSource zayavkiBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKorderorderTypeBindingSource;
        private KursDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderTypeBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}