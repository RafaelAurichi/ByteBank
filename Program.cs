using ByteBank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André Silva";
contaAndre.numConta = "1010-X";
contaAndre.numAgecia = 15;
contaAndre.saldo = 100;

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numConta = "1010-5";
contaMaria.numAgecia = 17;
contaMaria.saldo = 350;

Console.WriteLine("O saldo da conta do " + contaAndre.titular + " é: R$" + contaAndre.saldo + "\n");

Console.WriteLine("O saldo da conta do " + contaMaria.titular + " é: R$" + contaMaria.saldo + "\n");

if (contaAndre.Transferir(50, contaMaria) == true)
{
    Console.WriteLine("Transferência realizada com sucesso!\n");
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar a transferência!\n");
}

Console.WriteLine("O saldo da conta do " + contaAndre.titular + " é: R$" + contaAndre.saldo + "\n");

Console.WriteLine("O saldo da conta do " + contaMaria.titular + " é: R$" + contaMaria.saldo + "\n");

/*
contaAndre.Depositar(100);
Console.WriteLine("O saldo da conta do " + contaAndre.titular + " após o depósito é: R$" + contaAndre.saldo + "\n");
*/

/*
if (contaAndre.Sacar(150) == true)
{
    Console.WriteLine("Saque realizado com sucesso!");
    Console.WriteLine("O saldo da conta do " + contaAndre.titular + " após o saque é: R$" + contaAndre.saldo + "\n");
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar o saque!");
}
*/



Console.ReadLine();