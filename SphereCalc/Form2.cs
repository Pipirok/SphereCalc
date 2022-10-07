using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SphereCalc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxSide1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(textBoxSide1.Text);
                double side2 = double.Parse(textBoxSide2.Text);
                double side3 = double.Parse(textBoxSide3.Text);

                double p = (side1 + side2 + side3)/2;
                double area = (double)((int)(Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3))*100))/100;
                labelArea.Text = area.ToString();
                labelPerimeter.Text = (p*2).ToString();
            }
            catch
            {
                if (textBoxSide1.Text.Length != 0)
                {
                    textBoxSide1.Text = textBoxSide1.Text.Substring(0, textBoxSide1.TextLength - 1);
                }
            }
        }

        private void textBoxSide2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(textBoxSide1.Text);
                double side2 = double.Parse(textBoxSide2.Text);
                double side3 = double.Parse(textBoxSide3.Text);

                double p = (side1 + side2 + side3) / 2;
                double area = (double)((int)(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)) * 100)) / 100;
                labelArea.Text = area.ToString();
                labelPerimeter.Text = (p * 2).ToString();
            }
            catch
            {
                if (textBoxSide2.TextLength != 0)
                {
                    textBoxSide2.Text = textBoxSide2.Text.Substring(0, textBoxSide2.TextLength - 1);
                }
            }
        }

        private void textBoxSide3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(textBoxSide1.Text);
                double side2 = double.Parse(textBoxSide2.Text);
                double side3 = double.Parse(textBoxSide3.Text);

                double p = (side1 + side2 + side3) / 2;
                double area = (double)((int)(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)) * 100)) / 100;
                labelArea.Text = area.ToString();
                labelPerimeter.Text = (p * 2).ToString();
            }
            catch
            {
                if (textBoxSide3.TextLength != 0)
                {
                    textBoxSide3.Text = textBoxSide3.Text.Substring(0, textBoxSide3.TextLength - 1);
                }
            }
        }

        private void buttonMoveToSphere_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void buttonMoveToRectangle_Click(object sender, EventArgs e)
        {
            FormRectcs f = new FormRectcs();
            f.Show();
            this.Hide();
        }
    }
}
