using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface ITemperatureProvider
    {
        void Create(Temperature temperature);

        void Delete(int id);

        Temperature GetById(int id);

        IEnumerable<Temperature> GetAll();

        IEnumerable<Temperature> GetAllByPatientId(int id);

        IEnumerable<Temperature> GetAllByDoctorId(int id);
    }
}
