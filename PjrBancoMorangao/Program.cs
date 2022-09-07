using System;

namespace PjrBancoMorangao
{
    internal class Program
    {

        static void MenuConta(Conta_CC conta) 
        {
           
            Console.ReadKey();
            Console.WriteLine("Para acessar sua conta faça o login abaixo:\n\n Numero conta: \n\n Senha: ");
           
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

                        Console.Clear();
                        conta.ConsultarSaldo(conta.SaldoConta);
                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja depositar");
                        float deposito = float.Parse(Console.ReadLine());
                        conta.SaldoConta = conta.Depositar(conta.SaldoConta, deposito);
                        
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" Digite o valor que deseja sacar: ");
                        float saque = float.Parse(Console.ReadLine());
                        conta.SaldoConta = conta.Sacar(conta.SaldoConta, saque);
                       
                        break;
                    case 4:
                        
                        Console.WriteLine(" Digite o valor que deseja transferir");
                        float transfer = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nomero da conta para que sera transferido o valor: ");
                        int numConta = int.Parse(Console.ReadLine());
                        conta.SaldoConta = conta.TransferirValor(conta.SaldoConta, transfer, numConta);
                          
                        break;
                    case 5:
                        
                        conta.ConsultarExtrato();
                        break;
                    case 6:

                        conta.SolicitarEmprestimo();
                        break;
                    case 7:

                        conta.ConsultarChequeEspecial();
                        break;
                    case 8:

                        conta.AcessarCartaoCredito();
                        break;
                    case 9:

                        Console.WriteLine(" Digite o codigos de barra da conta a ser paga:");
                        int codBarra = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Digite o valor da conta a pagar: ");
                        float pagar = float.Parse(Console.ReadLine());
                        conta.RealizarPagamento(conta.SaldoConta, codBarra, pagar); 
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
                    MenuConta(conta1);

                    break;
                case 2:
                    pessoa = cliente1.CadastrarCliente();
                    conta1 = cliente1.SolicitarAberturaConta();
                    

                    MenuConta(conta1);

                    break;
            }


            return;
        }

        static void Main(string[] args)
        {
            Agencia agencia = new Agencia();
            agencia.TrocarAgencia();

            MenuCliente();



        }
    }
}
