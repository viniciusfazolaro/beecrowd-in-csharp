using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine()), count = 0;

        do{

            if(X % 2 != 0){
                Console.WriteLine(X);
                count++;
            }

            X++;
            
        } while(count < 6);

    }

}