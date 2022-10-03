using System;

namespace lab3
{
    internal class Rectangle
    {
        private readonly double _side1;

        private readonly double _side2;
        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        private double _area;
        public double Area
        {
            get
            {
                return _area;
            }
        }
        public double AreaCalculator()
        {
            _area = _side1 * _side2;
            return _area;
        }

        private double _perimeter;
        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }
        public double PerimeterCalculator()
        {
            _perimeter = 2 * (_side1 + _side2);
            return _perimeter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write the size of the first side: ");
           
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the size of the second side:");
            int size2 = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(size1, size2);
            Console.WriteLine("Perimeter yours rectangle: "+rectangle.PerimeterCalculator());
            Console.WriteLine("Area yours rectangle: " + rectangle.AreaCalculator());
        }
    }
}
