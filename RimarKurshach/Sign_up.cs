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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

 

        private void regButton_Click(object sender, EventArgs e)
        {
            string regLogin = regLoginField.Text;
            string regGroup = regGroupField.Text;
            string regPass = regPassField.Text;
            string regPass2 = regPassField2.Text;
                if (regPass != regPass2)
                MessageBox.Show("Пароли не совпадают");
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `students` (`login`, `password`, `group`) VALUES ( @Login2, @password2, @group2);",db.getConnection());
            command.Parameters.Add("@login2", MySqlDbType.VarChar).Value = regLogin;
            command.Parameters.Add("@password2", MySqlDbType.VarChar).Value = regPass;
            command.Parameters.Add("@group2", MySqlDbType.VarChar).Value = regGroup;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1 && regLoginField.Text != "" && regGroupField.Text != "" && regPassField.Text != "" && regPassField2.Text != "")
                MessageBox.Show("Вы успешно зарегестрированы");
            else
                MessageBox.Show("Регистрация не удалась");
            db.closeConnection();
            this.Hide();

        }
    }
}
