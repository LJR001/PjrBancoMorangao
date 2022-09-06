using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Cartao_Credito
    {
        public string Nome { get; set; }
        public int NumCartao { get; set; }
        public int Limite { get; set; }
        public DateTime ValidadeCartao { get; set; }
        public bool EstadoCartao { get; set; }

        public void DesbloquearCartao()
        {

        }
    }
}
