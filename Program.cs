using Circle1;
using System;

// Elev: Jonna Gustafsson
// Klass: .NET23

namespace Circle1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Circle objects with different radii
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            // Calculate the areas of the two circles
            double area1 = circle1.CalculateArea();
            double area2 = circle2.CalculateArea();

            // Print the area of the circle with a radius of 5
            Console.WriteLine("Arean av cirkeln med radien 5 är: " + area1);

            // Print the area of the circle with a radius of 6
            Console.WriteLine("Arean av cirkeln med radien 6 är: " + area2);

            // Create a Circle object to calculate the surface area and volume of a sphere
            Circle circleForSphere = new Circle(4);

            // Calculate the surface area and volume of the sphere with a radius of 4
            var sphereResult = circleForSphere.CalculateSphere();

            // Print the surface area of the sphere
            Console.WriteLine("Ytans area av sfären med radien 4 är: " + sphereResult.SurfaceArea);

            // Print the volume of the sphere
            Console.WriteLine("Volymen av sfären med radien 4 är: " + sphereResult.Volume);

            // Create a Triangle object with various side lengths and base
            Triangle triangle = new Triangle(5, 4, 3, 4, 5);

            // Calculate the area of the triangle
            double triangleArea = triangle.CalculateArea();

            // Calculate the perimeter of the triangle
            double trianglePerimeter = triangle.CalculatePerimeter();

            // Print the area of the triangle
            Console.WriteLine("Arean av triangeln är: " + triangleArea);

            // Print the perimeter of the triangle
            Console.WriteLine("Omkretsen av triangeln är: " + trianglePerimeter);
        }
    }
}

