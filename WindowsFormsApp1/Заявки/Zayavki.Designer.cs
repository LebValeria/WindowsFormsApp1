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
            MySql.Data.MySqlClient.MySqlParameter mySqlParameter1 = new MySql.Data.MySqlClient.MySqlParameter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kursDataSet = new WindowsFormsApp1.KursDataSet();
            this.zayavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типЗаявкиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zayavkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zayavkiBindingSource
            // 
            this.zayavkiBindingSource.DataMember = "Zayavki";
            this.zayavkiBindingSource.DataSource = this.kursDataSet;
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
            mySqlParameter1.MySqlDbType = MySql.Data.MySqlClient.MySqlDbType.Int32;
            mySqlParameter1.ParameterName = "@id";
            mySqlParameter1.Precision = ((byte)(0));
            mySqlParameter1.Scale = ((byte)(0));
            mySqlParameter1.Size = 0;
            mySqlParameter1.SourceColumn = null;
            mySqlParameter1.SourceVersion = System.Data.DataRowVersion.Default;
            this.mySqlCommand1.Parameters.Add(mySqlParameter1);
            this.mySqlCommand1.Transaction = null;
            // 
            // Zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zayavki";
            this.Text = "Zayavki";
            this.Load += new System.EventHandler(this.Zayavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KursDataSet kursDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn типЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zayavkiBindingSource;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}