using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string name;
        double fixedSalary, totalSales, totalSalary;

        name = Console.ReadLine();

        fixedSalary = double.Parse(Console.ReadLine());
        totalSales = double.Parse(Console.ReadLine());

        totalSalary = fixedSalary + (totalSales * 0.15);

        Console.WriteLine("TOTAL = R$ " + totalSalary.ToString("F2", CultureInfo.InvariantCulture));
    }

}