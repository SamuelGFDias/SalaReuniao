namespace SalaReuniao.Modelos;

internal class Funcionario : Membro
{
    public Funcionario(string nome, string cargo) : base(nome)
    {
        Cargo = cargo;
    }
    public string Cargo { get; }
    public override string DescricaoResumida => 
        $"O funcionário {Nome} atua como {Cargo}.";
}
