using eAgenda_2._0.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace eAgenda_2._0.Infra.Arquivos
{
    public class SerializadorTarefasJson : ISerializadorTarefas
    {
        private static string caminhoTarefas = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string arquivoTarefas = caminhoTarefas + @"\tarefas.json";

        public List<Tarefa> CarregarTarefasDoArquivo()
        {
            if (!Directory.Exists(caminhoTarefas))
            {
                Directory.CreateDirectory(caminhoTarefas);
            }
            if (File.Exists(arquivoTarefas) == false)
                return new List<Tarefa>();

            string tarefasJson = File.ReadAllText(arquivoTarefas);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Tarefa>>(tarefasJson, settings);
        }

        public void GravarTarefasEmArquivo(List<Tarefa> tarefas)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(tarefas, settings);

            File.WriteAllText(arquivoTarefas, tarefasJson);
        }
    }
}
