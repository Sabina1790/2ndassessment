using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace _2ndassessment
{

    /// <summary>
    /// class decleared as factory
    /// </summary>
    class Factory : Creator
    {
        /// <summary>
        /// this is required for passing shape of object
        /// </summary>
        /// <param name="shapeType">shape parameter</param>
        /// <returns></returns>


        public override IShape getShape(string shapeType)
        {
            shapeType = shapeType.ToLower().Trim();
            if (shapeType.Equals("circle"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("3drectangle"))
            {
                return new _3DRectangle();
            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle();
            }
            else if (shapeType.Equals("line"))
            {
                return new Line();
            }
            else if (shapeType.Equals("polygon"))
            {
                return new Polygon();
            }
            else if (shapeType.Equals("hexagon"))
            {
                return new IrregularHexagon();
            }
            else
            {
                //throw an appropriate exception.
                System.ArgumentException argEx = new System.ArgumentException("Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
        }
    }
}
