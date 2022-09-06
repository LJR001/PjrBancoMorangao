using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Cliente : Pessoa
    {
       // Pessoa pessoa;
        public double FaixaSalario{set;get;}
           
        
        public Cliente()
        {
        }

        public Pessoa CadastrarCliente()
        {
            Pessoa pessoa = new Pessoa();

            Endereco e1 = new Endereco();

            pessoa.endereco = e1;
            Console.Clear();
            Console.WriteLine(" Insira abaixo os dados necessario para ser cadastrado\n");

            Console.Write(" Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write(" CPF: ");
            pessoa.CPF = Console.ReadLine();
            Console.Write(" Email: ");
            pessoa.Email = Console.ReadLine();
            Console.Write(" Telefone: ");
            pessoa.Telefone = long.Parse(Console.ReadLine());
            Console.Write(" Data de nasciemnto: ");
            pessoa.DataNasc = DateTime.Parse(Console.ReadLine());
                      
           // Console.WriteLine("\n\n Tecle ENTER proseguir para o cadastro de endereço");
            //Console.ReadKey();
           // Console.Clear();

            Console.WriteLine();

            Console.Write(" Logradouro: ");
            pessoa.endereco.Rua = Console.ReadLine();
            Console.Write(" Numero: ");
            pessoa.endereco.Numero = Console.ReadLine();
            Console.Write(" Bairro: ");
            pessoa.endereco.Bairro = Console.ReadLine();
            Console.Write(" Cidade: ");
            pessoa.endereco.Cidade = Console.ReadLine();
            Console.Write(" Estado: ");
            pessoa.endereco.Estado = Console.ReadLine();    

            Console.WriteLine("\n Dados que foram informados são: \n");
            Console.WriteLine(pessoa.ToString());

        

            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

            return pessoa;
            // SolicitarAberturaConta();
            // return;
        }

        public Conta_CC SolicitarAberturaConta()
        {
            Agente_Bancario agnt = new Agente_Bancario();
            Gerente grt = new Gerente();
            Conta_CC cnt = new Conta_CC(); 
            /*
            bool aprovado;
            string tipoConta;*/
         
            
            
            Console.WriteLine(" Fazendo solicitação de conta\n");
                    
                    Console.Write("Para solicitar abertura de conta informe seu salario\n RS: ");
                    FaixaSalario = double.Parse(Console.ReadLine());
                   // tipoConta =  agnt.AvaliarTipoConta(FaixaSalario);
                   
                  //  int numConta = int.Parse(Console.ReadLine());
                   
                   
                     // grt.AutorizarConta(FaixaSalario);
                    cnt = grt.AutorizarConta(FaixaSalario);

                    cnt.TipoConta = agnt.AvaliarTipoConta(FaixaSalario);

            /*       if (aprovado)
                   {
                       Conta_CC conta = new Conta_CC(numConta,tipoConta,numSenha,cheque);

                       return conta;
                   }
                    else
                    {
                         Conta_CC conta = new Conta_CC(0, " ", 0, 0);
                        return conta;
                    }
            */
            return cnt;
        }
                    


              

             
          
        
    }


    
}
