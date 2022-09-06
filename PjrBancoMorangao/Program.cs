using System;

namespace PjrBancoMorangao
{
    internal class Program
    {

        static void MenuConta() 
        {
            
            Conta_CC conta = new Conta_CC();
            Console.WriteLine("Para acessar sua conta faça o login abaixo:\n\n Numero conta: \n\n Senha: ");
            // login, senha;
            // if()
            Console.ReadKey();
            Console.Clear();
            int opc;
            do
            {
                Console.Write(" Selecione o que você deseja fazer na sua conta:\n\n 1 - Consultar Saldo\n" +
                    " 2 - Depositar\n" +
                    " 3 - Sacar\n" +
                    " 4 - Transferência valor \n" +
                    " 5 - Consultar extrato\n" +
                    " 6 - Solicitar emprestimo\n" +
                    " 7 - Consultar cheque especial\n" +
                    " 8 - Acessar cartão credito\n" +
                    " 9 - Realizar pagamentos\n" +
                    "10 - Conta Poupança\n" +
                    " 0 - Voltar a menu anterior" +
                    "\n\n Digite a opção que deseja: ");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:

                        conta.ConsultarSaldo();
                        break;
                    case 2:
                        Console.WriteLine("Digite o quanto deseja depositar");
                        conta.Depositar();
                        break;
                    case 3:

                        conta.Sacar();
                        break;
                    case 4:

                        conta.TransferirValor();
                        break;
                    case 5:
                        
                        conta.ConsultarExtrato();
                        break;
                    case 6:

                        conta.SolicitarEmprestimo();
                        break;
                    case 7:

                        conta.LimiteChequeEspecial();
                        break;
                    case 8:

                        conta.AcessarCartaoCredito();
                        break;
                    case 9:
                        conta.RealizarPagamento();
                        break;
                    case 0:
                        Console.WriteLine(" Volta a menu anterior");
                        break;
                }
            } while (opc != 0);
            MenuCliente();
        }

        static void MenuCliente()
        {
            int opc;
            
            Cliente cliente1 = new Cliente();
            Pessoa pessoa = new Pessoa();
            Conta_CC conta1 = new Conta_CC();
            Agente_Bancario agnt = new Agente_Bancario();
            Console.WriteLine(" Escolha um das opções abaixo:\n");
            Console.Write(" 1 - Ja sou cliente \n 2 - Ainda não sou cliente \n 0 - Finalizar o programa\n\n Digite a opção que deseja: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Você selecionou 'Ja sou cliente'\n acessando conta conta...");
                    Console.WriteLine();
                    Console.Clear();
                    MenuConta();

                    break;
                case 2:
                    pessoa = cliente1.CadastrarCliente();
                    conta1 = 
                    
                  

                    MenuConta();
                  
                    break;
            }


            return;
        }

        static void Main(string[] args)
        {
            
            Console.Write(" Digite em qual agencia você esta:\n\n 1 - Agencia Morangão Taquaritinga\n " +
                "2 - Agencia Morangão Araraquara" +
                "\n\n Digite a opção que deseja: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão");
                    MenuCliente();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão");
                    MenuCliente();
                    break;
            }
                

            
             
        }
    }
}
