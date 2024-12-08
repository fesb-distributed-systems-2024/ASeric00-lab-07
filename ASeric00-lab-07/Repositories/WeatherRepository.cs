using System;
namespace ASeric00_lab_07.Repositories
{
    public class WeatherRepository
    {

        public List<WeatherStation> WeatherStations;
        public WeatherRepository()
        {
            WeatherStations = new List<WeatherStation>();
            WeatherStations.Add(new WeatherStation("Split", 15, 1012, 23, "SZ"));
            WeatherStations.Add(new WeatherStation("Zagreb", 8, 1008, 12, "SZ"));
            WeatherStations.Add(new WeatherStation("Rijeka", 13, 1008, 15, "S"));
        }
    }
}
