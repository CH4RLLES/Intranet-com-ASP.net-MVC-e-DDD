using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IntranetCPT.Servicos
{
    public class WebApiServicos
    {
        HttpClient client;

        public async Task<T> GetAsync<T>(string caminho, string token = "")
        {
            client = new HttpClient();

            if (token != "")
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var retorno = await client.GetAsync(caminho);

            retorno.EnsureSuccessStatusCode();

            var json = retorno.Content.ReadAsStringAsync().Result;
            var dados = JsonConvert.DeserializeObject<T>(json);

            return dados;
        }

        public async Task<T> PostAsync<T>(string caminho, object corpo, string token = "")
        {
            client = new HttpClient();

            if (token != "")
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var conteudo = new StringContent(JsonConvert.SerializeObject(corpo), Encoding.UTF8, "application/json");
            var retorno = await client.PostAsync(caminho, conteudo);

            retorno.EnsureSuccessStatusCode();

            var json = retorno.Content.ReadAsStringAsync().Result;
            var dados = JsonConvert.DeserializeObject<T>(json);

            return dados;
        }
    }
}
