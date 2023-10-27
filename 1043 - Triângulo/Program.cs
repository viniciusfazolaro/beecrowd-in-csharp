using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        bool isTriangle;
        string[] input = Console.ReadLine().Split(' ');
        double a = double.Parse(input[0], CultureInfo.InvariantCulture);
        double b = double.Parse(input[1], CultureInfo.InvariantCulture);
        double c = double.Parse(input[2], CultureInfo.InvariantCulture);
        double calc;

        if((a + b) > c && (b + c) > a && (a + c) > b){
            isTriangle = true;
        } else{
            isTriangle = false;
        }

        if(isTriangle){
            calc = a + b + c;
            Console.WriteLine("Perimetro = " + calc.ToString("F1", CultureInfo.InvariantCulture));
        } else{
            calc = ((a + b) * c) / 2;
            Console.WriteLine("Area = " + calc.ToString("F1", CultureInfo.InvariantCulture));
        }

    }

}