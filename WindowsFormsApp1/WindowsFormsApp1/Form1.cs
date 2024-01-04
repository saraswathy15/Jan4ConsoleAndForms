using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {// event of form //never repeat only in life of form 
            MessageBox.Show(" we are in form load event");
            Button b1 = new Button();
            b1.Text = "Our Button";
            b1.Height = 100;
            b1.Width = 200;
            b1.ForeColor = Color.Green;
            b1.BackColor = Color.Yellow;
            b1.Location = new Point(200, 200);
            b1.Click += B1_Click;
            this.Controls.Add(b1);
            //  b1.Show();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("our new button");
            // throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("u clicked on button");// allows to click
        }
    }
}

