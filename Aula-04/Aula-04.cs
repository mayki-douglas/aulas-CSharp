using System;

class Aula04{

    int num = 10; //essa é uma variável GLOBAL que pertence a classe.

    static void Main(){
        int num2 = 0; //essa variável está dentro do escopo "main". Se trata de uma variável LOCAL.
        Console.WriteLine(num2); //se chamarmos a variável nesse escopo, não irá compilar pelo fato do escopo ser estático. A variável deve ser estática também.
    }

    void teste(){  //esse método "teste" esta fora do método main, pelo fechamento de chave acima.
        int num3 = 0;
        Console.WriteLine(num); 
    }
}

//aprendendo sobre escopo de variáveis