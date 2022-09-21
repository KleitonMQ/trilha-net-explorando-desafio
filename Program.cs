using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
var quantidadeDeHospedes = 0;

Console.WriteLine("Informe a quantidade de hospedes.");
int.TryParse(Console.ReadLine(), out quantidadeDeHospedes);

for (int i = 0; i < quantidadeDeHospedes; i++)
{
    Console.WriteLine("Insira o nome do hospede.");
    var nome = Console.ReadLine();
    Console.WriteLine("Insira o sobrenome do hospede.");
    var sobrenome = Console.ReadLine();
    Pessoa pessoa = new Pessoa(nome: nome, sobrenome: sobrenome);
    hospedes.Add(pessoa);
}

// Cria a suíte
var tipoSuite = "Elite";
var capacidade = 1;
var valorDiaria = 60;
Suite suite = new Suite(tipoSuite: tipoSuite, capacidade: capacidade, valorDiaria: valorDiaria);

// Cria uma nova reserva, passando a suíte e os hóspedes
var diasReservados = 30;

Reserva reserva = new Reserva(diasReservados: diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");