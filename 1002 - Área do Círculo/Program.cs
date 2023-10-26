using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        const double pi = 3.14159;

        double area = 0;

        double raio = double.Parse(Console.ReadLine());

        area = pi * (Math.Pow(raio, 2));

        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
    }

}