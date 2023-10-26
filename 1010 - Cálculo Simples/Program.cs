using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

            string[] product;
            int code = 0, qty = 0;
            double price = 0, total = 0;

        for(int i = 0; i < 2; i++){
            product = Console.ReadLine().Split(' ');
            code = int.Parse(product[0]); 
            qty = int.Parse(product[1]);
            price = double.Parse(product[2], CultureInfo.InvariantCulture);
            total += qty * price;
        }

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}