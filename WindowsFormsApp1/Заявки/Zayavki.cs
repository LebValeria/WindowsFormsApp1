﻿using System;
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
            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                    "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                    "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]" +
                    "where[order].[userId] = @id", connection);
                if (userIsAdmin == "1")
                {
                    button1.Show();
                    button3.Show();
                    button4.Show();
                    cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]", connection);
                }
                
                
                
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                
            }
            

        }
        void Snils_FormClosing(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]" +
                "where[order].[userId] = @id", connection);
                if (userIsAdmin == "1")
                {
                    cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]", connection);
                }
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString() == "В рассмотрении" && userIsAdmin != "1")
            {
                ZayavkiChange zayavkiChange = new ZayavkiChange(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString(), dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString());
                zayavkiChange.FormClosed += new FormClosedEventHandler(Snils_FormClosing);
                zayavkiChange.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlCommand command = new SqlCommand("update [order] set [statusId] = '1' where [id] = @id", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            db.openConnection();
            command.ExecuteNonQuery();

            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]" +
                "where[order].[userId] = @id", connection);
                if (userIsAdmin == "1")
                {
                    cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]", connection);
                }
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlCommand command = new SqlCommand("update [order] set [statusId] = '2' where [id] = @id", db.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            db.openConnection();
            command.ExecuteNonQuery();

            string connectionString = @"Data Source=LAPTOPPC;Initial Catalog=Kurs;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]" +
                "where[order].[userId] = @id", connection);
                if (userIsAdmin == "1")
                {
                    cmd = new SqlCommand("SELECT [orderType].[name] AS 'Тип заявки', [orderStatus].[name] AS 'Статус', [order].[creationDate] AS 'Дата', [order].id, orderType.id AS 'typeId'" +
                "FROM [order] INNER JOIN [orderType] on [order].[orderTypeId] = [orderType].[id]" +
                "Inner Join dbo.[orderStatus] on [order].[statusId] = [orderStatus].[id]", connection);
                }
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
