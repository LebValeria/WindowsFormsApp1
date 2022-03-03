namespace WindowsFormsApp1.Заявки
{
    partial class ArchiveZ
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРешенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zayavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new WindowsFormsApp1.KursDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.zayavkiTableAdapter = new WindowsFormsApp1.KursDataSetTableAdapters.ZayavkiTableAdapter();
            this.zayavkiProcTableAdapter = new WindowsFormsApp1.KursDataSetTableAdapters.zayavkiProcTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Данные пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
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
            this.idTypeDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРешенияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zayavkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 305);
            this.dataGridView1.TabIndex = 8;
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
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРешенияDataGridViewTextBoxColumn
            // 
            this.датаРешенияDataGridViewTextBoxColumn.DataPropertyName = "Дата решения";
            this.датаРешенияDataGridViewTextBoxColumn.HeaderText = "Дата решения";
            this.датаРешенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРешенияDataGridViewTextBoxColumn.Name = "датаРешенияDataGridViewTextBoxColumn";
            this.датаРешенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // zayavkiBindingSource
            // 
            this.zayavkiBindingSource.DataMember = "Zayavki";
            this.zayavkiBindingSource.DataSource = this.kursDataSet;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(491, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Архив заявок";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Одобрить заявку";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(631, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Отклонить заявку";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // zayavkiTableAdapter
            // 
            this.zayavkiTableAdapter.ClearBeforeFill = true;
            // 
            // zayavkiProcTableAdapter
            // 
            this.zayavkiProcTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "Поиск по ФИО";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 492);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 492);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(550, 492);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Отчество";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 477);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(195, 37);
            this.button6.TabIndex = 20;
            this.button6.Text = "Сбросить поиск";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ArchiveZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 551);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "ArchiveZ";
            this.Text = "ArchiveZ";
            this.Load += new System.EventHandler(this.ArchiveZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private KursDataSet kursDataSet;
        private KursDataSetTableAdapters.ZayavkiTableAdapter zayavkiTableAdapter;
        private KursDataSetTableAdapters.zayavkiProcTableAdapter zayavkiProcTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРешенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zayavkiBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
    }
}