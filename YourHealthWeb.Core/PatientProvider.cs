using System.Collections.Generic;
using YourHealthWeb.Contracts;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;

namespace YourHealthWeb.Core
{
    public class PatientProvider:IPatientProvider
    {
        private readonly IPatientRepository _patientRepository;

        public PatientProvider(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void Create(Patient entity)
        {
            _patientRepository.Create(entity);
        }

        public IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }

        public Patient GetById(int id)
        {
            return _patientRepository.GetById(id);
        }

        public IEnumerable<Patient> GetByDepartment(int departmentId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Patient> GetByWard(int wardId)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            _patientRepository.Delete(id);
        }

    }
}
