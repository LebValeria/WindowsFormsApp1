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

namespace WindowsFormsApp1.doc
{
    public partial class Snils : Form
    {
        string userId;
        public Snils(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void snils_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand cmd = new SqlCommand("Insert into [snils] ([userId],[number]) values (@id, @number)", connection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                cmd.Parameters.Add("@number", SqlDbType.VarChar).Value = textBox1.Text;
                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Снилс добавлен");
                }
                catch
                {
                    MessageBox.Show("Ошибка данные не введены");
                }
            }
                
        }
    }
}
