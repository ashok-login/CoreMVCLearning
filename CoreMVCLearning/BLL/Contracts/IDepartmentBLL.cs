using CoreMVCLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCLearning.BLL.Contracts
{
    public interface IDepartmentBLL
    {
        bool Save(Department department);
        bool Delete(int id);
        List<Department> GetAll();
        Department GetDepartmentById(int id);
    }
}
