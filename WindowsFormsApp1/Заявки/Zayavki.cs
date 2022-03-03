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
        string userIsAdmin;
        DB db = new DB();
        public Zayavki(string userId, string userIsAdmin)
        {
            InitializeComponent();
            this.userId = userId;
            this.userIsAdmin = userIsAdmin;
        }

        private void Zayavki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.orderType". При необходимости она может быть перемещена или удалена.
            this.orderTypeTableAdapter.Fill(this.kursDataSet1.orderType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.kursDataSet1.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.orderType". При необходимости она может быть перемещена или удалена.
            this.orderTypeTableAdapter.Fill(this.kursDataSet1.orderType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.Zayavki". При необходимости она может быть перемещена или удалена.
            this.zayavkiTableAdapter.Fill(this.kursDataSet1.Zayavki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.orderType". При необходимости она может быть перемещена или удалена.
            this.orderTypeTableAdapter.Fill(this.kursDataSet.orderType);

            SqlCommand cmd = new SqlCommand("SELECT dbo.orderType.name AS[Тип заявки], dbo.orderStatus.name AS Статус, dbo.[order].creationDate AS Дата, " +
                " dbo.orderType.id AS idType, dbo.[order].id, dbo.[user].name AS Имя, dbo.[user].lastName AS Фамилия, " +
                " dbo.[user].middleName AS Отчество, dbo.[order].desDate AS[Дата решения] " +
                " FROM     dbo.[order] INNER JOIN " +
                " dbo.orderType ON dbo.[order].orderTypeId = dbo.orderType.id INNER JOIN " +
                " dbo.orderStatus ON dbo.[order].statusId = dbo.orderStatus.id INNER JOIN " +
                " dbo.[user] ON dbo.[order].userId = dbo.[user].id " +
                "where[order].[userId] = @id", db.getConnection());
            if (userIsAdmin == "1")
            {
                button1.Show();
                button3.Show();
                button4.Show();
                cmd = new SqlCommand("SELECT dbo.orderType.name AS [Тип заявки], dbo.orderStatus.name AS Статус, dbo.[order].creationDate AS Дата," +
                " dbo.orderType.id AS idType, dbo.[order].id, dbo.[user].name AS Имя, dbo.[user].lastName AS Фамилия, " +
                " dbo.[user].middleName AS Отчество, dbo.[order].desDate AS[Дата решения] " +
                " FROM     dbo.[order] INNER JOIN " +
                " dbo.orderType ON dbo.[order].orderTypeId = dbo.orderType.id INNER JOIN " +
                " dbo.orderStatus ON dbo.[order].statusId = dbo.orderStatus.id INNER JOIN " +
                " dbo.[user] ON dbo.[order].userId = dbo.[user].id " +
                    "where [order].[statusID] = 3", db.getConnection());
                label2.Text = "Список заявок";
            }
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
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
                "where[order].[userId] = @id", db.getConnection());
            if (userIsAdmin == "1")
            {
                cmd = new SqlCommand("SELECT dbo.orderType.name AS [Тип заявки], dbo.orderStatus.name AS Статус, dbo.[order].creationDate AS Дата," +
                " dbo.orderType.id AS idType, dbo.[order].id, dbo.[user].name AS Имя, dbo.[user].lastName AS Фамилия, " +
                " dbo.[user].middleName AS Отчество, dbo.[order].desDate AS[Дата решения] " +
                " FROM     dbo.[order] INNER JOIN " +
                " dbo.orderType ON dbo.[order].orderTypeId = dbo.orderType.id INNER JOIN " +
                " dbo.orderStatus ON dbo.[order].statusId = dbo.orderStatus.id INNER JOIN " +
                " dbo.[user] ON dbo.[order].userId = dbo.[user].id " +
                    "where[order].[statusID] = 3", db.getConnection());
            }
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString() == "В рассмотрении")
            {
                ZayavkiChange zayavkiChange = new ZayavkiChange(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                zayavkiChange.FormClosed += new FormClosedEventHandler(Snils_FormClosing);
                zayavkiChange.ShowDialog();
            }
            else
            {
                MessageBox.Show("Эту заявку нельзя изменить");
            }
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
    }
}
