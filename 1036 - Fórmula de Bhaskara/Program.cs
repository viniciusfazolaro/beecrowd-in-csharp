using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] values = Console.ReadLine().Split(' ');
        double A = double.Parse(values[0]);
        double B = double.Parse(values[1]);
        double C = double.Parse(values[2]);
        double delta = Math.Pow(B, 2) - 4 * A * C;

        if (delta < 0 || A <= 0){
            Console.WriteLine("Impossivel calcular");
        }else{
            double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double R2 = (-B - Math.Sqrt(delta)) / (2 * A);
            Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }

}