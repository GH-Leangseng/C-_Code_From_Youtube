using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = email.Text;
            string pw = password.Text;
            if(mail == "lyleangseng@gmail.com" && pw == "leangseng")
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry your email and Pw invalid data ");
            }
        }
    }
}
