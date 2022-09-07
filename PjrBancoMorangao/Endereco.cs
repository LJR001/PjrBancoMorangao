using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Endereco
    {
         public string Rua { set; get; }
            public string Numero { set; get; }
            public string Bairro { set; get;}
            public string Cidade { set; get;}
            public string Estado { set; get; }
         

        public Endereco()
        {
           
        }

        public override string ToString()
        {
            return "\n Rua: "+Rua+"\n" +
                " Numero: "+Numero+"\n Bairro: "+ Bairro +" Cidade: "+Cidade+"\n Estado: "+Estado;
        }
    }
    
}
