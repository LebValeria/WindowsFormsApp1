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
    public partial class dataZayavka : Form
    {
        public dataZayavka()
        {
            InitializeComponent();
        }

        private void dataZayavka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.orderType". При необходимости она может быть перемещена или удалена.
            this.orderTypeTableAdapter.Fill(this.kursDataSet.orderType);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand cmd = new SqlCommand("select docs.name " +
                " from[orderTypeDocs] inner join orderType on[orderType].[id] = [orderTypeDocs].[ordertypeId] inner join[docs] on docs.id = ordertypeDocs.iddocs " +
                " where orderType.id = @type ", db.getConnection());
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = comboBox1.SelectedValue;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            string text = null;
            foreach (DataRow row in table.Rows)
            {
                text += row["name"] + ", ";
            }
            if (text != null)
            {
                text = text.Remove(text.Length - 2);
                MessageBox.Show("Для одобрения заявки необходими заполнить:" + text + ".");
            }
            else
            {
                MessageBox.Show("Для заявки не требуются заполнять документы.");
            }
        }
    }
}
