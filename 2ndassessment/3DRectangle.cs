using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _2ndassessment
{
    public class _3DRectangle: IShape
    {

        public int x, y, width, height;


        public _3DRectangle(): base()
        {
            width = 0;
            height = 0;
        }

        public _3DRectangle(int x, int y, int width, int height)
        {
            this.width = width;             
            this.height = height;
        }

        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Red);
                g.DrawRectangle(p, x - width, y - height, width * 2, height * 2);
                Brush bgBrush = new SolidBrush(Color.Blue);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                //Fill the background using Solid brush and then apply a white wash                  
                RectangleF rec = new RectangleF(x - width, y - height, width * 2, height * 2);                 
                g.FillRectangle(bgBrush, x - width, y - height, width * 2, height * 2);
                g.FillRectangle(new SolidBrush(Color.FromArgb(180, Color.White)), x - width, y - height, width * 2, height * 2);                 
                ControlPaint.DrawBorder3D(g, x - width, y - height, width * 2, height * 2, Border3DStyle.Raised); 

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.width = list[2];
                this.height = list[3];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
