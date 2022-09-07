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

        public Cliente(double faixaSalario)
        {
            FaixaSalario = faixaSalario;
          
        }

        public Pessoa CadastrarCliente()
        {
            Pessoa pessoa = new Pessoa();

            Endereco e1 = new Endereco();
            pessoa.endereco = e1;

            Console.Clear();
            Console.WriteLine(" Insira abaixo os dados necessario para ser cadastrado\n" +
                "\n DADOS PESSOAIS\n --------------");
           
            Console.Write(" Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write(" CPF (XXX. XXX . XXX - XX): ");
            pessoa.CPF = Console.ReadLine();
            Console.Write(" Email: ");
            pessoa.Email = Console.ReadLine();
            Console.Write(" Telefone (XX) X XXXX - XXXX : ");
            pessoa.Telefone = Console.ReadLine();
            Console.Write(" Data de nasciemnto XX/ XX/ XXXX: ");
            pessoa.DataNasc = DateTime.Parse(Console.ReadLine());
        
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" DADOS DE ENDEREÇO\n ----------------");
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


            Console.WriteLine("\nCadastro finalizado!\n\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(" Os dados que foram informados são: \n");
            Console.WriteLine(pessoa.ToString());
                   
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

            return pessoa;
          
        }

        public Conta_CC SolicitarAberturaConta()
        {
            Agente_Bancario agnt = new Agente_Bancario();
            Gerente grt = new Gerente();
            Conta_CC cnt = new Conta_CC(); 
                  
             Console.Write(" Seus dados foram guardados com sucessos\n\n Agora informe o seu salario ser feita a solicitação de abertura de conta\n RS: ");
             FaixaSalario = float.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine(" Fazendo solicitação de conta . . \n");
            Console.WriteLine();

            
            cnt.verificacao = grt.AutorizarConta(FaixaSalario);


            if (cnt.verificacao)
            {
                
                cnt.ChequeEspecial = 0;

                Console.WriteLine("Sua conta foi autorizada, segue abaixo as informação de sua conta\n");

                int id = Random(100,999);
                Console.WriteLine(" Numero conta: "+id);
                cnt.NumConta = id;
                cnt.TipoConta = agnt.AvaliarTipoConta(FaixaSalario);
                Console.WriteLine(" Limite do cheque especial: R$" + (FaixaSalario * 0.7));
                cnt.ChequeEspecial = (FaixaSalario * 0.7);
                Console.WriteLine(" Saldo da conta: R$ 0,00");
                cnt.SaldoConta = 0;

                return cnt;
            }
            else
            {
                Console.WriteLine("Conta não aprovado");
                return null;
            }

        }
                 

        public int Random (int min, int max)
        {
            Random r = new Random();
            return r.Next(100,999);
        }
            
    }

}
