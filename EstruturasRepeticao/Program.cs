//Estruturas de repetição

//For

//O for é uma estrutura de repetição que permite executar um bloco de código várias vezes.

//Aqui está um exemplo de um for que exibe os números de 0 a 4:


// for (int i = 0; i < 5; i++)
// {
//    Console.WriteLine(i);
// }

//O for é composto por três partes:

//1. A inicialização: é executada uma vez antes do início do loop. Geralmente é usada para inicializar a variável de controle do loop.
//2. A condição: é avaliada antes de cada iteração. Se for verdadeira, o bloco de código é executado; caso contrário, o loop é encerrado.
//3. O incremento: é executado após o bloco de código em cada iteração. Geralmente é usado para incrementar ou decrementar a variável de controle.

//Aqui está um exemplo de um for que exibe os números de 10 a 0, decrementando de 2 em 2:

// for (int i = 10; i >= 0; i -= 2)
// {
//    Console.WriteLine(i);
// }

//O for é uma estrutura de repetição muito poderosa e flexível. Você pode usá-lo para executar um bloco de código um número específico de vezes, ou até mesmo para percorrer uma coleção de itens.

//While

//O while é outra estrutura de repetição que executa um bloco de código enquanto uma condição específica for verdadeira.

//Aqui está um exemplo de um while que exibe os números de 0 a 4:

// int i = 0;
// while (i < 5)
// {
//    Console.WriteLine(i);
//    i++;
// }

//O while é composto por uma única condição. O bloco de código é executado enquanto a condição for verdadeira.

//Aqui está um exemplo de um while que exibe os números de 10 a 0, decrementando de 2 em 2:

// int i = 10;

// while (i >= 0)
// {
//    Console.WriteLine(i);
//    i -= 2;
// }

//O while é uma estrutura de repetição simples e direta. Ele é útil quando você não sabe quantas vezes o bloco de código precisa ser executado.

//Do-While


//O do-while é uma estrutura de repetição semelhante ao while, mas com uma diferença importante: o bloco de código é executado pelo menos uma vez, mesmo que a condição seja falsa.

//Aqui está um exemplo de um do-while que exibe os números de 0 a 4:

// int i = 0;

// do
// {
//    Console.WriteLine(i);
//    i++;
// } while (i < 5);


//O do-while é composto por duas partes:

//1. O bloco de código: é executado pelo menos uma vez.

//2. A condição: é avaliada após a execução do bloco de código. Se for verdadeira, o bloco de código é executado novamente; caso contrário, o loop é encerrado.

//Aqui está um exemplo de um do-while que exibe os números de 10 a 0, decrementando de 2 em 2:

// int i = 10;

// do
// {
//    Console.WriteLine(i);
//    i -= 2;
// } while (i >= 0);



//O do-while é útil quando você precisa garantir que um bloco de código seja executado pelo menos uma vez, independentemente da condição.

//Break e Continue

//O break é uma instrução que interrompe a execução de um loop. Quando o break é encontrado dentro de um loop, o loop é encerrado imediatamente.

//Aqui está um exemplo de um for que exibe os números de 0 a 4, mas é interrompido quando i for igual a 2:


for (int i = 0; i < 5; i++)
{
   if (i == 2)
   {
       break;
   }

   Console.WriteLine(i);
}


//O continue é uma instrução que interrompe a iteração atual de um loop e continua com a próxima iteração.

//Aqui está um exemplo de um for que exibe os números de 0 a 4, mas pula o número 2:

for (int i = 0; i < 5; i++)
{
   if (i == 2)
   {
       continue;
   }

   Console.WriteLine(i);
}

//O break e o continue são úteis para controlar o fluxo de execução dentro de um loop. Eles permitem que você interrompa o loop prematuramente ou pule iterações específicas.


