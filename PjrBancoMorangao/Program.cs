using System;
using System.Collections.Generic;

namespace PjrBancoMorangao
{
    internal class Program
    {
        static void Login(List<Conta_CC> listCont, Agencia agn)
        {
            int ver = 0;
            bool validador = true;
            Console.WriteLine(" Digite o nuemro da Conta para acessar sua conta:");
            Console.Write(" Digite o numero da conta: ");
            do
            {
                try
                {
                    ver = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    throw;
                }

                foreach (Conta_CC cc in listCont)
                {
                    if (cc.NumConta == ver)
                    {

                        MenuConta(cc, listCont, agn);
                    }
                    else
                    {
                        Console.WriteLine(" Conta não encontrada\n Digite o numero de uma conta existente");
                        validador = false;
                    }

                }
            } while (validador == false);
        }
        static void MenuConta(Conta_CC conta, List<Conta_CC> listCont, Agencia agn)
        {


            Console.ReadKey();
            Console.Clear();
            int opc = 0;
            do
            {
                Console.WriteLine("Agencia: " + agn.NumAgencia + " " + agn.endereco.Cidade);
                Console.WriteLine("\nNome:" + conta.Cliente.Nome + "\nNumero da conta: " + conta.NumConta + "\t \t \t Saldo: " + conta.SaldoConta + "\n" + conta.ChequeEspecial);
                Console.Write(" \nSelecione o que você deseja fazer na sua conta:\n\n" +
                    " 1 - Consultar Saldo\n" +
                    " 2 - Depositar\n" +
                    " 3 - Sacar\n" +
                    " 4 - Transferência valor *\n" +
                    " 5 - Consultar extrato *\n" +
                    " 6 - Solicitar emprestimo *\n" +
                    " 7 - Consultar cheque especial *\n" +
                    " 8 - Acessar cartão credito *\n" +
                    " 9 - Realizar pagamentos\n" +
                    "10 - Conta Poupança *\n" +
                    " 0 - Voltar a menu anterior" +
                    "\n\n ( * ) Função ainda não foi desenvolvida" +
                    "\n\n Digite a opção que deseja: ");

                Console.Write(" Digite a opção que deseja: ");
                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    throw;
                }


                switch (opc)
                {
                    case 1:

                        Console.Clear();
                        conta.ConsultarSaldo(conta.SaldoConta);

                        break;
                    case 2:
                        float deposito = 0;

                        Console.Clear();
                        Console.WriteLine("Digite o valor que deseja depositar");

                        do
                        {
                            try
                            {
                                deposito = float.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                                
                            }

                            conta.SaldoConta = conta.Depositar(conta.SaldoConta, deposito);
                            if (deposito <= 0){
                                Console.WriteLine(" Aceitamos apenas numeros positivos");
                            }

                        } while (deposito <= 0);
                        break;
                    case 3:
                        float saque = 0;

                        Console.Clear();
                        Console.WriteLine(" Digite o valor que deseja sacar: ");

                        do
                        {
                            try
                            {

                                saque = float.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                                throw;
                            }

                            conta.SaldoConta = conta.Sacar(conta.SaldoConta, saque);
                            if (saque <= 0){
                                Console.WriteLine(" Aceitamos apenas numeros positivos");
                            }

                        } while (saque <= 0);

                        break;
                    case 4:

                      /*  Console.WriteLine(" Digite o valor que deseja transferir");
                        float transfer = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nomero da conta para que sera transferido o valor: ");
                        int numConta = int.Parse(Console.ReadLine());
                        conta.SaldoConta = conta.TransferirValor(conta.SaldoConta, transfer, numConta);*/

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
                        float pagar = 0;
                        try
                        {

                        }
                        catch (Exception)
                        {

                        }
                        do
                        {
                            Console.WriteLine(" Digite o codigos de barra da conta a ser paga:");
                            int codBarra = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Digite o valor da conta a pagar: ");
                            pagar = float.Parse(Console.ReadLine());
                            conta.RealizarPagamento(conta.SaldoConta, codBarra, pagar);
                            if ((pagar <= 0){
                                Console.WriteLine(" Aceitamos apenas numeros positivos");
                            }

                        } while (pagar <= 0);
                        break;

                    case 0:
                        Console.WriteLine(" Volta a menu anterior");
                        break;
                    default:
                        Console.Write("Você informou uma opção inexistente!\n ");
                        break;
                }
            } while (opc != 0);
            MenuCliente(listCont, agn);
        }


        static void MenuCliente(List<Conta_CC> contList, Agencia agn)
        {

            int opc = 0;

            Cliente cliente1 = new Cliente();
            Conta_CC conta1 = new Conta_CC();
            Agente_Bancario agnt = new Agente_Bancario();

            Console.WriteLine(" Escolha um das opções abaixo:\n");
            Console.Write(" 1 - Ja sou cliente \n 2 - Ainda não sou cliente \n 0 - Finalizar o programa\n\n Digite a opção que deseja: ");

            do
            {
                Console.Write(" Digite a opção que deseja: ");
                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }

                switch (opc)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Você selecionou 'Ja sou cliente'\n acessando conta conta...");
                        Console.WriteLine();
                        Console.Clear();
                        Login(contList, agn);

                        break;



                    case 2:
                        cliente1 = cliente1.CadastrarCliente();
                        conta1 = cliente1.SolicitarAberturaConta();
                        if (conta1 == null)
                        {

                            Console.WriteLine(" Sua conta não foi aprovada");
                            break;
                        }
                        else
                        {
                            conta1.Cliente = cliente1;

                            contList.Add(conta1);

                            // Console.Clear();
                            //Console.WriteLine(conta1.Cliente.Nome);
                        }


                        Login(contList, agn);

                        //  MenuConta(conta1);

                        break;

                    default:
                        Console.Write("Você informou uma opção inexistente!\n ");
                        break;

                }
            } while (opc > 2);


        }
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia();
            List<Conta_CC> contList = new List<Conta_CC>();

            agencia = agencia.TrocarAgencia();

            MenuCliente(contList, agencia);

        }
    }
}
