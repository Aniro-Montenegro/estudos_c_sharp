using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposDeDados.Models
{
    public class Carro
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Ano { get; set; }
        public string? Placa { get; set; }
        public string? Cor { get; set; }     

        public bool AVenda { get; set; }
        public decimal ValorVenda { get; set; }

        public float Combustivel { get; set; }
        public DateTime DataFabricacao { get; set; }

        public DateTime DataProximaTrocaOleo { get; set; }

       public void ApresentarCarro()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Combustível: {Combustivel.ToString("N2")}");
            if (AVenda)
            {
                Console.WriteLine("Este carro está à venda");
            }
            else
            {
                Console.WriteLine("Este carro não está à venda");
            }
         
            Console.WriteLine($"Valor de Venda: {ValorVenda}");
            Console.WriteLine($"Data de Fabricação: {DataFabricacao.ToString("dd/MM/yyyy")}");
            DataProximaTrocaOleo.AddDays(180);
            Console.WriteLine($"Data da Próxima Troca de Óleo: {DataProximaTrocaOleo.ToString("dd/MM/yyyy")}");
            int IntervaloData = DataProximaTrocaOleo.DayOfYear - DataFabricacao.DayOfYear;
            Console.WriteLine($"Intervalo de dias entre a data de fabricação e a próxima troca de óleo: {IntervaloData}");
        }

    }
}