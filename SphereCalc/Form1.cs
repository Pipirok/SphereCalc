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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double radius =Math.Abs(double.Parse(textboxRadius.Text));


                // Makeshift double-point precision
                // P.S. unless explicitly type-casted, C# uses int division,
                // returning an integer instead of a double
                double surface = (double)(int)(4 * Math.Pow(radius, 2)*100)/100;
                double volume = (double)(int)((((double)4 / (double)3)*Math.Pow(radius, 3))*100)/100;

                labelArea.Text = $"{surface} π";
                labelVolume.Text = $"{volume} π";
            }
            catch
            {
                labelArea.Text = "";
                labelVolume.Text = "";
                textboxRadius.Text = "";
            }
        }

        private void buttonMoveToRectangle_Click(object sender, EventArgs e)
        {
            FormRectcs f = new FormRectcs();
            f.Show();
            Hide();
        }

        private void buttonMoveToTriangle_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
