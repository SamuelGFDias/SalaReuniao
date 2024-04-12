namespace SalaDeReuniao.Modelos;

internal class Sala
{
    private bool Disponivel { get; set; }
    private List<Reuniao> ReunioesAgendadas { get; } = new();
    public int NumeroSala { get; }
    public int Capacidade { get; }
    public Sala(int numeroSala, int capacidade)
    {
        NumeroSala = numeroSala;
        Capacidade = capacidade;
        Disponivel = true;
    }

    public void AgendarReuniao(Reuniao reuniao)
    {
        if (!Disponivel)
        {
            throw new InvalidOperationException("A sala não está disponível.");
        }
        if (reuniao.Membros.Count > Capacidade)
        {
            throw new InvalidOperationException($"A capacidade da sala {NumeroSala} são {Capacidade} participantes. {reuniao.Membros.Count} foram passados.");
        }
        if (reuniao.Membros.Count == 0)
        {
            throw new InvalidOperationException($"A reunião deve conter pelo menos 1 participante");
        }
        foreach (Reuniao r in ReunioesAgendadas)
        {
            if (reuniao.Inicio < r.Fim && reuniao.Fim > r.Inicio)
            {
                throw new InvalidOperationException($"A sala {NumeroSala} já está agendada para outra reunião.");
            }
        }
        ReunioesAgendadas.Add(reuniao);
        Console.WriteLine($"Reunião agendada para {reuniao.Motivo} das {reuniao.Inicio.ToString()} até {reuniao.Fim.ToString()}.");
    }
    public void AlternarEstadoDisponivel()
    {
        Disponivel = !Disponivel;
        Console.WriteLine($"A sala {NumeroSala} está {(Disponivel ? "Disponível" : "Indisponível")}");
    }
}
