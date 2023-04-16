using ByteBank.Contas;
using ByteBank.Titular;

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

Console.ReadLine();