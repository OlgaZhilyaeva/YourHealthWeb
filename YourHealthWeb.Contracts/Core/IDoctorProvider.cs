using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface IDoctorProvider
    {
        void Create(Doctor temperature);

        void Delete(int id);

        Doctor GetById(int id);

        IEnumerable<Doctor> GetAll();
    }
}
