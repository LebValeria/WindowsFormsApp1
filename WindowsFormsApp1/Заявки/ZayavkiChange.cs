using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Заявки
{
    public partial class ZayavkiChange : Form
    {
        string type;
        string id;
        public ZayavkiChange(string id, string type)
        {
            InitializeComponent();
            this.type = type;
            this.id = id;
        }

        private void ZayavkiChange_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.orderType". При необходимости она может быть перемещена или удалена.
            this.orderTypeTableAdapter.Fill(this.kursDataSet.orderType);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("update [order] set [orderTypeId] = @type where [id] = @id", connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = comboBox1.SelectedValue;
                connection.Open();
                cmd.ExecuteNonQuery();
               

            }
        }
    }
}
