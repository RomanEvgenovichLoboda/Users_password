using Lesson0204.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson0204.MyFolder
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        public SignIn(int i)
        {
            InitializeComponent();
            label1.Text = "Lodin";
            button1.Text = "SignIn";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("empty line"); }
            else
            {
                Registr reg = new Registr();
                if (button1.Text == "SignIn")
                {

                    this.Close();
                }
                else
                {
                    reg.Regestration(textBox1.Text, textBox2.Text);
                    this.Close();
                }
            } 
        }
    }
}
