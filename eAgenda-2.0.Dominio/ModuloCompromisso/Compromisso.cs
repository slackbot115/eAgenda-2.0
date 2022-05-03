using eAgenda_2._0.Dominio.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Dominio.ModuloCompromisso
{
    public class Compromisso
    {
        private int numero;
        private string assunto;
        private string local;
        private DateTime dataCompromisso;
        private string horaInicio;
        private string horaTermino;
        private Contato contato;

        public string Assunto { get => assunto; set => assunto = value; }
        public string Local { get => local; set => local = value; }
        public DateTime DataCompromisso { get => dataCompromisso; set => dataCompromisso = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraTermino { get => horaTermino; set => horaTermino = value; }
        public Contato Contato { get => contato; set => contato = value; }
        public int Numero { get => numero; set => numero = value; }

        public override string ToString()
        {
            return $"Número: {Numero} - Assunto: {Assunto} - Contato: {Contato.Nome}";
        }
    }
}
