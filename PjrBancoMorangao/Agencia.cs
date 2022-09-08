using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Agencia
    {
        public int NumAgencia { get; set; }
        public Endereco endereco { get; set; }

        public Agencia TrocarAgencia()
        {
            Agencia agencia = new Agencia();   
            Endereco endereco = new Endereco(); 
            agencia.endereco = endereco;

            Console.Write(" Digite em qual agencia você esta:\n\n 159 - Agencia Morangão Taquaritinga\n " +
                   "148 - Agencia Morangão Araraquara\n\n");
            int opc = 0;
            do
            {
                                
                Console.Write(" Digite a opção que deseja: ");
                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                   // Console.WriteLine(" Informe apenas numeros! ");
                    //throw;
                }
               

                    switch (opc)
                    {
                        case 159:
                            Console.Clear();
                            Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão \n");
                            agencia.NumAgencia = 159;
                            agencia.endereco.Cidade = "Taquaritinga";

                            break;
                        case 148:
                            Console.Clear();
                            Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão \n");
                            agencia.NumAgencia = 148;
                            agencia.endereco.Cidade = "Araraquara";

                            break;
                        default:
                            Console.Write("Você informou uma opção inexistente!\n ");
                            break;

                    }
                
              
               
            }while ((opc != 159) && (opc !=148 ));
            return agencia;
        }
    }
}
