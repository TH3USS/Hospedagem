using System.Text;
using Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> listaHospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Maria");
Pessoa p2 = new Pessoa(nome: "Carlos");

listaHospedes.Add(p1);
listaHospedes.Add(p2);

Suite novoQuarto = new Suite(tipoSuite: "Normal", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(novoQuarto);
reserva.CadastrarHospedes(listaHospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalValorDiaria()}");