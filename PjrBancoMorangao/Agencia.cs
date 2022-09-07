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

        public void TrocarAgencia()
        {
            Console.Write(" Digite em qual agencia você esta:\n\n 1 - Agencia Morangão Taquaritinga\n " +
               "2 - Agencia Morangão Araraquara" +
               "\n\n Digite a opção que deseja: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão \n");
                    
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Bem-vindo a nossa agencia de Taquaritinga do Banco Morangão \n");
                   
                    break;
            }
        }
    }
}
