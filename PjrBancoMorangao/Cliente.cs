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

        public string SolicitarAberturaConta()
        {
            Agente_Bancario agnt = new Agente_Bancario();
            Gerente grt = new Gerente();
            string solicitar;
            Console.WriteLine(" Deseja fzer solicitação de abertura de conta?\n");
            Console.Write(" 1 - Sim, Desejo fazer a solicitação  \n 2 - Não desejo fazer a solicitação \n\n Digite a opção que deseja: ");
            solicitar = Console.ReadLine();

            switch (solicitar)
            {
                case "1":
                    Console.Write("Para solicitar abertura de conta informe seu salario\n RS ");
                    FaixaSalario = double.Parse(Console.ReadLine());
                    agnt.AvaliarTipoConta(FaixaSalario);
                    grt.AutorizarConta(FaixaSalario);

                    break;
                case "2":
                    Console.WriteLine("Você será levado ao menu");
                    break;
            }    

             
            return solicitar;
        }
        
    }


    
}
