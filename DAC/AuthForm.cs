using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab3SovrIS
{
    public partial class AuthForm : Form
    {
        private string connectionString;
        private SqlConnection connection;
        public AuthForm()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=DiscrAccess;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            userPickListBox.Items.Clear();
            SqlCommand command = new SqlCommand("select * from Users order by Name asc", connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    userPickListBox.Items.Add(dr.GetValue(1).ToString());
                }
            }
            dr.Close();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (userPickListBox.SelectedIndex == -1) return;
            SqlCommand command = new SqlCommand("select * from Users where Name='" + userPickListBox.SelectedItem.ToString()+"'", connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                if (passtextBox.Text==dr.GetValue(2).ToString())
                {
                    User user = new User() { ID=Guid.Parse(dr.GetValue(0).ToString()), Name = dr.GetValue(1).ToString(), Privelege = Int32.Parse(dr.GetValue(3).ToString()) };
                    ObjectsForm obf = new ObjectsForm(connection, user);
                    dr.Close();
                    obf.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Введен неверный пароль");
                }
            }
            passtextBox.Text = "";
        }

        private void userPickListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            submitbutton.Enabled = passtextBox.Enabled = userPickListBox.SelectedIndex != -1;
        }

        private void AuthForm_Activated(object sender, EventArgs e)
        {
            this.OnLoad(e);
        }
    }
}
