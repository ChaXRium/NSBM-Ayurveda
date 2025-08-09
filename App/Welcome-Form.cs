using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; // no border
            this.BackColor = Color.DarkSlateBlue; // any color you like
            this.StartPosition = FormStartPosition.CenterScreen;

            // Make the corners rounded when form loads
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cornerRadius = 30; // how much curve
            GraphicsPath path = new GraphicsPath();

            // Top-left corner
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            // Top-right corner
            path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            // Bottom-right corner
            path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            // Bottom-left corner
            path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            path.CloseFigure();

            this.Region = new Region(path); // Apply rounded shape
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }
    }
}
