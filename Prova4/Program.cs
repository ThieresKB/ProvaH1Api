// npx json-server
using Newtonsoft.Json;
public class Program
{
    public static async Task Main(string[] args)
    {
        string url = "https://files.uniaraxa.edu.br/assets/Disciplina/24165/questao4_136-638236599111246812.json";

        using (var client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var responseBory = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<List<Api>>(responseBory);
            }
        }


    }

    public class Api
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public int? CopaJaRealizadas { get; set; }
        public string? Capital { get; set; }
    }
}
