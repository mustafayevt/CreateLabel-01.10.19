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
        
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Size = new Size(100, 50);
            button.Location = e.Location;
            button.Text = "HAKUNA";
            Controls.Add(button);
            button.MouseClick += Button_MouseClick;
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.Dispose();
        }
    }
}
