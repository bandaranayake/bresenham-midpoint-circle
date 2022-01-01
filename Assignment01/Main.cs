using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class Main : Form
    {
        private Form canvas;

        public Main()
        {
            InitializeComponent();
        }

        private Graphics Init()
        {
            if (canvas == null || canvas.IsDisposed)
            {
                canvas = new Form();
                canvas.Size = new Size(600, 600);
                canvas.BackColor = Color.White;
                canvas.Text = "Canvas";
                canvas.Show();
            }

            Graphics g = canvas.CreateGraphics();
            g.Clear(Color.White);

            return g;
        }

        private void Draw(Graphics g, int cx, int cy, int x, int y)
        {
            g.FillRectangle(Brushes.Black, x + cx, y + cy, 1, 1);
            g.FillRectangle(Brushes.Black, x + cx, -y + cy, 1, 1);
            g.FillRectangle(Brushes.Black, -x + cx, -y + cy, 1, 1);
            g.FillRectangle(Brushes.Black, -x + cx, y + cy, 1, 1);
            g.FillRectangle(Brushes.Black, y + cx, x + cy, 1, 1);
            g.FillRectangle(Brushes.Black, y + cx, -x + cy, 1, 1);
            g.FillRectangle(Brushes.Black, -y + cx, -x + cy, 1, 1);
            g.FillRectangle(Brushes.Black, -y + cx, x + cy, 1, 1);
        }

        private void Bresenhams(int cx, int cy, int r)
        {
            Graphics g = Init();

            int x = 0, y = r;
            int p = 3 - 2 * r;

            Draw(g, cx, cy, x, y);

            while (x < y)
            {
                if (p < 0)
                {
                    p = p + (4 * x) + 6;
                }
                else
                {
                    p = p + (4 * (x - y)) + 10;
                    y--;
                }

                x++;

                Draw(g, cx, cy, x, y);
            }
        }

        private void Midpoint(int cx, int cy, int r)
        {
            Graphics g = Init();

            int x = 0, y = r;
            int p = 1 - r;

            Draw(g, cx, cy, x, y);

            while (x < y)
            {
                if (p < 0)
                {
                    p = p + (2 * (x + 1)) + 1;
                }
                else
                {
                    p = p + (2 * (x + 1)) - (2 * (y - 1)) + 1;
                    y--;
                }

                x++;

                Draw(g, cx, cy, x, y);
            }
        }

        private void BtnBresenham_Click(object sender, EventArgs e)
        {
            string[] splited = txtCenter.Text.Split(',');
            Bresenhams(int.Parse(splited[0]), int.Parse(splited[1]), int.Parse(txtRadius.Text));
        }

        private void BtnMidpoint_Click(object sender, EventArgs e)
        {
            string[] splited = txtCenter.Text.Split(',');
            Midpoint(int.Parse(splited[0]), int.Parse(splited[1]), int.Parse(txtRadius.Text));
        }
    }
}
