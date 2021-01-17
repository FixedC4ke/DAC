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

namespace lab3SovrIS
{
    public partial class AddUserForm : Form
    {
        private SqlConnection connection;
        public AddUserForm(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(String.Format("insert into Users values (newid(), '{0}', '{1}', {2})", textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text)), connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Пользователь " + textBox1.Text + "успешно добавлен");
            this.Close();
        }
    }
}
