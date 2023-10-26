using System;


class URI {

    static void Main(string[] args) { 

        int prod = 1, number;

        for(int i = 0; i < 2; i++){
            number = int.Parse(Console.ReadLine());
            prod *= number;
        }

        Console.WriteLine("PROD = " + prod);
    }

}