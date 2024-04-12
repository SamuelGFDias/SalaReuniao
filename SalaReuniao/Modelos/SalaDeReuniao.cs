using System;
namespace SalaReuniao.Modelos;

internal class SalaDeReuniao
{
    private bool Disponivel { get; set; }
    private List<Reuniao> ReunioesAgendadas { get; } = new();
    public int NumeroSala { get; }
    public int Capacidade { get; }

    public SalaDeReuniao(int numeroSala, int capacidade)
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
            throw new InvalidOperationException($"A sala {NumeroSala} não tem capacidade para {reuniao.Membros.Count} membros.");
        }
        foreach (Reuniao r in ReunioesAgendadas)
        {
            if (reuniao.Inicio < r.Fim && reuniao.Fim > r.Inicio)
            {
                throw new InvalidOperationException($"A sala {NumeroSala} já está agendada para outra reunião.");
            }
        }
        Console.WriteLine($"Reunião agendada para {reuniao.Motivo} das {reuniao.Inicio.ToString()} até {reuniao.Fim.ToString()}.");
    }

}
