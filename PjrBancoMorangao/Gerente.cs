using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Gerente:Funcionario
    {
      public  bool AutorizarConta(double salario)
        {
            bool apv = false;
            if (salario < 650)
            {
                Console.WriteLine("Sua renda não atingiu ao teto minimo");
                Console.WriteLine("A criação da sua conta foi autorizada\n Bem-vindo ao clube");
                apv = false;
                return apv;
            }
            else if (salario > 20000)
            {
                Console.WriteLine("Sua renda ultrapassou o teto maximo");
                Console.WriteLine("A criação da sua conta foi autorizada\n Bem-vindo ao clube");
                apv = false;
                return apv;
            }
            else
            {
                Console.WriteLine("Aprovado");
                apv = true;
                return apv;
            }
                          
          
        }
    }
}
