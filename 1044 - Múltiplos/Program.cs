using System; 
using System.Globalization;
using System.IO.Compression;

class URI {

    static void Main(string[] args) { 

        int A, B;
        string[] input = Console.ReadLine().Split(' ');

        A = int.Parse(input[0]);
        B = int.Parse(input[1]);

        if( A % B == 0 || B % A == 0){
            Console.WriteLine("Sao Multiplos");
        } else{
            Console.WriteLine("Nao sao Multiplos");
        }
    }

}