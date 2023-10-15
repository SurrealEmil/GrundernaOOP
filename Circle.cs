using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    internal class Circle
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        // Three metods getting area, volume and circumfrence.
        // Using Math.Round that rounds the decimal to the sett amount in this case three.
        // Using Math.Pi to use pi.
        // Using Math.Pow insted of example _radius * _radius * _radius. I can use Math.Pow and take _radius to the power of three.

        public double getArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 3);
        }

        public double getVolume()
        {
            return Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3), 3);
        }

        public double getCircumference()
        {
            return Math.Round(2 * Math.PI * _radius, 3);
        }
    }
}
