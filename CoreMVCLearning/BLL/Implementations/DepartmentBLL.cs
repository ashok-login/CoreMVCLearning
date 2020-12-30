using CoreMVCLearning.BLL.Contracts;
using CoreMVCLearning.DAL.Contracts;
using CoreMVCLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCLearning.BLL.Implementations
{
    public class DepartmentBLL : IDepartmentBLL
    {
        private readonly IDepartmentDAL _dal;

        public DepartmentBLL(IDepartmentDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            return _dal.GetAll();
        }

        public Department GetDepartmentById(int id)
        {
            return _dal.GetDepartmentById(id);
        }

        public bool Save(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
