using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), tax = 0, incomeTax = 0;

        if (income <= 2000.00) {
            Console.WriteLine("Isento");
        } else if (income <= 3000.00) {
            incomeTax = income - 2000;
            tax = incomeTax * 0.08;
        
        } else if (income <= 4500.00) {
            incomeTax = income - 3000;
            tax = (incomeTax * 0.18) + (1000.00 * 0.08);
        } else {
            incomeTax = income - 4500.00;
            tax = (incomeTax * 0.28) + (1500.00 * 0.18) + (1000.00 * 0.08);
        }

        if(income > 2000.00){
            Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}