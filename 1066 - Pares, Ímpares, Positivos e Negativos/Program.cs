using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        const int MAX = 5;
        int value, even = 0, odd = 0, positive = 0, negative = 0;

        for(int i = 0; i < MAX; i++){
            value = int.Parse(Console.ReadLine());

            if(value % 2 == 0){
                even++;
            }else{
                odd++;
            }

            if(value > 0){
                positive++;
            } else if(value < 0){
                negative++;
            }
        }

        Console.WriteLine(even + " valor(es) par(es)");
        Console.WriteLine(odd + " valor(es) impar(es)");
        Console.WriteLine(positive + " valor(es) positivo(s)");
        Console.WriteLine(negative + " valor(es) negativo(s)");

    }

}