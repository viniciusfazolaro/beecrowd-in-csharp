using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 


        string[] vet = Console.ReadLine().Split(' ');
        int inicialHour = int.Parse(vet[0]);
        int inicialMinute = int.Parse(vet[1]);
        int finalHour = int.Parse(vet[2]);
        int finalMinute = int.Parse(vet[3]);

        int initialTime = inicialHour * 60 + inicialMinute;
        int finalTime = finalHour * 60 + finalMinute;

        int duration = 0;
        
        if (initialTime < finalTime) {
            duration = finalTime - initialTime;
        }
        else {
            duration = (24 * 60 - initialTime) + finalTime;
        }

        int durationHour = duration / 60;
        int durationMinute = duration % 60;

        Console.WriteLine("O JOGO DUROU " + durationHour + " HORA(S) E " + durationMinute + " MINUTO(S)");
    }

}