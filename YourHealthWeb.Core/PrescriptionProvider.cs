using System;
using System.Collections.Generic;
using System.Linq;
using YourHealthWeb.Contracts;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;

namespace YourHealthWeb.Core
{
    public class PrescriptionProvider:IPrescriptionProvider
    {
        private IRepository<Prescription> _prescriprionRepository;

        public PrescriptionProvider(IRepository<Prescription> PrescriptionRepository)
        {
            _prescriprionRepository = PrescriptionRepository;
        }

        public void Create(Prescription temperature)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Prescription GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prescription> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prescription> GetByPatientId(int id)
        {
            var prescriptions = _prescriprionRepository.GetAll();
            return prescriptions.Where(x => x.Patient.PatientId == id);
        }
    }
}
