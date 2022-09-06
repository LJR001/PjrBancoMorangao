﻿using System;
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
        public string AvaliarTipoConta(double salario)
        {
           string tipoConta;
            if(salario < 1200)
            {
                tipoConta = "UNIVERSITARIA";
                Console.WriteLine("Sua conta será uma conta "+tipoConta);
                 
            }
            else if (salario < 6000)
            {
                tipoConta = "NORMAL";
                Console.WriteLine("Sua conta será uma conta " + tipoConta);
                    
            }
            else 
            {
                tipoConta = "VIP";
                Console.WriteLine("Parabens!!! Sua conta será uma conta " +tipoConta);
                    
            }
            
            return tipoConta ;
        }
    }
}
