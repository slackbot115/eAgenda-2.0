using eAgenda_2._0.Dominio.ModuloCompromisso;
using eAgenda_2._0.Infra.Arquivos.ISerializadores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda_2._0.Infra.Arquivos.SerializacaoJson
{
    public class SerializadorCompromissosJson : ISerializadorCompromissos
    {
        private static string caminhoCompromissos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string arquivoCompromissos = caminhoCompromissos + @"\compromissos.json";

        public List<Compromisso> CarregarCompromissosDoArquivo()
        {
            if (!Directory.Exists(caminhoCompromissos))
            {
                Directory.CreateDirectory(caminhoCompromissos);
            }
            if (File.Exists(arquivoCompromissos) == false)
                return new List<Compromisso>();

            string compromissosJson = File.ReadAllText(arquivoCompromissos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Compromisso>>(compromissosJson, settings);
        }

        public void GravarCompromissosEmArquivo(List<Compromisso> compromissos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string compromissosJson = JsonConvert.SerializeObject(compromissos, settings);

            File.WriteAllText(arquivoCompromissos, compromissosJson);
        }
    }
}
