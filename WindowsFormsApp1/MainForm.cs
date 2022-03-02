using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        string userID = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("Select [login], [id] from [user] where [login] = @login and [password] = @password", db.getConnection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                label3.Text ="Вы вошли как " + table.Rows[0][0].ToString();
                userID = table.Rows[0][1].ToString();
                textBoxLogin.Hide();
                textBoxPassword.Hide();
                label1.Hide();
                label2.Hide();
                buttonLogin.Hide();
                buttonQuit.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            db.closeConnection();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            userID = null;
            textBoxLogin.Show();
            textBoxPassword.Show();
            label1.Show();
            label2.Show();
            buttonLogin.Show();
            buttonQuit.Hide();
        }
    }
}
