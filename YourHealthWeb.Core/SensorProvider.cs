using System;
using System.Collections.Generic;
using YourHealthWeb.Contracts;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;
using YourHealthWeb.Models.enums;

namespace YourHealthWeb.Core
{
    public class SensorProvider:ISensorProvider
    {
        private IRepository<Sensor> _sensorRepository;

        public SensorProvider(IRepository<Sensor> SensorRepository)
        {
            _sensorRepository = SensorRepository;
        }

        public void Create(Sensor temperature)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Sensor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Sensor> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EnumClass> GetAllEnum()
        {
            List<EnumClass> sensorsList = new List<EnumClass>();
            //var sensors =_sensorRepository.GetAll();
            //foreach (var sensor in sensors)
            //{
            //    sensorsList.Add(new EnumClass()
            //    {
            //        Text = sensor.Name,
            //        Value = sensor.Name
            //    });
            //}

            foreach (sensors sens in Enum.GetValues(typeof(sensors)))
            {
                sensorsList.Add(new EnumClass()
                {
                    Text = sens.ToString(),
                    Value = sens.ToString()
                });
            }

            return sensorsList;
        }
        public enum sensors
        {
            Sensor1,
            Sensor2,
            Sensor3,
            Sensor4,
            Sensor5
        }
    }
}
