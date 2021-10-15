using System;

char figure;
char state = 'y';
double Area; 
//Ask for type of figure while state is 'y'
Console.WriteLine("Hello, I can calculate area and Area of several geometric figures");
while (state == 'y')
{
    Console.WriteLine("What figure do you wish to calculate. C=cercle , T=triangle, R=rectangle");
    figure = Convert.ToChar(Console.ReadLine());

    //select the function according the figure selected
    if (figure == 'C'|| figure == 'c')
    {
        Area = calculateCercle();
        Console.WriteLine("The area is equal to {0}", Area);
    }
    else if (figure == 'R' || figure == 'r')
    {
        Area = calculateRectangle();
        Console.WriteLine("The area is equal to {0}", Area);
    }
    else
    {
        Area = calculateTriangle();
        Console.WriteLine("The area is equal to {0}", Area);
    }

    Console.WriteLine("Do you wish to continue calculating? y/n");
    state = Convert.ToChar(Console.ReadLine());
}

//Triangle Function
static double calculateTriangle()
{
    double  a, b, c, s, result;
    Console.WriteLine("Triangle selected");
    Console.WriteLine("Please provide me the variables needed");
    //ask for sides
    Console.WriteLine("Side a");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Side b");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Side c");
    c = Convert.ToDouble(Console.ReadLine());

    //Heron's formula
    s = Convert.ToDouble((a+b+c)/2);
    result = Convert.ToDouble(Math.Sqrt(s*(s-a)*(s-b)*(s-c)));
    return result;
}

//Cercle function
static double calculateCercle()
{
    double result, radius;
    Console.WriteLine("Cercle selected");
    Console.WriteLine("Please provide me the variables needed");
    //ask for radius
    Console.WriteLine("What is your radius?");
    radius = Convert.ToDouble(Console.ReadLine());
    
    //results = Pi*R^2
    result = Math.PI*(Math.Pow(radius,2));
    return result;
}

//rectangle function
static double calculateRectangle()
{
    double side1, side2, result;
    Console.WriteLine("Rectangle selected");
    Console.WriteLine("Please provide me the variables needed");
    //ask for both sides needed
    Console.WriteLine("What is your 1st side?");
    side1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is your 2nd side?");
    side2 = Convert.ToDouble(Console.ReadLine());

    //result = a* b
    result = side1*side2;
    return result;
}

