using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string nome1 = Console.ReadLine();
        string nome2 = Console.ReadLine();
        string nome3 = Console.ReadLine();

        if(nome1 == "vertebrado"){
            if (nome2  == "ave"){
                if(nome3 == "carnivoro"){
                    Console.WriteLine("aguia");
                } else if(nome3 == "onivoro"){
                    Console.WriteLine("pomba");
                }
            } else if(nome2 == "mamifero"){
                if (nome3 == "onivoro"){
                    Console.WriteLine("homem");
                } else if(nome3 == "herbivoro"){
                    Console.WriteLine("vaca");
                }
            }
        } else if(nome1 == "invertebrado"){
            if(nome2 == "inseto"){
                if(nome3 == "hematofago"){
                    Console.WriteLine("pulga");
                } else if(nome3 == "herbivoro"){
                    Console.WriteLine("lagarta");
                }
            } else if(nome2 == "anelideo"){
                if(nome3 == "hematofago"){
                    Console.WriteLine("sanguessuga");
                } else if(nome3 == "onivoro"){
                    Console.WriteLine("minhoca");
                }
            }
        }
    }

}