using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RimarKurshach
{
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }


        private void Login_button_click(object sender, EventArgs e)
        {
            string loginUser = login_field.Text;
            string passUser = password_field.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `students` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP",MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы вошли в систему");
                this.Hide();
                FormTest form = new FormTest();
                form.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this. Hide();
            Sign_up form = new Sign_up();
            form.Show();
        }

        private void TeacherButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teach_sign_up form = new Teach_sign_up();
            this.Hide();
            form.Show();

        }
    }
}
 