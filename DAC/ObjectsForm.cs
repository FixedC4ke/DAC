using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3SovrIS
{
    public partial class ObjectsForm : Form
    {
        private User currentuser;
        private SqlConnection connection;
        private bool addmode;
        public ObjectsForm(SqlConnection connection, User user)
        {
            this.connection = connection;
            this.currentuser = user;
            addmode = false;
            InitializeComponent();
        }

        private void ObjectsForm_Load(object sender, EventArgs e)
        {
            objectlistBox.Items.Clear();
            SqlCommand command = null;
            if (currentuser.Privelege == 1)
            {
                command = new SqlCommand(String.Format("select Objects.ID, Objects.Name from Access inner join Objects on Objects.ID=Access.ObjectID where UserID='{0}'", currentuser.ID), connection);
            }
            else if (currentuser.Privelege == 15)
            {
                command = new SqlCommand("select Objects.ID, Objects.Name from Objects", connection);
                addUserbutton.Visible = true;
            }
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    objectlistBox.Items.Add(new MyObj(dr.GetGuid(0), dr.GetString(1)));
                }
            }
            objectlistBox.DisplayMember = "Name";
            objectlistBox.ValueMember = "ID";
            dr.Close();
        }

        private void objectlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectlistBox.SelectedIndex == -1) return;

            foreach (Label label in this.Controls.OfType<Label>()) label.Enabled = true;
            nametextBox.Enabled = datarichTextBox.Enabled = true;

            if (currentuser.Privelege == 1)
            {
                SqlCommand command = new SqlCommand(String.Format("select Access.*, Objects.Name, Objects.Data from Access inner join Objects on Objects.ID=Access.ObjectID where Objects.ID='{0}' and Access.UserID='{1}'", ((MyObj)objectlistBox.SelectedItem).ID.ToString(), currentuser.ID.ToString()), connection);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    nametextBox.Text = dr.GetString(6);

                    toolStripStatusLabel1.Text = "Права текущего пользователя на выбранный файл: "
                        + (dr.GetBoolean(2) ? "read " : "")
                        + (dr.GetBoolean(3) ? "write " : "")
                        + (dr.GetBoolean(4) ? "own " : "")
                        + (dr.GetBoolean(5) ? "tg" : "");

                    if (dr.GetBoolean(2))
                    {
                        datarichTextBox.Text = dr.GetString(7);
                    }
                    else
                    {
                        datarichTextBox.Text = "Права на чтение отсутствуют";
                    }

                    if (dr.GetBoolean(3)) { savebutton.Enabled = true; }
                    else
                    {
                        savebutton.Enabled = false;
                    }

                    comboBox1.Enabled = readcheckBox.Enabled = writecheckBox.Enabled = dr.GetBoolean(5);
                    delbutton.Enabled = tgcheckBox.Enabled = owncheckBox.Enabled = dr.GetBoolean(4);

                    if (dr.GetBoolean(5))
                    {
                        dr.Close();
                        SqlCommand getusers = new SqlCommand("select ID, Name from Users where Name not in ('admin','" + currentuser.Name + "')", connection);
                        SqlDataReader gudr = getusers.ExecuteReader();
                        comboBox1.Items.Clear();
                        if (gudr.HasRows)
                        {
                            while (gudr.Read())
                            {
                                comboBox1.Items.Add(new User(gudr.GetGuid(0), gudr.GetString(1)));
                            }
                        }
                        gudr.Close();
                        comboBox1.DisplayMember = "Name";
                        comboBox1.ValueMember = "ID";
                        comboBox1.SelectedIndex = 0;
                        changeaccbutton.Enabled = true;
                    }
                    else { dr.Close(); changeaccbutton.Enabled = false; }
                }
            }
            else if (currentuser.Privelege == 15)
            {
                toolStripStatusLabel1.Text = "Выполнен вход с правами администратора";
                foreach (Control c in this.Controls) c.Enabled = true;
                SqlCommand command = new SqlCommand(String.Format("select Name, Data from Objects where ID='{0}'", ((MyObj)objectlistBox.SelectedItem).ID.ToString()), connection);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    nametextBox.Text = dr.GetString(0);
                    datarichTextBox.Text = dr.GetString(1);
                }
                dr.Close();
                SqlCommand getusers = new SqlCommand("select ID, Name from Users where Name not in ('admin','" + currentuser.Name + "')", connection);
                SqlDataReader gudr = getusers.ExecuteReader();
                comboBox1.Items.Clear();
                if (gudr.HasRows)
                {
                    while (gudr.Read())
                    {
                        comboBox1.Items.Add(new User(gudr.GetGuid(0), gudr.GetString(1)));
                    }
                }
                gudr.Close();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(String.Format("select Access.R, Access.W, Access.OWN, Access.TG from Access " +
                "inner join Objects on Objects.ID=Access.ObjectID " +
                "inner join Users on Users.ID=Access.UserID where Objects.ID='{0}' and Users.Name='{1}'", ((MyObj)objectlistBox.SelectedItem).ID.ToString(), ((User)comboBox1.SelectedItem).Name.ToString()), connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                readcheckBox.Checked = dr.GetBoolean(0);
                writecheckBox.Checked = dr.GetBoolean(1);
                owncheckBox.Checked = dr.GetBoolean(2);
                tgcheckBox.Checked = dr.GetBoolean(3);
                dr.Close();
            }
            else
            {
                readcheckBox.Checked = writecheckBox.Checked = owncheckBox.Checked = tgcheckBox.Checked = false;
            }
            dr.Close();
        }

        private void createobjbutton_Click(object sender, EventArgs e)
        {
            SetAddMode(true);
        }

        private void SetAddMode(bool mode)
        {
            objectlistBox.Enabled = createobjbutton.Enabled = !mode;
            addmode = nametextBox.Enabled = datarichTextBox.Enabled = savebutton.Enabled = mode;
            if (mode)
            {
                comboBox1.Enabled = changeaccbutton.Enabled = readcheckBox.Enabled = writecheckBox.Enabled = owncheckBox.Enabled = tgcheckBox.Enabled = false;
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (addmode)
            {
                Guid newid = Guid.NewGuid();
                SqlCommand command1 = new SqlCommand(String.Format("insert into Objects values ('{0}', '{1}', '{2}')", newid.ToString(), nametextBox.Text, datarichTextBox.Text), connection);
                SqlCommand command2 = new SqlCommand(String.Format("insert into Access values ('{0}', '{1}', {2}, {3}, {4}, {5})", currentuser.ID.ToString(), newid, 1, 1, 1, 1), connection);
                command1.ExecuteNonQuery();
                if (currentuser.Privelege==1) command2.ExecuteNonQuery();
                MessageBox.Show("Объект успешно добавлен");
                SetAddMode(false);
            }
            else
            {
                SqlCommand command = new SqlCommand(String.Format("update Objects set Name='{0}', Data='{1}' where ID='{2}'", nametextBox.Text, datarichTextBox.Text, ((MyObj)objectlistBox.SelectedItem).ID.ToString()), connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Объект успешно изменен");
            }
            this.OnLoad(e);
        }

        private void changeaccbutton_Click(object sender, EventArgs e)
        {
            if (currentuser.Privelege == 1 && owncheckBox.Checked)
            {
                if (MessageBox.Show("Вы потеряете право собственности на указанный объект, передав его другому пользователю. Вы действительно хотите продолжить?",
            "Передача права собственности",
            MessageBoxButtons.YesNo
            ) == DialogResult.Yes)
                {
                    SqlCommand remown = new SqlCommand(String.Format("update Access set OWN='False' where UserID='{0}' and ObjectID='{1}'", currentuser.ID.ToString(), ((MyObj)objectlistBox.SelectedItem).ID.ToString()), connection);
                    remown.ExecuteNonQuery();
                }
                else return;
            }

            SqlCommand command = new SqlCommand(String.Format("select Access.* from Access inner join Users on Access.UserID=Users.ID where Users.Name='{0}' and Access.ObjectID='{1}'", ((User)comboBox1.SelectedItem).Name.ToString(), ((MyObj)objectlistBox.SelectedItem).ID.ToString()), connection);
            SqlDataReader dr = command.ExecuteReader();


            if (dr.HasRows)
            {
                dr.Close();

                SqlCommand upd = new SqlCommand(String.Format("update Access set R='{0}', W='{1}', OWN='{2}', TG='{3}' where UserID='{4}' and ObjectID='{5}'", readcheckBox.Checked, writecheckBox.Checked, owncheckBox.Checked, tgcheckBox.Checked, ((User)comboBox1.SelectedItem).ID.ToString(), ((MyObj)objectlistBox.SelectedItem).ID.ToString()), connection);
                upd.ExecuteNonQuery();
            }
            else
            {
                dr.Close();
                SqlCommand upd = new SqlCommand(String.Format("insert into Access values('{4}', '{5}', '{0}', '{1}', '{2}', '{3}')", readcheckBox.Checked, writecheckBox.Checked, owncheckBox.Checked, tgcheckBox.Checked, ((User)comboBox1.SelectedItem).ID.ToString(), ((MyObj)objectlistBox.SelectedItem).ID.ToString()), connection);
                upd.ExecuteNonQuery();
            }
            MessageBox.Show("Права доступа успешно изменены");
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный объект?", "Удаление объекта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand(String.Format("delete from Objects where ID='{0}'", ((MyObj)objectlistBox.SelectedItem).ID.ToString()), connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Объект успешно удален");
                this.OnLoad(e);
            }
        }

        private void addUserbutton_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm(connection);
            addUser.ShowDialog();
        }
    }
}