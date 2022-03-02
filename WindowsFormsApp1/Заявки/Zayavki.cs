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
    public partial class Zayavki : Form
    {
        string userId;
        DB db = new DB();
        public Zayavki(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Zayavki_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]" +
                "where[order].[userId] = @id", connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                
            }
            

        }
    }
}
