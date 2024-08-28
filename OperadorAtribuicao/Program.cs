//  O operador de atribuição em C# (=) é usado para atribuir 
//  valores a variáveis. Por exemplo, int x = 10; 
// define a variável x como 10. 
// Esse operador pode ser combinado com 
// operadores aritméticos, como +=, -=, *=, e /=, 
// para realizar e atribuir operações em uma única  etapa

int a = 10;
int b = 20;
Console.WriteLine(a += b); 
Console.WriteLine(a -= b); 
Console.WriteLine(a *= b); 
Console.WriteLine(a /= b); 
Console.WriteLine(a %= 3);

// Em C#, a conversão de tipos é o processo 
// de transformar um valor de um tipo de dado 
// em outro. Isso pode ser feito implicitamente
// (automática) ou explicitamente (manualmente).
// A conversão implícita ocorre quando não há 
// perda de dados, enquanto a explícita é necessária
// quando há possibilidade de perda.

int inteiro = 123;
double doubleNum = inteiro; // int para double
Console.WriteLine(doubleNum);

double doubleNum2 = 123.45;
int inteiro2 = (int)doubleNum2; // double para int (perda de dados)
Console.WriteLine(inteiro2);
string numeroStr = "456";
int numero = Convert.ToInt32(numeroStr);

Console.WriteLine(numero);

string decimalStr = "78.9";
float decimalNum = float.Parse(decimalStr); 

Console.WriteLine(decimalNum);

string booleanStr = "true";
bool booleano;
bool sucesso = bool.TryParse(booleanStr, out booleano); // string para bool// string para float
Console.WriteLine(booleano);

char letra = 'A';
int codigoAscii = (int)letra; // char para int
Console.WriteLine(codigoAscii);

int numero3 = 123;
string numeroStr3 = numero3.ToString(); // int para string

Console.WriteLine(numeroStr3);

DateTime data = DateTime.Now;
string dataStr = data.ToString(); // DateTime para string

string dataStr2 = "2024-08-27";
DateTime data2 = DateTime.Parse(dataStr2); 
Console.WriteLine(data2);

object obj = "Olá";
string str = (string)obj; // object para string

int aa = Convert.ToInt32("123");
double bb = Convert.ToDouble("123.45");
bool cc = Convert.ToBoolean("true");
char dd = Convert.ToChar("A");
Console.WriteLine(aa);
Console.WriteLine(bb);
Console.WriteLine(cc);
Console.WriteLine(dd);
// Diferença entre Convert e Parse
// O método Convert é mais seguro que o método Parse,
// pois ele não lança uma exceção se a conversão falhar.
// Em vez disso, ele retorna um valor padrão para o tipo de dados.
// Por exemplo, Convert.ToInt32("abc") retorna 0,
// enquanto int.Parse("abc") lança uma exceção.

int numero4 = Convert.ToInt32(null); // 0
Console.WriteLine(numero4);
//int numero5 = int.Parse(null); // ArgumentNullException
//Console.WriteLine(numero5);

int numero6 = 5;
string numeroStr6 = numero6.ToString(); // int para string
Console.WriteLine(numeroStr6);

// cast implícito
int numero7 = 123;
double numeroDouble = numero7; // int para double
Console.WriteLine(numeroDouble);

// cast explícito
double numeroDouble2 = 123.45;
int numero8 = (int)numeroDouble2; // double para int

Console.WriteLine(numero8);

// Ordem de precedência dos operadores
// A ordem de precedência dos operadores em C#
// determina a ordem em que as operações são realizadas.
// Por exemplo, a multiplicação tem precedência sobre a adição,
// então 2 + 3 * 4 é avaliado como 2 + (3 * 4) = 14.

int resultado2 = 2 + 3 * 4;
Console.WriteLine(resultado2);
resultado2 = (2 + 3) * 4;
Console.WriteLine(resultado2);

//Convertendo com segurança
// O método TryParse é uma maneira segura de converter
// um valor de string em um tipo de dados numérico.
// Ele retorna true se a conversão for bem-sucedida
// e false se falhar, sem lançar uma exceção.

string numeroStr7 = "123l";
int numero9;
bool sucesso2 = int.TryParse(numeroStr7, out numero9);

if (sucesso2)
{
    Console.WriteLine(numero9);
}
else
{
    Console.WriteLine("Conversão falhou");
}

