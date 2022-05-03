using eAgenda_2._0.Dominio.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda_2._0.TelasCompromisso
{
    public partial class DetalhesCompromisso : Form
    {
        private Compromisso compromisso;

        public DetalhesCompromisso(Compromisso compromisso)
        {
            this.compromisso = compromisso;

            InitializeComponent();

            dateHoraInicio.Format = DateTimePickerFormat.Custom;
            dateHoraInicio.CustomFormat = "HH:mm";
            dateHoraInicio.ShowUpDown = true;
            dateHoraTermino.Format = DateTimePickerFormat.Custom;
            dateHoraTermino.CustomFormat = "HH:mm";
            dateHoraTermino.ShowUpDown = true;
        }

        public Compromisso Compromisso
        {
            get => compromisso;
            set
            {
                compromisso = value;
                txtNumero.Text = compromisso.Numero.ToString();
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                if (compromisso.DataCompromisso < dateDataCompromisso.MinDate)
                {
                    dateDataCompromisso.Value = DateTime.Now;
                }
                else
                    dateDataCompromisso.Value = compromisso.DataCompromisso;
                dateHoraInicio.Text = compromisso.HoraInicio;
                dateHoraTermino.Text = compromisso.HoraTermino;
                if (String.IsNullOrEmpty(txtContato.Text))
                    txtContato.Text = compromisso.Contato.Nome;
            }
        }

    }
}
