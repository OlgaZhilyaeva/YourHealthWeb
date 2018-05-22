using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface IHospitalProvider
    {
        void Create(Hospital temperature);

        void Delete(int id);

        Hospital GetById(int id);

        IEnumerable<Hospital> GetAll();
    }
}
