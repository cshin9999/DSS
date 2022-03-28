using System.Net.Http.Json;

namespace DSS.Client.Services.ConfigurationService
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly HttpClient _httpClient;
        public ConfigurationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Configuration> Configurations { get; set; } = new List<Configuration>();
        public Configuration Configuration { get; set; } = new Configuration();
        public async Task GetConfigurations()
        {
            var results = await _httpClient.GetFromJsonAsync<List<Configuration>>("api/configurations");
            if (results != null)
            {
                Configurations = results;
            }
        }

        public async Task GetConfigurationById(int id)
        {
            var results = await _httpClient.GetFromJsonAsync<Configuration>("api/configurations/" + id);
            if (results != null)
            {
                Configuration = results;
            }
            else
            {
                Configuration = new Configuration();
            }
        }

        Task IConfigurationService.GetConfigurationByName()
        {
            throw new NotImplementedException();
        }

    }
}
