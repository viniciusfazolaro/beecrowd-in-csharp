using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double value, positives = 0, avg;
        const int MAX = 6;
        int count = 0;

        for(int i = 0; i < MAX; i++){
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(value > 0){
                count++;
                positives += value;
            }
        }

        avg = positives / count;

        Console.WriteLine(count + " valores positivos");
        Console.WriteLine(avg.ToString("F1", CultureInfo.InvariantCulture));

    }
}