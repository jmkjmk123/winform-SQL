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
    public partial class Form6 : Form
    {
        Form1 form;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(Form1 _form)
        {
            InitializeComponent();
            form = _form;
        }
    }
}
