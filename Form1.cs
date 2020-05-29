﻿using FakeItEasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kleine_Kästchen
{
    public partial class Form1 : Form
    {
        int g ;
        int k ;
        int x ;
        int y ;
        int z=40 ;
        int w=40 ;
        int h ;
        


        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_RectangleYellow(KeyPressEventArgs e)
        {
            
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            x = g * 40;
            k = h % 10;
            y = k * 40;
                       
           formGraphics.FillRectangle(myBrush, new Rectangle(x, y, z, w));
          
        }
        private void Form1_RectangleBlue(KeyPressEventArgs e)
        {
           
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            x = g * 40;
            k = h % 10;
            y = k * 40;

            formGraphics.FillRectangle(myBrush, new Rectangle(x, y, z, w));
           
        }
        private void Form1_RectangleWhite(KeyPressEventArgs e)
        {

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            x = g * 40;
            k = h % 10;
            y = k * 40;

            formGraphics.FillRectangle(myBrush, new Rectangle(x, y, z, w));

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {

                Form1_RectangleYellow(e);
                g += 1;

                if (g == 10)
                {
                    g = 0;
                    h++;
                }
            }
            else if (e.KeyChar == 'b' || e.KeyChar == 'B')
            {

                Form1_RectangleBlue(e);
                g += 1;

                if (g == 10)
                {
                    g = 0;
                    h++;
                }

            }

            else if (e.KeyChar == (char)Keys.Back)
            {
                // Ein Quadrat löchen
                if (g > 0)
                {
                    --g;
                    Form1_RectangleWhite(e);

                }
                else
                {
                    h--;
                    g = 9;
                    Form1_RectangleWhite(e);


                }
            }
            else
            {
                // Do nothing;
            }
        }
    }
}
