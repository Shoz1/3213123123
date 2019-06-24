using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_3
{
    public partial class Form1 : Form
    {
        Vector vector;

        public Form1()
        {
            InitializeComponent();

            vector = new Vector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vector.Ax = Convert.ToDouble(ax.Value);
            vector.Ay = Convert.ToDouble(ay.Value);
            vector.Az = Convert.ToDouble(az.Value);

            vector.Bx = Convert.ToDouble(bx.Value);
            vector.By = Convert.ToDouble(by.Value);
            vector.Bz = Convert.ToDouble(bz.Value);

            

            textBox1.Text = vector.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vector.Ax = Convert.ToDouble(ax.Value);
            vector.Ay = Convert.ToDouble(ay.Value);
            vector.Az = Convert.ToDouble(az.Value);

            vector.Bx = Convert.ToDouble(bx.Value);
            vector.By = Convert.ToDouble(by.Value);
            vector.Bz = Convert.ToDouble(bz.Value);

            textBox1.Text = vector.ToStringPlus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vector.Ax = Convert.ToDouble(ax.Value);
            vector.Ay = Convert.ToDouble(ay.Value);
            vector.Az = Convert.ToDouble(az.Value);

            vector.Bx = Convert.ToDouble(bx.Value);
            vector.By = Convert.ToDouble(by.Value);
            vector.Bz = Convert.ToDouble(bz.Value);


            textBox1.Text = vector.ToStringYmn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vector.Ax = Convert.ToDouble(ax.Value);
            vector.Ay = Convert.ToDouble(ay.Value);
            vector.Az = Convert.ToDouble(az.Value);

            vector.Bx = Convert.ToDouble(bx.Value);
            vector.By = Convert.ToDouble(by.Value);
            vector.Bz = Convert.ToDouble(bz.Value);


            textBox1.Text = vector.GetD();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vector.Ax = Convert.ToDouble(ax.Value);
            vector.Ay = Convert.ToDouble(ay.Value);
            vector.Az = Convert.ToDouble(az.Value);

            vector.Bx = Convert.ToDouble(bx.Value);
            vector.By = Convert.ToDouble(by.Value);
            vector.Bz = Convert.ToDouble(bz.Value);

            textBox1.Text = vector.GetC();
        }
    }
}
