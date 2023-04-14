using Microsoft.Extensions.Configuration;

namespace SCRework
{
    internal class Config
    {
        public Config Instance { get; private set; }
        public int Trials { get; set; }
        public int Years { get; set; }
        public double DailyCrates { get; set; }
        public bool Tyl { get; set; }
        public int AnniversaryContainers { get; set; }
        public int MonthlyContainers { get; set; }
        public int BirthdayContainers { get; set; }
        public string Format { get; set; }
        private static bool _init = false;

        public Config()
        {
            if(Instance == null && !_init)
            {
                _init = true;
                Instance = new ConfigurationBuilder()
                                    .AddJsonFile("appsettings.json")
                                    .Build()
                                    .Get<Config>();
            }   
        }
    }
}
