public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Apresentar()
    {
        return $"Olá! Meu nome é {Nome} e tenho {Idade} anos.";
    }
}