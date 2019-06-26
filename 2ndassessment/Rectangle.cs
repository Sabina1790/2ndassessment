using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2ndassessment
{
    /// <summary>
    /// class is decleared as rectangle
    /// </summary>
    public class Rectangle: IShape
    {

        /// <summary>
        /// the integer value of x-axis, y-axis , width and height of rectange is decleared.
        /// </summary>
        public int x, y, width, height;


        /// <summary>
        /// provides width and height of rectangle
        /// </summary>
        public Rectangle() : base()
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
        public Rectangle(int x, int y, int width, int height)
        {
            this.width = width;          
            this.height = height; 
        }

        /// <summary>
        /// used to draw rectangle
        /// </summary>
        /// <param name="g">Graphics</param>
        public void draw(Graphics g)
        {
            try
            {
                Pen p = new Pen(Color.Black, 2); g.DrawRectangle(p, x - (width / 2), y - (height / 2), width * 2, height * 2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// useds to set value of x,y,width and height of rectangle
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
