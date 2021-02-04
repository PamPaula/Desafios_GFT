using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Double a, b, c;

        a = Double.Parse(Console.ReadLine());
        b = Double.Parse(Console.ReadLine());
        c = Double.Parse(Console.ReadLine());

        Double x1, x2, aux;

        x1 = -b + Math.Sqrt((b * b) - 4 * a * c);
        aux = 2 * a;
        x1 = x1 / aux;

        Console.WriteLine("X1 = " + x1.ToString("N5"));

        x2 = -b - Math.Sqrt((b * b) - 4 * a * c);
        aux = 2 * a;
        x2 = x2 / aux;


        Console.WriteLine("X2 = " + x2.ToString("N5"));
    }
}