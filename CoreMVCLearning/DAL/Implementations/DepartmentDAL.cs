using CoreMVCLearning.DAL.Contracts;
using CoreMVCLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCLearning.DAL.Implementations
{
    public class DepartmentDAL : IDepartmentDAL
    {
        private readonly CompanyContext _context;

        public DepartmentDAL(CompanyContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.Find(id);
        }

        public bool Save(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
