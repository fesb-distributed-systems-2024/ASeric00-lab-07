using System;
namespace ASeric00_lab_07
{
    public class WeatherStation
    {
        public WeatherStation(string stationName, int temperature, int pressure, int windSpeed, string windDirection)
        {
            Id = Random.Shared.NextInt64();
            StationName = stationName;
            Temperature = temperature;
            Pressure = pressure;
            WindSpeed = windSpeed;
            WindDirection = windDirection;
        }

        public long Id { get; set; }
        public string StationName { get; set; }
        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public int WindSpeed { get; set; }
        public string WindDirection { get; set; }
    }
}
