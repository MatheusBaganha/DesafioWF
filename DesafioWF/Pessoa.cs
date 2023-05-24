using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWF
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Pessoa() { }
        public Pessoa(string nome, string cidade, string rg, string cpf, string telefone)
        {
            Nome = nome;
            Cidade = cidade;
            RG = rg;
            CPF = cpf;
            Telefone = telefone;
        }
    }
}
