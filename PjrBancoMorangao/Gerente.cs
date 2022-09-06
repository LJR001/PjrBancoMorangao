using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Gerente:Funcionario
    {
        public void Cadastro()
        {
            Funcionario fun3 = new Funcionario();
            fun3.Nome = "Célia";
            fun3.NumRegistro = 00;
        }
      public  Conta_CC AutorizarConta(double salario)
        {
          
            if (salario < 650)
            {
                Console.WriteLine("Sua renda não atingiu ao teto minimo");
                Console.WriteLine("A criação da sua conta foi autorizada\n Bem-vindo ao clube");
                
                return new Conta_CC();
            }
            else if (salario > 20000)
            {
                Console.WriteLine("Sua renda ultrapassou o teto maximo");
                Console.WriteLine("A criação da sua conta foi autorizada\n Bem-vindo ao clube");
                return new Conta_CC();

            }
            else
            {
                Conta_CC conta = new Conta_CC();
                conta.verificacao = true;
                Console.WriteLine("Gerente aprovou sua conta");
                Console.WriteLine();
                Console.WriteLine("Aperte ENTER para proceguir");
                Console.Clear();

               
                return conta;
            }          
          
        }
        public void AutorizarEmprestimo()
        {

        }
    }
}
