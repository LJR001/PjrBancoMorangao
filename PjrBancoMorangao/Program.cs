using System;

namespace PjrBancoMorangao
{
    internal class Program
    {

        static void MenuConta() 
        {
            
            Conta_CC conta1 = new Conta_CC();
            Console.WriteLine("Para acessar sua conta faça o login abaixo:\n Numero conta: \n Senha: ");
            // login, senha;
            // if()
            Console.ReadKey();
            Console.Clear(); 

            Console.WriteLine(" Selecione o que você deseja fazer na sua conta:\n1 - Consultar Saldo\n" +
                "2 - Depositar\n" +
                "3 - Sacar\n" +
                "4 - Transferência valor \n" +
                "5 - Consultar extrato\n" +
                "6 - Solicitar emprestimo\n" +
                "7 - Consultar cheque especial\n" +
                "8 - Acessar cartão credito\n" +
                "0 - Voltar a menu anterior");         
                
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine(" Consultar Saldo");
                   break;
                case 2:
                    Console.WriteLine(" Depositar");
                    break ;
                case 3:
                    Console.WriteLine(" Sacar");
                    break;
                case 4:
                    Console.WriteLine(" Transferencia de valor");
                    break;
                case 5:
                    Console.WriteLine(" Consultar extrato");
                    break;
                case 6:
                    Console.WriteLine(" Solicitar emprestimo");
                    break;
                case 7:
                    Console.WriteLine(" Consultar cheque especial");
                    break;
                case 8:
                    Console.WriteLine(" Acessar cartão credito");
                    break;
                case 0:
                    Console.WriteLine(" Volta a menu anterior");
                    break;
            }
           


            

        }

        static void MenuIniciar()
        {
            int opc;
            
            Cliente cliente1 = new Cliente();
            Cliente solicitar = new Cliente();
            Pessoa pessoa = new Pessoa();
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
                    cliente1.SolicitarAberturaConta();


                  /*  Console.WriteLine(pessoa.CPF);
                    Console.ReadKey();
                */

                    break;

            }


            return;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Digite em qual agencia você esta:\n 1 - Agencia Morangão Taquaritinga\n " +
                "2 - Agencia Morangão Araraquara");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão");
                    MenuIniciar();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão");
                    MenuIniciar();
                    break;
            }
                

            
             
        }
    }
}
