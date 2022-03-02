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
    public partial class Passport14 : Form
    {
        string userId;
        string userIsAdmin;
        public Passport14(string userId, string userIsAdmin)
        {
            InitializeComponent();
            this.userId = userId;
            this.userIsAdmin = userIsAdmin;
        }

        private void Passport14_Load(object sender, EventArgs e)
        {
            if(userId != null)
            {
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                label11.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                button1.Show();
            }
            else
            {
                label1.Show();
                label3.Show();
                label4.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string snils = textBox1.Text;
            string dateS = textBox2.Text;
            string numberS = textBox3.Text;
            string placeS = textBox4.Text;
            string motherS = textBox5.Text;
            string Father = textBox6.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("insert into [login], [id], [userGroupId] from [user] where [login] = @login and [password] = @password", db.getConnection());
            /*command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            */
            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {/*
                label3.Text = "Вы вошли как " + table.Rows[0][0].ToString();
                userID = table.Rows[0][1].ToString();
                userIsAdmin = table.Rows[0][2].ToString();
                textBoxLogin.Hide();
                textBoxPassword.Hide();
                label1.Hide();
                label2.Hide();
                buttonLogin.Hide();
                buttonQuit.Show();
                */
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            db.closeConnection();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
