using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint_v0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            canvas = mainPanel.CreateGraphics();
        }
        Graphics canvas;

        bool paint = false;
        int? x = null;
        int? y = null;

        bool sqr = false;
        bool circle = false;
        bool rect = false;

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                Pen pen = new Pen(penColorBtn.BackColor);
                pen.Width = (float)penWidth.Value;

                canvas.DrawLine(pen, new Point(x ?? e.X, y ?? e.Y), new Point(e.X, e.Y));
                x = e.X;
                y = e.Y;
            }
        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            rect = true;
        }

        private void sqrBtn_Click(object sender, EventArgs e)
        {
            sqr = true;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            circle = true;
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;

            if (sqr)
            {
                SolidBrush brush = new SolidBrush(penColorBtn.BackColor);

                canvas.FillRectangle(brush, e.X, e.Y, (float)shapeWidth.Value, (float)shapeWidth.Value);
                paint = false;
                sqr = false;
            }

            if (rect)
            {
                SolidBrush brush = new SolidBrush(penColorBtn.BackColor);

                canvas.FillRectangle(brush, e.X, e.Y, (float)shapeWidth.Value, (float)shapeHeight.Value);
                paint = false;
                rect = false;
            }

            if (circle)
            {
                SolidBrush brush = new SolidBrush(penColorBtn.BackColor);

                canvas.FillEllipse(brush, e.X, e.Y, (float)shapeWidth.Value, (float)shapeWidth.Value);
                paint = false;
                circle = false;
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            x = null;
            y = null;
        }

        private void penColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                penColorBtn.BackColor = dialog.Color;
            }
        }

        private void clearCanvasBtn_Click(object sender, EventArgs e)
        {
            canvas.Clear(mainPanel.BackColor);
            mainPanel.BackColor = Color.White;
            canvasColorBtn.BackColor = Color.White;
        }

        private void canvasColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                canvasColorBtn.BackColor = dialog.Color;
                mainPanel.BackColor = canvasColorBtn.BackColor;
            }
        }
    }
}
