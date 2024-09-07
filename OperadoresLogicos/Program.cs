
Console.WriteLine("Digite a sua idade");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o codigo do produto:");
int codigo = int.Parse(Console.ReadLine());

Console.WriteLine("1 - Carro");
Console.WriteLine("2 - Moto");
Console.WriteLine("3 - Celular");
Console.WriteLine("4 - Notebook");

Console.WriteLine("Digite a quantidade de dinheiro disponivel:");
double dinheiro = double.Parse(Console.ReadLine());

if(codigo == 1 ){
    if(idade >= 18){
        if(dinheiro >= 50000){
            Console.WriteLine("Compra efetuada com sucesso");
        }else{
            Console.WriteLine("Dinheiro insuficiente");
        }
    }else{
        Console.WriteLine("Compra proibida para menores de 18 anos");
    }
}
else if(codigo ==2){
    if(idade >=18){
        if(dinheiro >= 15000){
            Console.WriteLine("Compra efetuada com sucesso");
        }else{
            Console.WriteLine("Dinheiro insuficiente");
        }
    }
}
else if(codigo == 3){
    if(dinheiro >= 2000 && idade >= 18){
        Console.WriteLine("Compra efetuada com sucesso");
    }else if(dinheiro < 2000 || idade < 18){
        Console.WriteLine("Dinheiro insuficiente ou idade menor que 18 anos");
    }
}
else if(codigo == 4){
    if(dinheiro >= 4500 && idade >= 18){
        Console.WriteLine("Compra efetuada com sucesso");
    } else if(!(dinheiro > 4500 || idade > 18)){
        Console.WriteLine("Dinheiro insuficiente ou idade menor que 18 anos");
    }
}
else{
    Console.WriteLine("Codigo invalido");
}

