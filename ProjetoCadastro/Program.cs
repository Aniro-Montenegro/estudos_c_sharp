string opcao;
bool exibirmenu = true;

while (exibirmenu)
{
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("Digite a opção desejada: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar");
            break;
        case "2":
            Console.WriteLine("Listar");
            break;
        case "3":
            exibirmenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
