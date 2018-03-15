using System;
using System.Globalization;

namespace Exceptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Numero da conta: ");
            string numeroDaConta = Console.ReadLine();
            Console.Write("Nome do titular: ");
            string nomeDoTitular = Console.ReadLine();
            Console.Write("Limite de saque: ");
            double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta c = new Conta(numeroDaConta, nomeDoTitular, limiteDeSaque);

            Console.Write("Informe um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // exibe na tela novo saldo
            c.realizaDeposito(valorDeposito);

            Console.Write("Informe um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   
            try {
                c.realizaSaque(valorSaque);
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("Novo Saldo: " + c.saldo);
            }
            catch (OperationException e){
                Console.WriteLine(e.Message);
            }
   
			


        }
    }
}
