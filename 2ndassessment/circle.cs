using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2ndassessment
{
    /// <summary>
    /// holds commands of class: circle
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// used to call the interget values of x, y and radius.
        /// </summary>
        public int x, y, radius;


        public Circle() : base()
        {
        }

        /// <summary>
        /// used to pass value of circle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        public Circle(int x, int y, int radius)
        {
            this.radius = radius;
        }


        /// <summary>
        /// used to draw the circle on paneel
        /// </summary>
        /// <param name="g"></param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, x - radius, y - radius, radius * 2, radius * 2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// used as to set value of x, y and radius. 
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            try
            {
                this.x = list[0];
                this.y = list[1];
                this.radius = list[2];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
