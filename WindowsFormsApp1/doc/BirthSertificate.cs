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
    public partial class BirthSertificate : Form
    {
        string userId;
        public BirthSertificate(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand cmd = new SqlCommand("Insert into [birthSertificate] ([userId],[dateOfIssue], [number], [issuedBy], [mother], [father])" +
                " values (@id, @date, @number, @by, @mother, @father)", db.getConnection());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = textBox1.Text;
            cmd.Parameters.Add("@number", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@by", SqlDbType.VarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@mother", SqlDbType.VarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@father", SqlDbType.VarChar).Value = textBox5.Text;
            db.openConnection();
            try
            {
               cmd.ExecuteNonQuery();
               MessageBox.Show("Свидетельство о рождении добавлено");
            }
            catch
            {
                MessageBox.Show("Ошибка данные не введены");
            }
            db.closeConnection();
        }
    }
}
