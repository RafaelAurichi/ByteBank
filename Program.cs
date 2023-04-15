using ByteBank.Contas;
using ByteBank.Titular;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = "André Silva";
contaAndre.Titular.Cpf = "111.111.111-11";
contaAndre.Titular.Profissao = "Desenvolvedor";
contaAndre.NumConta = "1010-X";
contaAndre.NumAgencia = 15;
contaAndre.Saldo = 100;

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.Titular = new Cliente();
contaMaria.Titular.Nome = "Maria Souza";
contaMaria.Titular.Cpf = "222.222.222-22";
contaMaria.Titular.Profissao = "Desenvolvedora";
contaMaria.NumConta = "1010-5";
contaMaria.NumAgencia = 17;
contaMaria.Saldo = 350;

Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " é: R$" + contaAndre.Saldo + "\n");

Console.WriteLine("O saldo da conta do " + contaMaria.Titular.Nome + " é: R$" + contaMaria.Saldo + "\n");

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


contaAndre.Depositar(100);
Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " após o depósito é: R$" + contaAndre.Saldo + "\n");



if (contaAndre.Sacar(150) == true)
{
    Console.WriteLine("Saque realizado com sucesso!");
    Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " após o saque é: R$" + contaAndre.Saldo + "\n");
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar o saque!");
}

contaAndre.Saldo = -10;
Console.WriteLine("O saldo da conta do " + contaAndre.Titular.Nome + " é: R$" + contaAndre.Saldo + "\n");



Console.ReadLine();