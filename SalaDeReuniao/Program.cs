using SalaDeReuniao.Modelos;

Sala sala = new(123,2);
//sala.AlternarEstadoDisponivel();
Reuniao reuniao1 = new("Desmonstrativo de Contrato", "2024-04-12 15:00:00", "2024-04-12 18:00:00");
Reuniao reuniao2 = new("Desmonstrativo de Contrato", "2024-04-12 15:30:00", "2024-04-12 18:00:00");

Membro membro1 = new Funcionario("Samuel", "Analista de Sistemas");
Membro membro2 = new Funcionario("Diego", "Coordenador");
//Membro membro3 = new Convidado("Luiz", "Sankhya");
Membro membro4 = new Convidado("José", "Sankhya");


try
{
    reuniao1.AdicionarParticipante(membro1);
    reuniao1.AdicionarParticipante(membro2);
    //reuniao1.AdicionarParticipante(membro3);
    reuniao2.AdicionarParticipante(membro4);
    sala.AgendarReuniao(reuniao1);
    sala.AgendarReuniao(reuniao2);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}