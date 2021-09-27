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
    public partial class two_p : Form
    {
        public two_p()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }//coded by=alimousavi  //instagram=1_alimousavi_1 //telegram= alimousavi_1


        private void two_p_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ary[i, j] = 0;
        }
        int[,] ary = new int[3, 3];//public-ary
        int ap = 1;

        void set(Label lbl)//select
        {
            if (lbl.Text == "")
            {
                lbl.BackColor = Color.BlanchedAlmond;
            }
        }
        void unset(Label lbl)
        {
            lbl.BackColor = Color.Silver;
        }
        void sp()//chainging gamers
        {
            if (ap == 1)
            {
                ap = 2;
                lblnobat.Text = "بازیکن O";
            }

            else if (ap == 2)
            {
                ap = 1;
                lblnobat.Text = "بازیکن X";
            }

        }
        void add(Label lbl, int a, int x, int y)//writing x-o
        {//coded by=alimousavi  //instagram=1_alimousavi_1 //telegram= alimousavi_1

            int temp = 0;
            if (ary[x, y] == 0)
            {
                ary[x, y] = a;
                if (a == 1)
                    lbl.Text = "X";
                else if (a == 2)
                    lbl.Text = "O";
                restart();
                temp = ch();
                if (temp == 1 || temp == 2)
                {
                    if (temp == 1)
                        MessageBox.Show(" X  WINNED", "WINNER");
                    else if (temp == 2)
                        MessageBox.Show(" O  WINNED", "WINNER");
                    end(temp);
                }
                sp();
            }
        }

        int x = 0, o = 0;

        void end(int a)
        {
            if (a == 1)
                x++;
            else if (a == 2)
                o++;
            if (a == 1 || a == 2)
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        ary[i, j] = 0;
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                ap = 2;
                lblwinner.Text = string.Format("X=[{0}] , O=[{1}]", x, o);
            }

        }
        void restart()
        {
            string str = label1.Text + label2.Text + label3.Text + label4.Text + label5.Text + label6.Text + label7.Text + label8.Text + label9.Text;
            if (str.Length == 9)
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        ary[i, j] = 0;
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                ap = 2;
            }
        }

        Label show(int x, int y)
        {//coded by=alimousavi  //instagram=1_alimousavi_1 //telegram= alimousavi_1
            if (x == 0 && y == 1)
                return label2;
            else if (x == 0 && y == 0)
                return label1;
            else if (x == 0 && y == 2)
                return label3;
            else if (x == 1 && y == 0)
                return label4;
            else if (x == 1 && y == 1)
                return label5;
            else if (x == 1 && y == 2)
                return label6;
            else if (x == 2 && y == 0)
                return label7;
            else if (x == 2 && y == 1)
                return label8;
            else if (x == 2 && y == 2)
                return label9;
            return null;
        }

        int ch()//checking boxes
        {
            int temp = 0;
            for (int i = 0; i < 3; i++)
            {
                if ((ary[i, 0] == 1 && ary[i, 1] == 1 && ary[i, 2] == 1) || (ary[0, i] == 1 && ary[1, i] == 1 && ary[2, i] == 1))
                {
                    temp = 1;
                }
                else if ((ary[0, i] == 2 && ary[1, i] == 2 && ary[2, i] == 2) || (ary[i, 0] == 2 && ary[i, 1] == 2 && ary[i, 2] == 2))
                {
                    temp = 2;
                }
            }
            return temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            add(label1, ap, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            add(label2, ap, 0, 1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            add(label3, ap, 0, 2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            add(label4, ap, 1, 0);
        }//coded by=alimousavi  //instagram=1_alimousavi_1 //telegram= alimousavi_1

        private void label5_Click(object sender, EventArgs e)
        {
            add(label5, ap, 1, 1);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            add(label6, ap, 1, 2);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            add(label7, ap, 2, 0);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            add(label8, ap, 2, 1);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            add(label9, ap, 2, 2);
        }


        void ushow(Label lbl, Label lbl1, Label lbl2)
        {
            lbl.ForeColor = Color.Black;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {//coded by=alimousavi  //instagram=1_alimousavi_1 //telegram= alimousavi_1
            int s = int.Parse(lblsec.Text);
            int m = int.Parse(lblmin.Text);
            s++;

            lblsec.Text = s.ToString();
            if (s == 60)
            {
                m++;
                lblmin.Text = m.ToString();
                s = 0;
                lblsec.Text = s.ToString();
                if (m == 60)
                {
                    m = 0;
                    lblmin.Text = m.ToString();
                }

            }

        }

        //events
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            set(label1);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            set(label2);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            set(label3);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            set(label4);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            set(label5);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            set(label6);
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            set(label7);
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            set(label8);
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            set(label9);
        }

        /// ////////////////////

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            unset(label1);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            unset(label2);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            unset(label3);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            unset(label4);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            unset(label5);
        }
        //coded by=alimousavi  //instagram=1_alimousavi_1 //telegram= alimousavi_1
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            unset(label6);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            unset(label7);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            unset(label8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ary[i, j] = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            ap = 2;
            lblwinner.Text = "X=[0] , O=[0]";
            lblsec.Text = lblmin.Text = "0";
        }//coded by=alimousavi  //instagram=1_alimousavi_1 //telegram= alimousavi_1

        private void two_p_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            unset(label9);
        }
    }
}
