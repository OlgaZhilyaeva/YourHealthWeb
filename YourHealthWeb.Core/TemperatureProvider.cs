using System;
using System.Collections.Generic;
using System.Linq;
using YourHealthWeb.Contracts;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;

namespace YourHealthWeb.Core
{
    public class TemperatureProvider:ITemperatureProvider
    {
        private readonly IRepository<Temperature> _temperatureRepository;

        public TemperatureProvider(IRepository<Temperature> TemperatureRepository)
        {
            _temperatureRepository = TemperatureRepository;
        }

        public void Create(Temperature temperature)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Temperature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Temperature> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Temperature> GetAllByPatientId(int id)
        {
            var temperaturesAll = _temperatureRepository.GetAll();
            var temperatures = temperaturesAll.Where(x => x.Patient.PatientId == id);
            return temperatures;
        }

        public IEnumerable<Temperature> GetAllByDoctorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
