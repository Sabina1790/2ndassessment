using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndassessment
{
    /// <summary>
    /// Class decleared as creator
    /// </summary>
    abstract class Creator
    {
        /// <summary>
        /// this is used as passing the shape of object. 
        /// </summary>
        /// <param name="ShapeType">Shape parameter</param>
        /// <returns></returns>
        
        public abstract IShape getShape(string ShapeType); 
    }
}
