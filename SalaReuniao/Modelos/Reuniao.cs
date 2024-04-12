namespace SalaReuniao.Modelos;

internal class Reuniao
{
    public List<Membro> Membros { get; } = new();
    private int numeroDeMembros = 0;
    public Reuniao(string motivo, string inicio, string fim)
    {
        Motivo = motivo;
        Inicio = DateTime.Parse(inicio);
        Fim = DateTime.Parse(fim);
    }

    public string Motivo { get; }
    public DateTime Inicio { get; }
    public DateTime Fim { get; }

    public void AdicionarParticipante(Membro membro)
    {
        Membros.Add(membro);
        numeroDeMembros++;
    }
    public void MostrarMembros()
    {
        foreach (var membro in Membros)
        {
            Console.WriteLine(membro.DescricaoResumida);
        }
    }
}
