namespace SalaDeReuniao.Modelos;

internal class Convidado : Membro
{
    public Convidado(string nome, string afiliacao) : base(nome)
    {
        Afiliacao = afiliacao;
    }
    public string Afiliacao { get; }
    public override string DescricaoResumida => 
        $"O convidado {Nome} é afiliado a {Afiliacao}.";
}
