using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] vet = Console.ReadLine().Split(' ');
        int a, b, c, maiorAB, maior;

        a = int.Parse(vet[0]);
        b = int.Parse(vet[1]);
        c = int.Parse(vet[2]);

        maiorAB = (a + b + Math.Abs(a - b)) / 2;

        maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine(maior + " eh o maior");

        
    }

}