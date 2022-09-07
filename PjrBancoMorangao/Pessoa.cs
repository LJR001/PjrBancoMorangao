using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjrBancoMorangao
{
    internal class Pessoa
    {
        public string Nome { set; get; }
        public string CPF { set; get; }
        public string Email { set; get; }
        public string Telefone { set; get; }
        public DateTime DataNasc { set; get; }

        public Endereco endereco { get; set; }



        public Pessoa()
        {
        }

        public Pessoa(string nome, string cpf, string email, string telefone, DateTime dataNasc,Endereco endrco)         {
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.DataNasc = dataNasc;
            this.endereco = endrco;

            //Endereco endereco = new Endereco(rua, numero, cidade, bairro);
           
        }/*
        public override string ToString()
        {
            return " Dados Pessoais\n Nome: "+Nome+"\n" +
                " CPF: "+CPF+"\n Email: "+Email+"\n" +
                " Telefone: "+Telefone+"\n Data de Nasciemnto: "+DataNasc+"\n" +endereco;
        }*/
    }
}
