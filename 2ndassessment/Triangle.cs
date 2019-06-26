using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2ndassessment
{

    /// <summary>
    /// class decleared as triangle
    /// </summary>
   public class Triangle : IShape
    {
        /// <summary>
        /// integer values of x-axis, y_axis , width and height of trianle is decleared
        /// </summary>
        public int x, y, width, height;


        /// <summary>
        /// height and weight is passed of triangle.
        /// </summary>
        public Triangle() : base()
        {
            width = 0;
            height = 0;
        }

        /// <summary>
        /// declaration of fuction of triangle.
        /// </summary>
        /// <param name="x">x-axis</param>
        /// <param name="y">y-axis</param>
        /// <param name="width">triangle's width</param>
        /// <param name="height">triangle's height</param>
        public Triangle(int x, int y, int width, int height)
        { this.width = width;
            this.height = height; }


        /// <summary>
        /// used in drawing triangle on provided points
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {
            try
            {
                Point[] p = new Point[3];
                p[0].X = x;
                p[0].Y = y - (height / 2);

                p[1].X = x - (width / 2);
                p[1].Y = y + (height / 2);

                p[2].X = x + (width / 2);
                p[2].Y = y + (height / 2);
                Pen po = new Pen(Color.Black, 2);
                g.DrawPolygon(po, p);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// sets value of triangle
        /// </summary>
        /// <param name="list">list parameters</param>
        public void set(params int[] list)
        {
            this.x = list[0]; this.y = list[1];
            this.width = list[2];
            this.height = list[3];
        }
    }
    
}
