using System.Collections.Generic;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts.Core
{
    public interface IPatientProvider
    {
        void Create(Patient patient);

        IEnumerable<Patient> GetAll();

        Patient GetById(int id);

        IEnumerable<Patient> GetByDepartment(int departmentId);

        IEnumerable<Patient> GetByWard(int wardId);

        void Delete(int id);
    }
}
