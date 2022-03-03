namespace WindowsFormsApp1.Заявки
{
    partial class dataZayavka
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kursDataSet = new WindowsFormsApp1.KursDataSet();
            this.orderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTypeTableAdapter = new WindowsFormsApp1.KursDataSetTableAdapters.orderTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Документы для заявки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Тип заявки";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.orderTypeBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вывести документы для заявки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTypeBindingSource
            // 
            this.orderTypeBindingSource.DataMember = "orderType";
            this.orderTypeBindingSource.DataSource = this.kursDataSet;
            // 
            // orderTypeTableAdapter
            // 
            this.orderTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataZayavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "dataZayavka";
            this.Text = "dataZayavka";
            this.Load += new System.EventHandler(this.dataZayavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource orderTypeBindingSource;
        private KursDataSetTableAdapters.orderTypeTableAdapter orderTypeTableAdapter;
    }
}