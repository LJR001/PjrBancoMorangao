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
        public float SaldoConta { get; set; }
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
        public float TransferirValor(float saldo, float transfer, int num)
        {
            float resultado = saldo - transfer;
            Console.WriteLine("O valor: " + transfer + " foi transferido para conta " + num);
            return resultado;
           
        }
        public void ConsultarExtrato()
        {
            Console.WriteLine(" Essa opção está sendo desenvolvida");

        }


        public float RealizarPagamento(float saldo, float codBarra, float pagar)
        {
           float result = saldo - pagar;

            return result;
           
        }

        public float Sacar(float saldo, float saque)
        {
            float resultado = saldo - saque;

            return resultado;
        }
        public float Depositar(float saldo, float deposito)
        {
            float resultado = saldo + deposito;

            return resultado;
        }
        public void ConsultarSaldo(float Consultar)
        {
            Console.WriteLine(" Seu saldo é:" + Consultar);
            Console.ReadKey();
        }
        public void ConsultarChequeEspecial()
        {
          //  double aux;
           // aux = valor *0.7;
            Console.WriteLine("Limite cheque especial");
        }
        public void AcessarCartaoCredito()
        {
            Console.WriteLine(" Essa opção está sendo desenvolvida");
        }
    }
}

