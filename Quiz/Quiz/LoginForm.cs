using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();
               comboBox1.Items.AddRange(Form1.m.users.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1!=null)
            {
                //comboBox1.SelectedValue(users.ToString());
                Form1 newForm = new Form1();

                newForm.Show();
                this.Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проект делали: Егор Лявенко и Артем Ангалевич\n Идею подкинул:Артем Ангалевич");
        }
    }
}
 