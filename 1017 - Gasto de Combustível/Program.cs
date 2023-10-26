using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int timeSpent, avgSpeed;
        double qtyFuel;

        timeSpent = int.Parse(Console.ReadLine());
        avgSpeed = int.Parse(Console.ReadLine());

        qtyFuel = ((double)timeSpent * avgSpeed) / 12;

        Console.WriteLine(qtyFuel.ToString("F3", CultureInfo.InvariantCulture));
    }
}