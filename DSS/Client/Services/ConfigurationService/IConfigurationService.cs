namespace DSS.Client.Services.ConfigurationService
{
    public interface IConfigurationService
    {
        List<Configuration> Configurations { get; set; }
        Configuration Configuration { get; set; }
        Task GetConfigurations();
        Task GetConfigurationById(int id);
        Task GetConfigurationByName();
    }
}
