using System;
abstract class Shape//this abstract Shape class is our base class to inherit from
    {               //abstract classes are created by using the 'abstract' keyword
        public abstract double CalculateArea();
       /*abstract classes may or may not have abstract  functions/fields, in this case we'll make an abstract function called CalculateArea.*/
    }
//This is a subclass called Square with its own unique characteristics, it inherits from Shape
    class Square : Shape
    {
        private double side1;
        private double side2;
        public Square() { }//empty constructor
        public Square(double side1, double side2)//overloading, we will pass in a length & width (we'll use this to populate with data)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double CalculateArea()//pay close attention here: any functions inherited from an abstract or virtual class MUST contain the 'override' keyword
        {
            double area = this.side1 * this.side2;
            return area;                      //and must return the same type
        }
    }
//the same is done for the next classes that inherit from Shape
    class Triangle : Shape
    {
        private double tside1;
        private double tside2;
        private double tside3;
        public Triangle() { }
        public Triangle(double tside1, double tside2, double tside3)
        {
            this.tside1 = tside1;
            this.tside2 = tside2;
            this.tside3 = tside3;
        }
        public override double CalculateArea()
        {
            double s = Convert.ToDouble((this.tside1+this.tside2+this.tside3)/2);
            double area = Convert.ToDouble(Math.Sqrt(s*(s-this.tside1)*(s-this.tside2)*(s-this.tside3)));
            return area;
        }
    }
//Same here, we inherit from 'Shape'
    class Circle : Shape
    {
        private double radius;
        public Circle() { }
        public Circle(double r)
        {
            this.radius = r;
        }
        public override double CalculateArea()
        {
            double area = (double)(Math.Pow(this.radius, 2) * Math.PI);
            return area;
        }
    }
class App
{
     static void Main()
    {
        char figure;
        char state = 'y';
        //double Area; 
        Console.WriteLine("Hello, I can calculate area and Area of several geometric figures");
        while (state == 'y')
        {
            Console.WriteLine("What figure do you wish to calculate. C=cercle , T=triangle, R=rectangle");
            figure = Convert.ToChar(Console.ReadLine());

            //We select the right constructor according the figure selected
            if (figure == 'C'|| figure == 'c')
            {
                double radius;
                Console.WriteLine("Cercle selected");
                Console.WriteLine("Please provide me the variables needed");
                //We ask for radius
                Console.WriteLine("What is your radius?");
                radius = Convert.ToDouble(Console.ReadLine());
                Shape circle = new Circle(radius);
                Console.WriteLine("The area is equal to {0}", circle.CalculateArea());
            }
            else if (figure == 'R' || figure == 'r')
            {
                double side1, side2;
                Console.WriteLine("Rectangle selected");
                Console.WriteLine("Please provide me the variables needed");
                //We ask for both sides needed
                Console.WriteLine("What is your 1st side?");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your 2nd side?");
                side2 = Convert.ToDouble(Console.ReadLine());
                Shape square = new Square(side1,side2);
                Console.WriteLine("The area is equal to {0}", square.CalculateArea());
            }
            else
            {
                double  a, b, c;
                Console.WriteLine("Triangle selected");
                Console.WriteLine("Please provide me the variables needed");
                //We ask for 3 sides
                Console.WriteLine("Side a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Side b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Side c");
                c = Convert.ToDouble(Console.ReadLine());
                Shape triangle = new Triangle(a,b,c);
                Console.WriteLine("The area is equal to {0}", triangle.CalculateArea());
            }

            Console.WriteLine("Do you wish to continue calculating? y/n");
            state = Convert.ToChar(Console.ReadLine());
        }
    }
}