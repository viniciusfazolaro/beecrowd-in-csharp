using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double salary = double.Parse(Console.ReadLine()), bonus, newSalary, qtyBonus;

        if(salary > 0 && salary <= 400){
            bonus = 0.15;
        } else if(salary <= 800){
            bonus = 0.12;
        } else if(salary <= 1200){
            bonus = 0.1;
        } else if(salary <= 2000){
            bonus = 0.07;
        } else{
            bonus = 0.04;
        }
        
        newSalary = salary + (salary * bonus);
        qtyBonus = salary * bonus;

        Console.WriteLine("Novo salario: " + newSalary.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + qtyBonus.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + (bonus * 100).ToString("F0", CultureInfo.InvariantCulture) + " %");

    }

}