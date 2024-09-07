
Console.WriteLine("Digite a sua idade:");

int idade = int.Parse( Console.ReadLine());

if (idade >= 65)
{
    Console.WriteLine("Você deve aposentar-se.");
}
else if(idade >= 18 && idade < 65)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}
Console.WriteLine("Qual time de futebol em SP voce torce?");
Console.WriteLine("1 - Palmeiras");
Console.WriteLine("2 - Corinthians");
Console.WriteLine("3 - São Paulo");
Console.WriteLine("4 - Santos");
Console.WriteLine("5 - Outro");

int time = int.Parse(Console.ReadLine());

switch (time)
{
    case 1:
        Console.WriteLine("Então voce é palmerense.");
        break;
    case 2:
        Console.WriteLine("Então voce é corinthiano.");
        break;
    case 3:
        Console.WriteLine("Então voce é são paulino.");
        break;
    case 4:

        Console.WriteLine("Então voce é santista.");
        break;
    case 5:
        Console.WriteLine("Então voce torce para outro time.");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
        
}