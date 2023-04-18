using ByteBank.Contas;
using ByteBank.Funcionarios;
using ByteBank.Titular;
using ByteBank.Utilitarios;

/*
//---------------------TESTANDO CONTAS-------------------------------------------

ContaCorrente contaAndre = new ContaCorrente("1010-X", 15);
contaAndre.Titular = new Cliente("André Silva", "111.111.111-11");
contaAndre.Titular.Profissao = "Desenvolvedor";
contaAndre.Saldo = 100;

ContaCorrente contaMaria = new ContaCorrente("1010-5", 17);
contaMaria.Titular = new Cliente("Maria Souza", "222.222.222-22");
contaMaria.Titular.Profissao = "Desenvolvedora";
contaMaria.Saldo = 350;

Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " é: R$" + contaAndre.Saldo + "\n");

Console.WriteLine("O saldo da conta do " + contaMaria.Titular.Nome + " é: R$" + contaMaria.Saldo + "\n");

//TRANSFERENCIA
if (contaAndre.Transferir(50, contaMaria) == true)
{
    Console.WriteLine("Transferência realizada com sucesso!\n");
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar a transferência!\n");
}

Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " é: R$" + contaAndre.Saldo + "\n");

Console.WriteLine("O saldo da conta do " + contaMaria.Titular.Nome + " é: R$" + contaMaria.Saldo + "\n");


//DEPOSITO
contaAndre.Depositar(100);
Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " após o depósito é: R$" + contaAndre.Saldo + "\n");


//SAQUE
if (contaAndre.Sacar(150) == true)
{
    Console.WriteLine("Saque realizado com sucesso!");
    Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " após o saque é: R$" + contaAndre.Saldo + "\n");
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar o saque!");
}


//TESTANDO VALIDAÇÃO DE SALDO NEGATIVO
contaAndre.Saldo = -10;
Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " é: R$" + contaAndre.Saldo + "\n");

//RETORNANDO O TOTAL DE CONTAS CRIADAS
Console.WriteLine("O total de contas criadas é: "+ ContaCorrente.TotalContasCriadas + "\n");
*/


//---------------------TESTANDO FUNCIONARIOS-------------------------------------------

Funcionario designer = new Designer("Rafael Dias", "111.111.111-11", 2000);

Funcionario diretor = new Diretor("Rosangela Silva", "222.222.222-22", 10000);

Funcionario auxiliar = new Auxiliar("Pedro Orochi", "333.333.333-33", 1200);

Funcionario contador = new Contador("Barack Obama", "44.44.44-44", 3000);

Console.WriteLine("O salário do(a) " + designer.Nome + " é: " + designer.Salario);
Console.WriteLine("O salário do(a) " + diretor.Nome + " é: " + diretor.Salario);
Console.WriteLine("O salário do(a) " + auxiliar.Nome + " é: " + auxiliar.Salario);
Console.WriteLine("O salário do(a) " + contador.Nome + " é: " + contador.Salario + "\n");

////Total Funcionarios
Console.WriteLine("O total de funcionários é: " + Funcionario.TotalFuncionarios + "\n");

//Aumentar Salario
CalcularBonificacoes();

designer.AumentarSalario();
diretor.AumentarSalario();
auxiliar.AumentarSalario();
contador.AumentarSalario();

Console.WriteLine("Amento de salário");
Console.WriteLine("O salário do(a) " + designer.Nome + " é: " + Math.Round(designer.Salario));
Console.WriteLine("O salário do(a) " + diretor.Nome + " é: " + Math.Round(diretor.Salario));
Console.WriteLine("O salário do(a) " + auxiliar.Nome + " é: " + Math.Round(auxiliar.Salario));
Console.WriteLine("O salário do(a) " + contador.Nome + " é: " + Math.Round(contador.Salario) + "\n");

//Bonificar
designer.Bonificar();
diretor.Bonificar();
auxiliar.Bonificar();
contador.Bonificar();

Console.WriteLine("Bonificação");
Console.WriteLine("O salário do(a) " + designer.Nome + " é: " + Math.Round(designer.Salario));
Console.WriteLine("O salário do(a) " + diretor.Nome + " é: " + Math.Round(diretor.Salario));
Console.WriteLine("O salário do(a) " + auxiliar.Nome + " é: " + Math.Round(auxiliar.Salario));
Console.WriteLine("O salário do(a) " + contador.Nome + " é: " + Math.Round(contador.Salario) + "\n");

//Gerenciador de bonificações
CalcularBonificacoes();
void CalcularBonificacoes()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    gerenciador.GetTotalBonificacoes(designer);
    gerenciador.GetTotalBonificacoes(diretor);
    gerenciador.GetTotalBonificacoes(auxiliar);
    gerenciador.GetTotalBonificacoes(contador);

    Console.WriteLine("Total De bonificações: "+ gerenciador.TotalBonificacoes + "\n");
}

Console.ReadLine();