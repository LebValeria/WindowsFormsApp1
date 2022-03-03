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
    public partial class Passport : Form
    {
        string userId;
        public Passport(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand cmd = new SqlCommand("Insert into [passport] ([userId],[series],[number],[dateOfIssue]) values (@id, @series, @number, @date)", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@series", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@number", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = textBox3.Text;
            db.openConnection();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Паспорт добавлен");
            }
            catch
            {
                MessageBox.Show("Ошибка данные не введены");
            }
            db.closeConnection();
        }
    }
}
