using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Point mousePointDown { get; private set; } = new Point();
        public Point mousePointUp { get; private set; } = new Point();
        public static int count { get; private set; } = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePointDown = (e as MouseEventArgs).Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePointUp = (e as MouseEventArgs).Location;
                Label label = new Label();
                Random rand = new Random();
                label.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                label.Text = count.ToString();
                count++;
                label.Location = mousePointUp;
                if (mousePointUp.X == mousePointDown.X && mousePointUp.Y == mousePointDown.Y) label.Size = new Size(10, 10);
                else
                {
                    Point labelPoint = new Point();
                    if (mousePointUp.X < mousePointDown.X)
                    {
                        labelPoint.X = mousePointDown.X - mousePointUp.X;
                        labelPoint.Y = mousePointDown.Y - mousePointUp.Y;
                        label.Location = mousePointUp;
                    }
                    else
                    {
                        labelPoint.X = mousePointUp.X - mousePointDown.X;
                        labelPoint.Y = mousePointUp.Y - mousePointDown.Y;
                        label.Location = mousePointDown;
                    }
                    label.Size = new Size(labelPoint);
                }
                Controls.Add(label);
            }
        }
    }
}
