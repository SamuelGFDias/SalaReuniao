using SalaReuniao.Modelos;

SalaDeReuniao sala1 = new SalaDeReuniao(124,2);

Reuniao reuniao = new Reuniao("Discussão comercial", "2024-04-12 14:00:00", "2024-04-12 15:00:00");


Membro membro1 = new Funcionario("Carlos","Gerente");
Membro membro2 = new Convidado("Lucas","Simpress");
Membro membro3 = new Convidado("Samuel","Agis");
reuniao.AdicionarParticipante(membro1);
reuniao.AdicionarParticipante(membro2);
reuniao.AdicionarParticipante(membro3);


try
{
    sala1.AgendarReuniao(reuniao);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

