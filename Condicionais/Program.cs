// See https://aka.ms/new-console-template for more information

using System;

class Aula12{

    static void Main(string[] args){
        int n1, n2,n3,n4;
        n1=n2=n3=n4=0;

        string resultado;

        Console.Write("Digite a nota 1: ");
        n1= int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        int nota = (n1 + n2 + n3 + n4)/4;

        if(nota < 40){
                resultado = "Aprovado";
        }else if( nota < 60){
            resultado = "Recuperação";
        }else{
            resultado = "Aprovado";
        }
        Console.WriteLine(resultado);
    }
}
