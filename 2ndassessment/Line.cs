using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2ndassessment
{

    /// <summary>
    /// used as declaring line class.
    /// </summary>
    public class Line : IShape
    {
        /// <summary>
        /// pass interger values X as x-axis and Y as y-axis 
        /// </summary>
        public int x, y, toX, toY;


        public Line() : base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="toX"></param>
        /// <param name="toY"></param>
        public Line(int x, int y, int toX, int toY)
        { }


        /// <summary>
        /// used for drawing cicle
        /// </summary>
        /// <param name="g">Graphics</param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawLine(p, x, y, toX, toY);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// used to set the value of x and y of line x-axis and y-axis.
        /// </summary>
        /// <param name="list"></param>
        public void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
            this.toX = list[2];
            this.toY = list[3];
        }
    }
}
