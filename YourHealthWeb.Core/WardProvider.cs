using System;
using System.Collections.Generic;
using System.Linq;
using YourHealthWeb.Contracts;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;
using YourHealthWeb.Models.enums;

namespace YourHealthWeb.Core
{
    public class WardProvider:IWardProvider
    {
        private IRepository<Ward> _wardRepository;

        public WardProvider(IRepository<Ward> WardRepository)
        {
            _wardRepository = WardRepository;
        }

        public void Create(Ward temperature)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Ward GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ward> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ward> GetAllByDepartmentId(int id)
        {
            return _wardRepository.GetAll().Where(x => x.Department.DepartmentId == id);
        }

        public IEnumerable<EnumClass> GetAllEnum()
        {
            List<EnumClass> wardsList = new List<EnumClass>();
            //var wards = _wardRepository.GetAll();
            //foreach (var ward in wards)
            //{
            //    wardsList.Add(new EnumClass()
            //    {
            //        Text = ward.Name,
            //        Value = ward.Name
            //    });
            //}

            foreach (wards wards in Enum.GetValues(typeof(wards)))
            {
                wardsList.Add(new EnumClass()
                {
                    Text = wards.ToString(),
                    Value = wards.ToString()
                });
            }

            return wardsList;
        }
        public enum wards
        {
            Ward1,
            Ward2,
            Ward3,
            Ward4,
            Ward5
        }
    }
}
