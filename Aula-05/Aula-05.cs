using System;

class Aula05{
    static void Main(){

        //entendendo de operadores normais
        int opr = 15+5;
        int opr2 = (20+4)*2; //inserindo operações matemáticas com ordens. Executa dentro do parenteses e o resultado executa com a operação de fora.
        int opr3 = 20+4*2; //na regra da matemática, a multiplicação será executada primeiro, gerando outro valor.

        //essa operação é uma operação relacional, onde inserimos o valor Booleano e o sinal "menor", onde será impresso o valor "True" ou "False".
        bool opr4 = 10<5;
        //operador relacional "diferente". 10 é diferente de 2?" Console mostrará o valor.
        bool opr5 = 10!=2;

        //Criando incrementos nos operadores
        int oprNovo = 10;
        oprNovo = oprNovo + 12; //chamamos a variável e incrementamos com um valor. Abaixo isso pode ser resumido.

        //usando a operação += é a forma resumida do incremento do "oprNovo" citado acima.
        oprNovo += 23;
        //lembrando que serve pra todos os operadores aritiméticos (soma, subtração, multiplicação e divisão)

        oprNovo++; //esta forma adiciona o valor +1 na variável

        Console.WriteLine(opr);
        Console.WriteLine(opr2);
        Console.WriteLine(opr3);
        Console.WriteLine(opr4);
        Console.WriteLine(opr5);
        Console.WriteLine(oprNovo);

        //operadores lógicos

        //iguais ao java: & = E, | = OU.
        bool oprLogico = (5>1) | (2>10);

        //usando o operador OU, o console irá imprimir o valor VERDADEIRO.
        Console.WriteLine(oprLogico);

        bool oprLogico2 = (3>1) & (20<2); // operador lógico E só imprime "true" se TODOS estiverem verdadeiros.

        Console.WriteLine(oprLogico2);
    }
}