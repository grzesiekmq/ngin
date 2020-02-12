using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rgn
{
    class Math
    {
        /// <summary>
        /// convert radians to degrees
        /// </summary>
        /// <param name="angle"></param>
        /// <returns>converted angle</returns>
        public static double RadToDeg(double angle)
        {
            return angle * (180.0 / System.Math.PI);
        }
    }
}
