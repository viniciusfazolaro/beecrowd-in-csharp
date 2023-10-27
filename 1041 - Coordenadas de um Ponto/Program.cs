using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double x, y;
        string[] coords = Console.ReadLine().Split(' ');

        x = double.Parse(coords[0], CultureInfo.InvariantCulture);
        y = double.Parse(coords[1], CultureInfo.InvariantCulture);

        if(x > 0 && y > 0){
            Console.WriteLine("Q1");
        } else if(x < 0  && y > 0){
            Console.WriteLine("Q2");
        } else if(x < 0 && y < 0){
            Console.WriteLine("Q3");
        } else if(x > 0 && y < 0){
            Console.WriteLine("Q4");
        } else if(x == 0 && y != 0){
            System.Console.WriteLine("Eixo Y");
        } else if(y == 0 && x != 0){
            System.Console.WriteLine("Eixo X");
        } else{
            System.Console.WriteLine("Origem");
        }

    }

}