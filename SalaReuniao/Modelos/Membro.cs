namespace SalaReuniao.Modelos;

internal abstract class Membro
{
    public Membro(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public abstract string DescricaoResumida { get; }
}
