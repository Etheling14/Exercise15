double a, b, c;
Console.Write("Insert the value for a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert the value for b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert the value for c: ");
c = Convert.ToDouble(Console.ReadLine());
quadraticEquations(a, b, c);
Console.ReadKey();


void quadraticEquations(double a, double b, double c)
{
    double x1;
    double x2;
    x1 = (-b + Math.Sqrt(Math.Pow(b,2) - (4 * a * c))) / (2 * a);
    x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

    Console.WriteLine("x1: " + x1);
    Console.Write("x2: " + x2);
}

