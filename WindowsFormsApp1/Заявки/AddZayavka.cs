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
    public partial class AddZayavka : Form
    {
        string userId;
        public AddZayavka(string userId)
        {
            InitializeComponent();
            this.userId = userId;

        }

        private void AddZayavka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.orderType". При необходимости она может быть перемещена или удалена.
            this.orderTypeTableAdapter.Fill(this.kursDataSet.orderType);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("Insert into [order] ([userId],[statusId], [orderTypeId], [creationDate])" +
                    " values (@id, @status, @type, @date)", connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = 3;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = comboBox1.SelectedValue;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заявка сохранена");
                }
                catch
                {
                    MessageBox.Show("Ошибка данные не выбраны");
                }
            }
        }
    }
}
