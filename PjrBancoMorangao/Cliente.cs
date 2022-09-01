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

        Pessoa pessoa = new Pessoa();

        Endereco e1 = new Endereco();
        

        public Cliente()
        {
        }

        public void CadastrarCliente()
        {

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

            Console.WriteLine("\n Dados Informados\n");
            Console.WriteLine(pessoa.ToString());

            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadKey();
              
            SolicitarAberturaConta();
            return;
        }

        public string SolicitarAberturaConta()
        {
            char solicitar;
            Console.WriteLine(" Deseja fazer uma solicitação de abertura de conta?\n Digite:" +
                "\n S para Solicitar crição de conta\n N para não solicitar ");
            solicitar= char.Parse(Console.ReadLine());

           switch(solicitar)
            {
                case 'S':
                    Console.WriteLine("Para solicitar abertura de conta informe seu salario");
                    FaixaSalario = double.Parse(Console.ReadLine());
                    
                    break;
                case 'N':
                    Console.WriteLine("Você será levado ao menu");
                    break;
            }    

             
            return ToString();
        }
    }


    
}
