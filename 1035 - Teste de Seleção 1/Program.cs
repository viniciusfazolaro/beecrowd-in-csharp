﻿using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, D;
        string[] valores = Console.ReadLine().Split(' ');

        A = int.Parse(valores[0]);
        B = int.Parse(valores[1]);
        C = int.Parse(valores[2]);
        D = int.Parse(valores[3]);

        if(B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0  && A % 2 == 0){
            Console.WriteLine("Valores aceitos");
        } else{
            System.Console.WriteLine("Valores nao aceitos");
        }

    }

}