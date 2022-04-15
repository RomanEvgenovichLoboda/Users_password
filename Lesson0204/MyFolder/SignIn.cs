using Lesson0204.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(textBox1.Text, pattern, RegexOptions.IgnoreCase))
            {
                if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("empty line"); }
                else
                {
                    Registr reg = new Registr();
                    if (button1.Text == "SignIn")
                    {
                        reg.signIn(textBox1.Text, textBox2.Text);
                        this.Close();
                    }
                    else
                    {
                        reg.Regestration(textBox1.Text, textBox2.Text);
                        this.Close();
                    }
                }
            }
            else { MessageBox.Show("Wrong email format"); }
           
        }
    }
}
