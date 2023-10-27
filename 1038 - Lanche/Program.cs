using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int code, qty;
        double total = 0;

        string[] input = Console.ReadLine().Split(' ');

        code = int.Parse(input[0]);
        qty = int.Parse(input[1]);

        switch(code){
        case 1:
            total = qty * 4;
            break;
        case 2:
            total = qty * 4.5;
            break;
        case 3:
            total = qty * 5;
            break;
        case 4:
            total = qty * 2;
            break;
        case 5:
            total = qty * 1.5;
            break;
        }

        System.Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }

}