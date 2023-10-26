using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int number, hours;
        double valuePerHour, salary;

        number = int.Parse(Console.ReadLine());
        hours = int.Parse(Console.ReadLine());
        valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salary = valuePerHour * hours;

        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
    }

}