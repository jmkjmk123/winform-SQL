using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformSQL
{
    public partial class Form2 : Form
    {
        Form1 form;
        string testID = "jmkjmk";
        string testPWD = "1234";
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 _form)
        {
            InitializeComponent();
            form = _form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==testID && textBox2.Text == testPWD)
            {
                MessageBox.Show("Login Success");
                form.curID.Append(textBox1.Text);
                this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid Account");
                
            }
        }
    }
}
