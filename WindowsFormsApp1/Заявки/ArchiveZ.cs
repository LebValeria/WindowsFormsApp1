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
    public partial class ArchiveZ : Form
    {
        string userIsAdmin;
        DB db = new DB();
        public ArchiveZ(string userIsAdmin)
        {
            InitializeComponent();
            this.userIsAdmin = userIsAdmin;
        }

        private void ArchiveZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Zayavki". При необходимости она может быть перемещена или удалена.
            this.zayavkiTableAdapter.Fill(this.kursDataSet.Zayavki);
            button1.Show();
            RefreshTable();
        }

        private void Snils_FormClosing(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.orderType.name AS [Тип заявки], dbo.orderStatus.name AS Статус, dbo.[order].creationDate AS Дата," +
                " dbo.orderType.id AS idType, dbo.[order].id, dbo.[user].name AS Имя, dbo.[user].lastName AS Фамилия, " +
                " dbo.[user].middleName AS Отчество, dbo.[order].desDate AS[Дата решения] " +
                " FROM     dbo.[order] INNER JOIN " +
                " dbo.orderType ON dbo.[order].orderTypeId = dbo.orderType.id INNER JOIN " +
                " dbo.orderStatus ON dbo.[order].statusId = dbo.orderStatus.id INNER JOIN " +
                " dbo.[user] ON dbo.[order].userId = dbo.[user].id " +
                " where [order].[statusID] != 3", db.getConnection());
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZayavkiChange zayavkiChange = new ZayavkiChange(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            zayavkiChange.FormClosed += new FormClosedEventHandler(Snils_FormClosing);
            zayavkiChange.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select [userId] from [order] where [id] = @id", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string selectUser = table.Rows[0][0].ToString();
            Profile profile = new Profile(selectUser);
            profile.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                SqlCommand command = new SqlCommand("update [order] set [statusId] = '1', [desDate] = @date where [id] = @id", db.getConnection());
                command.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                command.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Today;
                db.openConnection();
                command.ExecuteNonQuery();
                RefreshTable();
            }
            catch
            {
                MessageBox.Show("Не выбрана заявка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                SqlCommand command = new SqlCommand("update [order] set [statusId] = '2', [desDate] = @date where [id] = @id", db.getConnection());
                command.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                command.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Today;
                db.openConnection();
                command.ExecuteNonQuery();
                RefreshTable();
            }
            catch
            {
                MessageBox.Show("Не выбрана заявка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.orderType.name AS [Тип заявки], dbo.orderStatus.name AS Статус, dbo.[order].creationDate AS Дата," +
                " dbo.orderType.id AS idType, dbo.[order].id, dbo.[user].name AS Имя, dbo.[user].lastName AS Фамилия, " +
                " dbo.[user].middleName AS Отчество, dbo.[order].desDate AS[Дата решения] " +
                " FROM     dbo.[order] INNER JOIN " +
                " dbo.orderType ON dbo.[order].orderTypeId = dbo.orderType.id INNER JOIN " +
                " dbo.orderStatus ON dbo.[order].statusId = dbo.orderStatus.id INNER JOIN " +
                " dbo.[user] ON dbo.[order].userId = dbo.[user].id " +
                " where [order].[statusID] != 3 and [user].name = @name and [user].lastName = @lastN and [user].middleName = @middleN", db.getConnection());
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@lastN", SqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@middleN", SqlDbType.VarChar).Value = textBox3.Text;
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                db.closeConnection();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
