using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0625
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2;
            MessageBox.Show(""+(10/a));
            mybutton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
