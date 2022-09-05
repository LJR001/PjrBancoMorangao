using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Agente_Bancario:Funcionario
    {
        public Agente_Bancario()
        {

        }
        public void cadastro()
        {
           Funcionario fun1 = new Funcionario();
            Funcionario fun2 = new Funcionario();

            fun1.Nome = "Ricardo";
            fun1.NumRegistro = 01;

            fun2.Nome = "Marcelo";
            fun2.NumRegistro = 02;


        }
        public double AvaliarTipoConta(double salario)
        {
           // string tipoConta;
            if(salario < 1200)
            {
                Console.WriteLine("Sua conta será uma conta UNIVERSITÁRIA");
               // tipoConta = "Universitaria";
            }
            else if (salario < 6000)
            {
                Console.WriteLine("Sua conta será uma conta NORMAL");
              //  tipoConta = "Normal";
            }
            else 
            {
                Console.WriteLine("Parabens!!! Sua conta será uma conta VIP");
               // tipoConta = "VIP";
            }
            //tipoConta
            return salario ;
        }
    }
}
