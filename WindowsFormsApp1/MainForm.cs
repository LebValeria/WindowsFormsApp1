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
using WindowsFormsApp1.Заявки;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        string userID = null;
        string userIsAdmin = null;
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

            SqlCommand command = new SqlCommand("Select [login], [id], [userGroupId] from [user] where [login] = @login and [password] = @password", db.getConnection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                label3.Text ="Вы вошли как " + table.Rows[0][0].ToString();
                userID = table.Rows[0][1].ToString();
                userIsAdmin = table.Rows[0][2].ToString();
                textBoxLogin.Hide();
                textBoxPassword.Hide();
                label1.Hide();
                label2.Hide();
                buttonLogin.Hide();
                buttonQuit.Show();
                buttonProfile.Show();
                button1.Show();
                button2.Show();
                if(userIsAdmin == "1")
                {
                    button2.Text = "Список заявок";
                }
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
            userIsAdmin = null;
            textBoxLogin.Show();
            textBoxPassword.Show();
            label1.Show();
            label2.Show();
            buttonLogin.Show();
            buttonProfile.Hide();
            button1.Hide();
            button2.Hide();
            buttonQuit.Hide();
            label3.Text = "Вы не аавторизованы";
            button2.Text = "Мои заявки";
        }

        private void получениеПаспорта14ЛетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Заявки.Passport14 passport14 = new Заявки.Passport14(userID, userIsAdmin);
            passport14.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Profile profile = new Profile(userID);
            profile.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AddZayavka zayavka = new AddZayavka(userID);
            zayavka.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zayavki zayavki = new Zayavki(userID,userIsAdmin);
            zayavki.ShowDialog();
        }
    }
}
