using System;
using System.Collections.Generic;
using System.Text;
using YourHealthWeb.Models;

namespace YourHealthWeb.Contracts
{
    public interface IPatientRepository:IRepository<Patient>
    {
        IEnumerable<Patient> GetByWard(int wardId);

        IEnumerable<Patient> GetByDepartment(int departmentId);
    }
}
