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
    public partial class FormRectcs : Form
    {
        public FormRectcs()
        {
            InitializeComponent();
        }

        private void textBoxSide1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(textBoxSide1.Text);
                double side2 = double.Parse(textBoxSide2.Text);

                double area = side1 * side2;
                double perimeter = 2 * (side1 + side2);
                labelArea.Text = area.ToString();
                labelPerimeter.Text = perimeter.ToString();
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

                double area = side1 * side2;
                double perimeter = 2 * (side1 + side2);
                labelArea.Text = area.ToString();
                labelPerimeter.Text = perimeter.ToString();
            }
            catch
            {
                if (textBoxSide2.Text.Length != 0)
                {    
                textBoxSide2.Text = textBoxSide2.Text.Substring(0, textBoxSide2.TextLength - 1);
                }
                
            }
        }

        private void buttonMoveToTriangle_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void buttonMoveToSphere_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void FormRectcs_Load(object sender, EventArgs e)
        {

        }
    }
}
