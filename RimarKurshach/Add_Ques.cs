using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RimarKurshach
{
    public partial class Add_Ques : Form
    {
        public Add_Ques()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Add_quest_click(object sender, EventArgs e)
        {
            string questionField = "\n" + question.Text + "\n";
            string rightAswerField = rightAnswer.Text + "\n";
            string wrongAnswerField = wrongAnswer.Text + "\n";
            string wrongAnswerField2 = wrongAnswer2.Text;
            File.AppendAllText("t.txt", questionField);
            File.AppendAllText("t.txt", rightAswerField);
            File.AppendAllText("t.txt", wrongAnswerField);
            File.AppendAllText("t.txt", wrongAnswerField2);
        }
    }
}
