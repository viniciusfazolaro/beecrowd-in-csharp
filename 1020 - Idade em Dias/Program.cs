using System; 

class URI {

    static void Main(string[] args) { 

        int value, days, months, years, resto;

        value = int.Parse(Console.ReadLine());

        years = value / 365;

        resto = value % 365;

        months = resto / 30;

        days = resto % 30;

        System.Console.WriteLine(years + " ano(s)");
        System.Console.WriteLine(months + " mes(es)");
        System.Console.WriteLine(days + " dia(s)");
    }

}