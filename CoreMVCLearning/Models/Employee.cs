using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCLearning.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Salary { get; set; }

        public int DeptNo { get; set; }
    }
}
