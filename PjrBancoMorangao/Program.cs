using System;

namespace PjrBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente cliente = new Cliente();
            int opc = 0;
            Cliente cliente1 = new Cliente();

            MenuIniciar();
                     

             void MenuIniciar()
            {
                int opc;
                Console.WriteLine(" Bem-vindo ao sistema do Banco Morangão\n");
                Console.Write(" 1 - Ja sou cliente \n 2 - Ainda não sou cliente \n 0 - Finalizar o programa\n\n Digite a opção que deseja: ");
                opc = int.Parse(Console.ReadLine());

                
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("Você selecionou 'Ja sou cliente'\n acessar conta");

                            break;
                        case 2:
                             cliente1.CadastrarCliente();
                             
                            break;
                          
                    }
                                                        
               
                return ;
             }
            
            

            // Console.WriteLine(pessoa.endereco);

        }
    }
}
