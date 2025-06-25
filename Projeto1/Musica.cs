class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    // Atributos de uma Classe.
    public string Nome {  get; }
    public Banda Artista {  get; set; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
     
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista.Nome} e a duração é: {Duracao} segundos";

    //métodos de uma classe
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine(DescricaoResumida);
        if (Disponivel)
        {
            Console.WriteLine("Disponível no seu plano Plus.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+ para escuta-lá.");
        }
    }
}