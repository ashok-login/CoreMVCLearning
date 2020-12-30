using CoreMVCLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCLearning.DAL.Contracts
{
    public interface IDepartmentDAL
    {
        bool Save(Department department);
        bool Delete(int id);
        List<Department> GetAll();
        Department GetDepartmentById(int id);
    }
}
