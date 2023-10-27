using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] values = Console.ReadLine().Split(' ');

        int start = int.Parse(values[0]);
        int end = int.Parse(values[1]);

        int gameTime = 0;

        if(end > start){
            gameTime = end - start;
        } else if(start == end){
            gameTime = 24;
        } else {
            for(int i = start; i < 24; i++){
                gameTime++;
            }
            for(int i = 0; i < end; i++){
                gameTime++;
            }
        }

        Console.WriteLine("O JOGO DUROU " + gameTime + " HORA(S)");
    }

}