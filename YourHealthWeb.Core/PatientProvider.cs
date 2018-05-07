using System.Collections.Generic;
using YourHealthWeb.Contracts;
using YourHealthWeb.Models;

namespace YourHealthWeb.Core
{
    class PatientProvider
    {
        private readonly IPatientRepository _patientRepository;

        public PatientProvider(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }
        //TODO all other methods
    }
}
