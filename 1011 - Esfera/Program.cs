using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        const double pi = 3.14159;
        double radius, vol;
        
        radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        vol = ((double)4 / 3) * pi * Math.Pow(radius, 3);

        Console.WriteLine("VOLUME = " + vol.ToString("F3", CultureInfo.InvariantCulture));
    }

}