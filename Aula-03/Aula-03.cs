using System;

class Aula03{
    static void Main(){
        byte n1 = 10; //variavel que salva entre 0 e 255
        int number = 0;
        char letra = 'J'; //variável char é DIFERENTE de Strings. Declarar com apóstrofos.
        float valor = 4.1f;
        string nome = "euuu"; //String = array de chars (lembra do javao)

        var aux = "Testando variavel auxiliar e chamando no console"; //C# também usa variáveis que só serão definidas na hora de compilar (tipo js)

        Console.WriteLine("a mensagem é essa: " + aux); //usar o + para concatenar (igual o JAVA novamente)

        
        //Podemos usar as variáveis para operações aritiméticas e mostrar o resultado no console
        //Assim como podemos inserir as operações dentro do console.
    
        int number01 = 20;
        int number02 = 30;
        int soma = number01 + number02;
        int subtr = number01 - number02;
        int mult = number01 * number02;
        int divisao = number02 / number01;

        Console.WriteLine("A multiplicação de " + number01 + " vezes " + number02 + " é igual a: " + mult);
        Console.WriteLine(soma);
        Console.WriteLine(subtr);
        Console.WriteLine(mult);
        Console.WriteLine(divisao);
    }

}

//Entendendo as variáveis em C# 
//Variável em programação = Alocar um espaço na memória. Em C#, declarar TODOS os tipos de variáveis (Fortemente tipada)