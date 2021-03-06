using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFigureWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var point = new frm_point();
            point.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*var line = new frm_line();
            line.Show();*/
            var paper = panel2.CreateGraphics();
            var pen = new Pen(Color.Red, 50);
            paper.DrawLine(pen, 60, 60, 80, 100);
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            /* var triangle = new frm_triangle();
             triangle.Show();*/
            var paper = panel2.CreateGraphics();
            var pen = new Pen(Color.Black, 24);
            paper.DrawLine(pen, 60, 60, 180, 500);
            paper.DrawLine(pen, 180, 500, 390, 510);
            paper.DrawLine(pen, 390, 510, 60, 60);
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            var rectangle = new frm_rectangle();
            rectangle.Show();
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            var circle = new frm_circle();
            circle.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
