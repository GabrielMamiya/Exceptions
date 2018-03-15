using System;
using System.Globalization;

namespace Exceptions
{
    public class Conta
    {

        public string numeroDaConta { get; set; }
        public string nomeDoTitular { get; set; }
        public double limiteDeSaque { get; private set; }
        public double saldo { get; private set; }

        public Conta(string numeroDaConta, string nomeDoTitular, double limiteDeSaque)
        {
            this.numeroDaConta = numeroDaConta;
            this.nomeDoTitular = nomeDoTitular;
            this.limiteDeSaque = limiteDeSaque;
            this.saldo = 0.0;
        }

        public void realizaDeposito(double valorDeposito){
            this.saldo += valorDeposito;
            Console.WriteLine("Novo Saldo: " + this.saldo.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void realizaSaque(double valorSaque){

            if(valorSaque > limiteDeSaque){
                throw new OperationException("O valor a ser sacado ultrapassa o limite. Operacao Cancelada!");
            } else if (valorSaque > saldo){
                throw new OperationException("Limite insuficiente. Operacao Cancelada!");
            } else {
				this.saldo -= valorSaque;

            }

        }



    }
}
