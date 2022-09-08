using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Cliente : Pessoa
    {
       
        public float FaixaSalario{set;get;}

        public Cliente()
        {

        }

        public Cliente(float faixaSalario)
        {
            FaixaSalario = faixaSalario;
          
        }

        public Cliente CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Endereco e1 = new Endereco();
            cliente.endereco = e1;

            Console.Clear();
            Console.WriteLine(" Insira abaixo os dados necessario para ser cadastrado\n" +
                "\n DADOS PESSOAIS\n --------------");
           
            Console.Write(" Nome: ");
            cliente.Nome = Console.ReadLine();
            Console.Write(" CPF : ");
            cliente.CPF = Console.ReadLine();
            Console.Write(" Email: ");
            cliente.Email = Console.ReadLine();
            Console.Write(" Telefone : ");
            cliente.Telefone = Console.ReadLine();
            Console.Write(" Data de nasciemnto __/ __/ ____: ");
            cliente.DataNasc = DateTime.Parse(Console.ReadLine());
            Console.Write(" Salario mensal: R$");
            cliente.FaixaSalario=float.Parse(Console.ReadLine());
        
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" DADOS DE ENDEREÇO\n ----------------");
            Console.Write(" Logradouro: ");
            cliente.endereco.Rua = Console.ReadLine();
            Console.Write(" Numero: ");
            cliente.endereco.Numero = Console.ReadLine();
            Console.Write(" Bairro: ");
            cliente.endereco.Bairro = Console.ReadLine();
            Console.Write(" Cidade: ");
            cliente.endereco.Cidade = Console.ReadLine();
            Console.Write(" Estado: ");
            cliente.endereco.Estado = Console.ReadLine();


            Console.WriteLine("\nCadastro finalizado!\n\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(" Os dados que foram informados são: \n");
            Console.WriteLine(cliente.ToString());
                   
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

            return cliente;
          
        }

        public Conta_CC SolicitarAberturaConta()
        {
            Agente_Bancario agnt = new Agente_Bancario();
            Gerente grt = new Gerente();
            Conta_CC cnt = new Conta_CC(); 

            
                  
             Console.Write(" Seus dados foram guardados com sucessos\n\n Agora sera feita a solicitação de abertura de conta\n RS: ");
             
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
                Console.WriteLine("\n\n !!! ATENÇÃO !!! \n Guarde o numero da conta ele será necessario para você acessa-la.");

                Console.WriteLine("\n\nPressione ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
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

        public override string ToString()
        {
            return " DADOS PESSOAIS\n  Nome: " + Nome + "\n" +
                "  CPF: " + CPF + "\n  Email: " + Email + "\n" +
                "  Telefone: " + Telefone + "\n  Data de Nasciemnto: " + DataNasc + "\n" + "  Salario: "  + FaixaSalario+"\n" + endereco ;
        }
            
    }

}
