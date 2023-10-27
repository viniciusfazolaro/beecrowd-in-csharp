using System;
using System.Globalization;

class URI{

    static void Main(string[] args){

        string[] valores = Console.ReadLine().Split(' ');

        double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        if ((A >= (B + C)) || (B >= (A + C)) || (C >= (A + B))){
            Console.WriteLine("NAO FORMA TRIANGULO");
        }else if ((Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2))) || (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2)) || (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))) {
            Console.WriteLine("TRIANGULO RETANGULO");
        }else if ((Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)) || (Math.Pow(B, 2) > Math.Pow(A, 2) + Math.Pow(C, 2)) || (Math.Pow(C, 2) > Math.Pow(A, 2) + Math.Pow(B, 2))) {
            System.Console.WriteLine("TRIANGULO OBTUSANGULO");
        } else if ((Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2)) || (Math.Pow(B, 2) < Math.Pow(A, 2) + Math.Pow(C, 2)) || (Math.Pow(C, 2) < Math.Pow(A, 2) + Math.Pow(B, 2))) {
            System.Console.WriteLine("TRIANGULO ACUTANGULO");
        }
                
            
        if (A == B && B == C){
            Console.WriteLine("TRIANGULO EQUILATERO");
        }else if ((A == B && B != C) || (B == C && A != C) || (C == A && B != A)){
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }

}