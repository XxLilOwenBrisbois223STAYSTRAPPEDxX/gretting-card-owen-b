using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace gretting_card_owen_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "greeting card";

            Graphics g = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White, 6);
            Pen blackPen = new Pen(Color.Black, 4);
            Pen bluePen = new Pen(Color.Blue, 40);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 25, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            g.Clear(Color.Blue);



            g.DrawEllipse(whitePen, 80, 180, 30, 30);
            g.DrawEllipse(whitePen, 75, 215, 45, 45);
            g.DrawEllipse(whitePen, 70, 260, 60, 60);

            g.DrawArc(whitePen, 45, 140, 100, 100, 30, 40);
            g.DrawArc(whitePen, -15, 160, 100, 100, 30, 40);



            g.DrawEllipse(whitePen, 280, 180, 30, 30);
            g.DrawEllipse(whitePen, 275, 215, 45, 45);
            g.DrawEllipse(whitePen, 270, 260, 60, 60);

            g.DrawArc(whitePen, 245, 140, 100, 100, 30, 40);
            g.DrawArc(whitePen, 185, 160, 100, 100, 30, 40);



            g.DrawEllipse(whitePen, 480, 180, 30, 30);
            g.DrawEllipse(whitePen, 475, 215, 45, 45);
            g.DrawEllipse(whitePen, 470, 260, 60, 60);

            g.DrawArc(whitePen, 445, 140, 100, 100, 30, 40);
            g.DrawArc(whitePen, 385, 160, 100, 100, 30, 40);



            g.DrawString("Do You Wanna Build A Snowman?", drawFont, drawBrush, 45, 40);

            label1.Text = "PLEASE..?";

            for (int i = 1; i <= 150; i++)
            {
                g.Clear(Color.Blue);



                g.DrawEllipse(whitePen, 80, 180, 30, 30);
                g.DrawEllipse(whitePen, 75, 215, 45, 45);
                g.DrawEllipse(whitePen, 70, 260, 60, 60);

                g.DrawArc(whitePen, 45, 140, 100, 100, 30, 40);
                g.DrawArc(whitePen, -15, 160, 100, 100, 30, 40);



                g.DrawEllipse(whitePen, 280, 180, 30, 30);
                g.DrawEllipse(whitePen, 275, 215, 45, 45);
                g.DrawEllipse(whitePen, 270, 260, 60, 60);

                g.DrawArc(whitePen, 245, 140, 100, 100, 30, 40);
                g.DrawArc(whitePen, 185, 160, 100, 100, 30, 40);



                g.DrawEllipse(whitePen, 480, 180, 30, 30);
                g.DrawEllipse(whitePen, 475, 215, 45, 45);
                g.DrawEllipse(whitePen, 470, 260, 60, 60);

                g.DrawArc(whitePen, 445, 140, 100, 100, 30, 40);
                g.DrawArc(whitePen, 385, 160, 100, 100, 30, 40);



                g.DrawString("Do You Wanna Build A Snowman?", drawFont, drawBrush, 45, 40);
                g.DrawRectangle(blackPen, 282, i, 25, 25);
                g.DrawRectangle(blackPen, 82, i, 25, 25);
                g.DrawRectangle(blackPen, 482, i, 25, 25);

                label1.Text = "PLEASE..?";

                Thread.Sleep(10);
               // Refresh();
            }








            g.DrawRectangle(blackPen, 282, 150, 25, 25);

            g.DrawRectangle(blackPen, 82, 150, 25, 25);

            g.DrawRectangle(blackPen, 482, 150, 25, 25);

            g.DrawLine(blackPen, 360, 180, 230, 180);

            g.DrawLine(blackPen, 160, 180, 30, 180);

            g.DrawLine(blackPen, 460, 180, 530, 180);


            g.DrawArc(blackPen, 270, 135, 50, 70, 60, 60);

            g.DrawArc(blackPen, 70, 135, 50, 70, 60, 60);

            g.DrawArc(blackPen, 470, 135, 50, 70, 60, 60);

            g.DrawRectangle(blackPen, 285, 188, 3, 3);

            g.DrawRectangle(blackPen, 300, 188, 3, 3);

            g.DrawRectangle(blackPen, 85, 188, 3, 3);

            g.DrawRectangle(blackPen, 100, 188, 3, 3);

            g.DrawRectangle(blackPen, 485, 188, 3, 3);

            g.DrawRectangle(blackPen, 500, 188, 3, 3);



        }
    }
}
