using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Conta_CC
    {
        public int NumConta { get; set; }
        public string TipoConta { get; set; }
        public int Senha { get; set; }
        public double ChequeEspecial { get; set; }
        public bool verificacao { get; set; }
        public Conta_CC()
        {
            this.verificacao = false;
        }

        public Conta_CC(int numConta,string tipoConta, int senha, double chequeEspecial)
        {
            NumConta = numConta;
            TipoConta = tipoConta;
            Senha = senha;
            ChequeEspecial = chequeEspecial;
        }
     /*   public void Verificacar()
        {
            // Gerente grt = new Gerente();
            this.verificacao = true;
        }
     */

        public void SolicitarEmprestimo()
        {
            Console.WriteLine(" Solicitar emprestimo");
        }
        public void TransferirValor()
        {
            Console.WriteLine(" Transferencia de valor");
        }
        public void ConsultarExtrato()
        {
            Console.WriteLine(" Consultar extrato");
        }


        public void RealizarPagamento()
        {
            int codBarra;

            Console.Write(" Digite o codigo de barra da sua fatura: ");
            codBarra=int.Parse(Console.ReadLine());
            Console.Write(" Digite o valor da conta: R$");
        }

        public void Sacar()
        {
            double aux; 
            Console.WriteLine(" Sacar");
            Console.WriteLine(" Digite a quantidade que deseja sacar");
            aux = double.Parse(Console.ReadLine());
           // valor = valor - aux;            
        }
        public void Depositar()
        {
            double aux;
            Console.WriteLine(" Depositar");
            Console.WriteLine(" Digite a quantidade que deseja depositar");
            aux=double.Parse(Console.ReadLine());
          //  valor =  valor + aux;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine(" Seu saldo é:");
        }
        public void ConsultarChequeEspecial()
        {
          //  double aux;
           // aux = valor *0.7;
            Console.WriteLine("Limite cheque especial");
        }
        public void AcessarCartaoCredito()
        {
            Console.WriteLine(" Acessar cartão credito");
        }
    }
}

