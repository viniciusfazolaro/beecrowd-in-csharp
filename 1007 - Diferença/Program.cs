using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, D, diff;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());

        diff = (A * B - C * D);

        Console.WriteLine("DIFERENCA = " + diff);
    }

}