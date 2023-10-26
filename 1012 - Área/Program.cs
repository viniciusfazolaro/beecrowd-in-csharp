using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        const double pi = 3.14159;
        double A, B, C;
        double triangle, circle, trapeze, square, rectangle;

        string[] vet = Console.ReadLine().Split(' ');

        A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        triangle = (A * C) / 2;
        circle = pi * Math.Pow(C, 2);
        trapeze = ((A + B) * C) / 2;
        square = Math.Pow(B, 2);
        rectangle = A * B;

        Console.WriteLine("TRIANGULO: " + triangle.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circle.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapeze.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + square.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + rectangle.ToString("F3", CultureInfo.InvariantCulture));
        
    }

}