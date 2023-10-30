using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        const int MAX = 5;
        int value, count = 0;

        for(int i = 0; i < MAX; i++){
            value = int.Parse(Console.ReadLine());

            if(value % 2 == 0){
                count++;
            }
        }

        Console.WriteLine(count + " valores pares");

    }

}