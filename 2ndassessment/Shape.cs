using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2ndassessment
{
    /// <summary>
    /// to provide shape of object
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// used as drawing shape of any object
        /// </summary>
        /// <param name="g"></param>
        void draw(Graphics g);

        /// <summary>
        /// used to set value of shapes
        /// </summary>
        /// <param name="list"></param>
        void set(params int[] list);
    }
}
