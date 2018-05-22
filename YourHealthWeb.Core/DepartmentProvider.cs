using System;
using System.Collections.Generic;
using System.Text;
using YourHealthWeb.Contracts;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;
using YourHealthWeb.Models.enums;

namespace YourHealthWeb.Core
{
    public class DepartmentProvider:IDepartmentProvider
    {
        private IRepository<Department> _departmentRepository;

        public DepartmentProvider(IRepository<Department> DepartmentRepository)
        {
            _departmentRepository = DepartmentRepository;
        }

        public void Create(Department temperature)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public IEnumerable<EnumClass> GetAllEnum()
        {
            List<EnumClass> departmentsList = new List<EnumClass>();
            //var Departments =_sensorRepository.GetAll();
            //foreach (var dep in Departments)
            //{
            //    departmentsList.Add(new EnumClass()
            //    {
            //        Text = dep.Name,
            //        Value = dep.Name
            //    });
            //}

            foreach (Departments sens in Enum.GetValues(typeof(Departments)))
            {
                departmentsList.Add(new EnumClass()
                {
                    Text = sens.ToString(),
                    Value = sens.ToString()
                });
            }

            return departmentsList;
        }
        public enum Departments
        {
            Department1,
            Department2,
            Department3,
            Department4,
            Department5
        }
    }
}
