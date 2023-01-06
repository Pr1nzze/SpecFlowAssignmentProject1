using Microsoft.Extensions.Configuration;

namespace SpecFlowAssignmentProject1.Configurations
{
    public static class readfromJson
    {
        public static IConfigurationRoot getconfig
        {
            get
            {
                var config = new ConfigurationBuilder();
                config.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("setting.json");
                return config.Build();
            }
        }

        public static IConfigurationRoot GetConfig() => getconfig;

        public static string Getdemoqaurl() => new (GetConfig().GetSection("Enviroment").GetValue<string>("demoqaUrl"));
    }
}
