using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOOZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//coded by=alimousavi // instagram=1_alimousavi_1   telegram=alimousavi_1

        private void button2_Click(object sender, EventArgs e)
        {
            two_p t = new two_p();
            t.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
