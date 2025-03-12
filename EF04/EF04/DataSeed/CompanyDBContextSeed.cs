using EF04.Data;
using EF04.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EF04.DataSeed
{
    internal static class CompanyDBContextSeed
    {
        public static void Seed(CompanyDBContext companyDBContext)
        {

            if (!companyDBContext.Departments.Any()) {
                var deptData = File.ReadAllText("C:\\Users\\ADEL\\source\\repos\\Assignment\\EF04\\EF04\\DataSeed\\departments.json");
                var dept = JsonSerializer.Deserialize<List<Department>>(deptData);

                if (dept?.Count > 0) {
                    foreach (var department in dept) {
                        companyDBContext.Departments.Add(department);
                    }
                    companyDBContext.SaveChanges();
                }
            }

            if (!companyDBContext.Employees.Any())
            {
                var empData = File.ReadAllText("C:\\Users\\ADEL\\source\\repos\\Assignment\\EF04\\EF04\\DataSeed\\employees.json");
                var emps = JsonSerializer.Deserialize<List<Employee>>(empData);

                if (emps?.Count > 0)
                {
                    foreach (var emp in emps)
                    {
                        companyDBContext.Employees.Add(emp);
                    }
                    companyDBContext.SaveChanges();
                }
            }
        }


    }
}
