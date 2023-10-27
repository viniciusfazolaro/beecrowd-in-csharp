using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] array = Console.ReadLine().Split(' ');
        int[] iarray = new int[3];
        int[] farray = new int[3];
        const int TAM = 3;
        int aux;
        for (int i = 0; i < TAM; i++){
            iarray[i] = int.Parse(array[i]);
            farray[i] = int.Parse(array[i]);
        }

        for(int i = 0; i < TAM; i++){
            for(int j = i + 1; j < TAM; j++){
                if(iarray[i] > iarray[j]){
                    aux = iarray[i];
                    iarray[i] = iarray[j];
                    iarray[j] = aux;
                }
            }
        }

        for(int i = 0; i < TAM; i++){
            Console.WriteLine(iarray[i]);
        }

        Console.WriteLine();

        for(int i = 0; i < TAM; i++){
            Console.WriteLine(farray[i]);
        }
    }
}