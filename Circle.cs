using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle1
{
    // This class represents a circle
    class Circle
    {
        private double _piValue = Math.PI; // Define a private variable for the value of pi
        private double _radius; // Define a private variable for the radius

        // Constructor to initialize a Circle with a given radius
        public Circle(double radius)
        {
            _radius = radius;
        }

        // Calculate and return the area of the Circle
        public double CalculateArea()
        {
            return _piValue * _radius * _radius;
        }

        // Calculate and return the surface area and volume of a Sphere with the same radius
        public (double SurfaceArea, double Volume) CalculateSphere()
        {
            double surfaceArea = 4 * _piValue * _radius * _radius;
            double volume = (4.0 / 3.0) * _piValue * _radius * _radius * _radius;
            return (surfaceArea, volume);
        }
    }
}
