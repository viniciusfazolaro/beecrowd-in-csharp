using System; 

class URI {

    static void Main(string[] args) { 

        int value, qty100, qty50, qty20, qty10, qty5, qty2, qty1, resto;

        value = int.Parse(Console.ReadLine());

        qty100 = value / 100;
        resto = value % 100;

        qty50 = resto / 50;
        resto = resto % 50;

        qty20 = resto / 20;
        resto = resto % 20;

        qty10 = resto / 10;
        resto = resto % 10;

        qty5 = resto / 5;
        resto = resto % 5;

        qty2 = resto / 2;
        resto = resto % 2;

        qty1 = resto / 1;
        resto = resto % 1;

        Console.WriteLine(value);
        Console.WriteLine(qty100 + " nota(s) de R$ 100,00");
        Console.WriteLine(qty50 + " nota(s) de R$ 50,00");
        Console.WriteLine(qty20 + " nota(s) de R$ 20,00");
        Console.WriteLine(qty10 + " nota(s) de R$ 10,00");
        Console.WriteLine(qty5 + " nota(s) de R$ 5,00");
        Console.WriteLine(qty2 + " nota(s) de R$ 2,00");
        Console.WriteLine(qty1 + " nota(s) de R$ 1,00");

    }

}