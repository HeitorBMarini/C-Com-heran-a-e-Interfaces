using byteBank_ADM.Funcionários;
using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitario;

Funcionario Pedro = new Funcionario();

Pedro.Nome = "Pedro Corte";

Pedro.Cpf = "37161659809";

Pedro.Salario = 1750;

Console.WriteLine(Pedro.Nome);

Console.WriteLine(Pedro.GetBonificacao());

Diretor Muzy = new Diretor();
Muzy.Nome = "Paulo Muzy";
Muzy.Cpf = "12345623467";
Muzy.Salario = 3000;

Console.WriteLine(Muzy.Nome);

Console.WriteLine(Muzy.GetBonificacao());

GerenciadorDeBonificações gerenciador = new GerenciadorDeBonificações();
gerenciador.Registrar(Pedro);
gerenciador.Registrar(Muzy);

Console.WriteLine("Total de Bonificações: "+ gerenciador.TotalDeBonificacao);

