using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface IPrescriptionProvider
    {
        void Create(Prescription temperature);

        void Delete(int id);

        Prescription GetById(int id);

        IEnumerable<Prescription> GetAll();

        IEnumerable<Prescription> GetByPatientId(int id);
    }
}
