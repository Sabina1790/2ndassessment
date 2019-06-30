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
    class Polygon: IShape
    {
        /// <summary>
        /// the integer value of x-axis, y-axis , width and height of rectange is decleared.
        /// </summary>
        public int x, y, width, height;


        /// <summary>
        /// provides width and height of rectangle
        /// </summary>
        public Polygon() : base()
        {
            width = 0;
            height = 0;
        }

        /// <summary>
        /// it is required to pass integer values of x-axis, y-axis, width and height
        /// </summary>
        /// <param name="x">x-axis</param>
        /// <param name="y">y-axis</param>
        /// <param name="width">rectangle's width</param>
        /// <param name="height">rectangl's height</param>
        public Polygon(int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// used to draw polygon
        /// </summary>
        /// <param name="g">Graphics</param>
        public void draw(Graphics g)
        {
            //try
            //{
            //    Pen p = new Pen(Color.Black, 2); g.DrawPolygon(p, x - (width / 3), y - (height / 2), width * 3, height * 2);
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}

            Point[] p = new Point[4];
            p[0].X = x;
            p[0].Y = y - (height / 1);

            p[1].X = x - (width / 2);
            p[1].Y = y + (height / 2);

            p[2].X = x + (width / 3);
            p[2].Y = y + (height / 3);

            p[3].X = x + (width / 1);
            p[3].Y = y + (height / 1);


            Pen po = new Pen(Color.Black, 2);
            g.DrawPolygon(po, p);

        }


        /// <summary>
        /// useds to set value of x,y,width and height of polygon
        /// </summary>
        /// <param name="list">set parameter</param>
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

