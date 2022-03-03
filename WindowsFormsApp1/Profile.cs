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
using WindowsFormsApp1.doc;

namespace WindowsFormsApp1
{
    public partial class Profile : Form
    {
        string userId;
        DB db2 = new DB();
        SqlDataAdapter adapter2 = new SqlDataAdapter();

        public Profile(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.familyStatus". При необходимости она может быть перемещена или удалена.
            this.familyStatusTableAdapter.Fill(this.kursDataSet.familyStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.nationality". При необходимости она может быть перемещена или удалена.
            this.nationalityTableAdapter.Fill(this.kursDataSet.nationality);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.kursDataSet.gender);
            FormRefresh();
        }
        
        private void FormRefresh()
        {
            DataTable table2 = new DataTable();
            SqlCommand command = new SqlCommand("Select [genderId], [name], [lastName], [middleName], [birthday], [nativeCity], " +
                "[email], [phoneNumber], [nationalyId], [familyStatusId] from [user] where [id] = @id", db2.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            adapter2.SelectCommand = command;
            adapter2.Fill(table2);
            if (table2.Rows.Count > 0)
            {
                comboBox1.SelectedValue = table2.Rows[0][0].ToString();
                textBox1.Text = table2.Rows[0][1].ToString();
                textBox2.Text = table2.Rows[0][2].ToString();
                textBox3.Text = table2.Rows[0][3].ToString();
                textBox4.Text = table2.Rows[0][4].ToString();
                textBox5.Text = table2.Rows[0][5].ToString();
                textBox6.Text = table2.Rows[0][6].ToString();
                textBox7.Text = table2.Rows[0][7].ToString();
                comboBox2.SelectedValue = table2.Rows[0][8].ToString();
                comboBox3.SelectedValue = table2.Rows[0][9].ToString();
            }

            SqlCommand command2 = new SqlCommand("Select [number] " +
                " from [snils] where [userId] = @id", db2.getConnection());
            command2.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            adapter2.SelectCommand = command2;
            DataTable table3 = new DataTable();
            adapter2.Fill(table3);
            if (table3.Rows.Count > 0)
            {
                textBox8.Text = table3.Rows[0][0].ToString();
                button2.Hide();
            }
            else
            {
                textBox8.ReadOnly = true;
            }

            SqlCommand command3 = new SqlCommand("Select [dateOfIssue], [number], [issuedBy], [mother], [father] " +
                " from [birthSertificate] where [userId] = @id", db2.getConnection());
            command3.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            adapter2.SelectCommand = command3;
            DataTable table4 = new DataTable();
            adapter2.Fill(table4);
            if (table4.Rows.Count > 0)
            {
                textBox9.Text = table4.Rows[0][0].ToString();
                textBox10.Text = table4.Rows[0][1].ToString();
                textBox11.Text = table4.Rows[0][2].ToString();
                textBox13.Text = table4.Rows[0][3].ToString();
                textBox12.Text = table4.Rows[0][4].ToString();
                button3.Hide();
            }
            else
            {
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
                textBox11.ReadOnly = true;
                textBox12.ReadOnly = true;
                textBox13.ReadOnly = true;
            }

            command3 = new SqlCommand("Select [series], [number], [dateOfIssue] " +
                " from [passport] where [userId] = @id", db2.getConnection());
            command3.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            adapter2.SelectCommand = command3;
            DataTable table5 = new DataTable();
            adapter2.Fill(table5);
            if (table5.Rows.Count > 0)
            {
                textBox14.Text = table5.Rows[0][0].ToString();
                textBox15.Text = table5.Rows[0][1].ToString();
                textBox16.Text = table5.Rows[0][2].ToString();
                button4.Hide();
            }
            else
            {
                textBox14.ReadOnly = true;
                textBox15.ReadOnly = true;
                textBox16.ReadOnly = true;
            }
            db2.closeConnection();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update [user] set  [genderId] = @gen,[name] = @name, [lastName] = @lastN," +
                "[middleName] = @middleN, [birthday] = @birthday, [nativeCity] = @city, " +
                "[email] =@email, [phoneNumber]= @phone, [nationalyId]=@national, [familyStatusId]=@family where [id] = @id", db2.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            command.Parameters.Add("@gen", SqlDbType.Int).Value = comboBox1.SelectedValue.ToString();
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@lastN", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@middleN", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@birthday", SqlDbType.Date).Value = textBox4.Text;
            command.Parameters.Add("@city", SqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = textBox7.Text;
            command.Parameters.Add("@national", SqlDbType.Int).Value = comboBox2.SelectedValue.ToString();
            command.Parameters.Add("@family", SqlDbType.Int).Value = comboBox3.SelectedValue.ToString();
            db2.openConnection();
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Неверно введена информация");
            }

            if (textBox8.Text.Length > 0)
            {
                command = new SqlCommand("update [snils] set [number]=@number where [userId]=@id", db2.getConnection());
                command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@number", SqlDbType.Int).Value = textBox8.Text;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Неверно введен снилс");
                }
            }   

