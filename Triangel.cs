using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle1
{
    // This class represents a triangle
    class Triangle
    {
        // Private fields to store the dimensions of the triangle
        private double _baseLength;
        private double _height;
        private double _side1;
        private double _side2;
        private double _side3;

        // Constructor to initialize the triangle's dimensions
        public Triangle(double baseLength, double height, double side1, double side2, double side3)
        {
            _baseLength = baseLength;
            _height = height;
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        // Calculate and return the area of the triangle
        public double CalculateArea()
        {
            return 0.5 * _baseLength * _height;
        }

        // Calculate and return the perimeter (sum of sides) of the triangle
        public double CalculatePerimeter()
        {
            return _side1 + _side2 + _side3;
        }
    }
}
