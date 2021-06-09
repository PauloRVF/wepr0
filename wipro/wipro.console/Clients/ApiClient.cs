using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using wipro.core.DTO;

namespace wipro.console.Clients
{
    public class ApiClient
    {
        private readonly HttpClient _client;

        public ApiClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:5001/");
        }

        public async Task<ProcessoDTO> GetProcessosAsync()
        {
            try
            {
                var resposta = await _client.GetAsync("GetItemFila");
                if (resposta.IsSuccessStatusCode)
                {

                    var jsonobjFilaItem = (JObject)JsonConvert.DeserializeObject(await resposta.Content.ReadAsStringAsync());

                    return jsonobjFilaItem.ToObject<ProcessoDTO>();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new KeyNotFoundException(ex.Message);
            }            

        }
    }
}
