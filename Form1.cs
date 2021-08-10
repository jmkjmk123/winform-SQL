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
    //main form//
    public partial class Form1 : Form
    {
        public StringBuilder curID {set; get;}
        Form2 loginForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label4.Text = curID;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loginForm = new Form2(this);
            loginForm.Show();
            this.Hide();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label4.Text = curID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 getSchedule = new Form3();
            getSchedule.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 setSchedule = new Form4();
            setSchedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 getPatient = new Form5();
            getPatient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 modifyAccount = new Form6(this);
            modifyAccount.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            loginForm = new Form2(this);
            curID.Clear();
            this.Hide();
            loginForm.Show();

        }
    }
}
