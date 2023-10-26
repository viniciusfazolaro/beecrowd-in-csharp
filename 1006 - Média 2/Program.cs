using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double A, B, C, avg;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        avg = ((A * 2) + (B * 3) + (C * 5)) / 10;

        Console.WriteLine("MEDIA = " + avg.ToString("F1", CultureInfo.InvariantCulture));
    }

}