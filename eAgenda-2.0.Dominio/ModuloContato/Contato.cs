using eAgenda_2._0.Dominio.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Dominio.ModuloContato
{
    public class Contato
    {
        private int numero;
        private string nome;
        private string email;
        private string telefone;
        private string empresa;
        private string cargo;
        private bool estaAnexado = false;

        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public bool EstaAnexado { get => estaAnexado; set => estaAnexado = value; }

        public override string ToString()
        {
            return $"Número: {Numero} - Nome: {Nome} - Email: {Email}";
        }
    }
}
