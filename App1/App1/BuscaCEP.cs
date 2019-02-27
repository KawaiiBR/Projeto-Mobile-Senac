using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class BuscaCEP
    {

        public async Task<Endereco> Buscar(string cep)
        {
            var correio = new HttpClient();
            var consulta = correio.GetAsync(String.Format("http://viacep.com.br/ws/{0}/json/", cep));
            var resultado = await consulta.Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Endereco>(resultado);
        }

    }
}
