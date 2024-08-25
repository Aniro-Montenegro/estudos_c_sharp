
using TiposDeDados.Models;

Carro carro = new Carro();

carro.Marca = "Chevrolet";
carro.Modelo = "Cruze";
carro.Ano = 2019;
carro.Placa = "ABC-1234";
carro.Cor = "Preto";
carro.AVenda = false;
carro.ValorVenda = 75000.00m;
carro.Combustivel = 50.5f;
carro.DataFabricacao = new DateTime(2019, 10, 10);
carro.DataProximaTrocaOleo = new DateTime(2020, 4, 10);


carro.ApresentarCarro();