            command = new SqlCommand("update [birthSertificate] set [dateOfIssue]=@ofIs, [number]=@number," +
            "[issuedBy] = @by, [mother]=@mother, [father]=@father where [userId]=@id", db2.getConnection());
            if(textBox9.Text.Length > 0 && textBox10.Text.Length > 0 && textBox11.Text.Length > 0 && textBox12.Text.Length > 0 && textBox13.Text.Length > 0)
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@ofIs", SqlDbType.Date).Value = textBox9.Text;
                command.Parameters.Add("@number", SqlDbType.Int).Value = textBox10.Text;
                command.Parameters.Add("@by", SqlDbType.VarChar).Value = textBox11.Text;
                command.Parameters.Add("@mother", SqlDbType.VarChar).Value = textBox12.Text;
                command.Parameters.Add("@father", SqlDbType.VarChar).Value = textBox13.Text;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Неверно введен сертификат о рождении");
                }
            }

            command = new SqlCommand("update [passport] set [number]=@number, [series]=@series, " +
            "[dateOfIssue] = @date where [userId]=@id", db2.getConnection());
            if (textBox14.Text.Length > 0 && textBox15.Text.Length > 0 && textBox16.Text.Length > 0)
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@series", SqlDbType.VarChar).Value = textBox14.Text;
                command.Parameters.Add("@number", SqlDbType.VarChar).Value = textBox15.Text;
                command.Parameters.Add("@date", SqlDbType.Date).Value = textBox16.Text;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Неверно введен паспорт");
                }
            }
            db2.closeConnection();
        }

        void Snils_FormClosing(object sender, EventArgs e)
        {
            FormRefresh();
            if(textBox8.Text.Length > 0)
            {
                textBox8.ReadOnly = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Snils snils = new Snils(userId);
            snils.FormClosed += new FormClosedEventHandler(Snils_FormClosing);
            snils.ShowDialog();
            
        }

        void birth_FormClosing(object sender, EventArgs e)
        {
            FormRefresh();
            if (textBox8.Text.Length > 0)
            {
                textBox9.ReadOnly = false;
                textBox10.ReadOnly = false;
                textBox11.ReadOnly = false;
                textBox12.ReadOnly = false;
                textBox13.ReadOnly = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BirthSertificate snils = new BirthSertificate(userId);
            snils.FormClosed += new FormClosedEventHandler(birth_FormClosing);
            snils.ShowDialog();
        }

        void passport_FormClosing(object sender, EventArgs e)
        {
            FormRefresh();
            if (textBox14.Text.Length > 0 && textBox15.Text.Length > 0)
            {
                textBox14.ReadOnly = false;
                textBox15.ReadOnly = false;
                textBox16.ReadOnly = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Passport passport = new Passport(userId);
            passport.FormClosed += new FormClosedEventHandler(passport_FormClosing);
            passport.ShowDialog();
        }
    }
}
