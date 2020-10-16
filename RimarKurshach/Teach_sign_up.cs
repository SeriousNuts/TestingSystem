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
    public partial class Teach_sign_up : Form
    {
        public Teach_sign_up()
        {
            InitializeComponent();
        }
        private void Teacher_button_Click(object sender, EventArgs e)
        {
            string TeacherLogin = Teacher_login_field.Text;
            string TeacherPass = Teacher_pass_field.Text;
            Add_Ques form = new Add_Ques();
            DB db = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teachers` WHERE `login` = @tL AND `password`=@tP", db.getConnection());
            command.Parameters.Add("@tL",MySqlDbType.VarChar).Value = TeacherLogin;
            command.Parameters.Add("@tP",MySqlDbType.VarChar).Value = TeacherPass;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable); 
            if (dataTable.Rows.Count > 0)   
            {
                MessageBox.Show("Вы успешно вошли в систему");
                this.Hide();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
