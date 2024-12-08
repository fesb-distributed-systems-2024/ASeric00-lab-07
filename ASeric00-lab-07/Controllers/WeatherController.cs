using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASeric00_lab_07.Repositories;

namespace ASeric00_lab_07.Controllers
{
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private WeatherRepository _weatherRepository;

        public WeatherController(WeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        // GET
        [HttpGet("all")]
        public IEnumerable<WeatherStation> GetAllStations()
        {
            return _weatherRepository.WeatherStations;
        }

        //POST
        [HttpPut("new")]
        public IEnumerable<WeatherStation> AddNewStation([FromBody] WeatherStation newStation)
        {
            _weatherRepository.WeatherStations.Add(newStation);
            return _weatherRepository.WeatherStations;
        }

        //DELETE
        [HttpDelete("delete/{id}")]
        public IEnumerable<WeatherStation> DeleteAStation([FromRoute] long id)
        {
            _weatherRepository.WeatherStations = _weatherRepository.WeatherStations.Where(x => x.Id != id).ToList();
            return _weatherRepository.WeatherStations;
        }

        //UPDATE
        [HttpPost("update/{id}")]
        public IEnumerable<WeatherStation> UpdateAStation([FromRoute] long id, [FromBody] WeatherStation newInfo)
        {
            var oldInfo = _weatherRepository.WeatherStations.FirstOrDefault(x => x.Id == id);

            if (oldInfo == null)
            {
                return _weatherRepository.WeatherStations;
            }
            else
            {
                oldInfo.StationName = newInfo.StationName;
                oldInfo.Temperature = newInfo.Temperature;
                oldInfo.Pressure = newInfo.Pressure;
                oldInfo.WindSpeed = newInfo.WindSpeed;
                oldInfo.WindDirection = newInfo.WindDirection;

                return _weatherRepository.WeatherStations;
            }
        }
    }
}
