using System.Collections.Generic;
using System.Linq;
using YourHealthWeb.Contracts;
using YourHealthWeb.Models;

namespace YourHealthWeb.DAL
{
    public class PatientRepository : AbstractRepository<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalContext db) : base(db)
        {
        }


        public IEnumerable<Patient> GetByWard(int wardId)
        {
            var patients = GetAll();
            return patients.Where(x => x.Ward.WardId == wardId);
        }

        public IEnumerable<Patient> GetByDepartment(int departmentId)
        {
            var patients = GetAll();
            return patients.Where(x => x.Ward.Department.DepartmentId == departmentId);
        }

    }
}
