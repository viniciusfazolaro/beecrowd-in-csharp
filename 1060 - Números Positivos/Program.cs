using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double value;
        const int MAX = 6;
        int count = 0;

        for(int i = 0; i < MAX; i++){
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(value > 0){
                count++;
            }
        }

        Console.WriteLine(count + " valores positivos");

    }
}