using EF04.Data;
using EF04.Data.Models;
using EF04.DataSeed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EF04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (CompanyDBContext companyDBContext = new CompanyDBContext())
            {
                CompanyDBContextSeed.Seed(companyDBContext);
                #region EF04 
                //#region Add
                ////Employee emp01 = new Employee() { Name = "Nada", Age = 26, Salary = 9_000, Email = "Nada@gmail.com" };
                ////Employee emp02 = new Employee() {Id=1,  Name = "Rana", Age = 26, Salary = 8_000, Email = "Rana@gmail.com" };

                ////Console.WriteLine(companyDBContext.Entry(emp01).State);//Detached
                ////Console.WriteLine(companyDBContext.Entry(emp02).State);//Detached

                ////companyDBContext.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.TrackAll;//Default Behaviour

                ////Employee emp04 = new Employee() { Id = 3, Name = "Omar", Age = 26, Salary = 8_000, Email = "Rana@gmail.com" };

                ////companyDBContext.Set<Employee>().Add(emp04); // .toTable instead of dbSet
                //// companyDBContext.Employees.Add(emp01); //as Local Sequence 
                //// companyDBContext.Add(emp02);
                ////companyDBContext.Entry(emp01).State=EntityState.Added;

                //#endregion
                //#region Get And Update
                ////var emp = (from e in companyDBContext.Employees
                ////           where e.Id == 3
                ////           select e).FirstOrDefault();


                ////if(emp is not null)
                ////{
                ////    Console.WriteLine(companyDBContext.Entry(emp).State);
                ////    Console.WriteLine(emp.Name);
                ////    Console.WriteLine(emp.Email);
                ////    emp.Salary = 10_000;
                ////    Console.WriteLine(companyDBContext.Entry(emp).State);

                ////}
                //#endregion
                //#region Get And Remove

                ////var emp = (from e in companyDBContext.Employees
                ////           where e.Id == 3
                ////           select e).FirstOrDefault();


                ////if (emp is not null)
                ////{
                ////    Console.WriteLine(companyDBContext.Entry(emp).State);
                ////    Console.WriteLine(emp.Name);

                ////    //companyDBContext.Set<Employee>().Remove(emp); // .toTable instead of dbSet
                ////    /*companyDBContext.Employees.Remove(emp); *///as Local Sequence 
                ////    companyDBContext.Remove(emp);
                ////    //companyDBContext.Entry(emp).State = EntityState.Deleted;
                ////    //
                ////    Console.WriteLine(companyDBContext.Entry(emp).State);

                ////}
                //#endregion
                //#region Explicit Loading
                //#region Example01

                ////var employee = (from e in companyDBContext.Employees
                ////                where e.Id == 3
                ////                select e).FirstOrDefault();


                ////companyDBContext.Entry(employee).Reference(nameof(employee.Department)).Load();



                ////if (employee is not null)
                ////{
                ////    Console.WriteLine($"Employee Name ={employee.Name} : Department = {employee.Department.Name} ");
                ////}
                //#endregion
                //#region Example02
                ////var department = (from d in companyDBContext.Departments
                ////                where d.DepartmentId == 1
                ////                select d).FirstOrDefault();



                ////companyDBContext.Entry(department).Collection(nameof(department.Employees)).Load();


                ////if (department is not null)
                ////{
                ////    Console.WriteLine($"Department ID ={department.DepartmentId} , Department Name ={department.Name}");
                ////    foreach (var e in department.Employees)
                ////    {
                ////        Console.WriteLine($"=============Employee Name: {e.Name}  ================");
                ////    }

                ////} 
                //#endregion

                //#endregion
                //#region Eager Loading
                //#region Example01

                ////var employee = (from e in companyDBContext.Employees
                ////                .Include("Department")
                ////                where e.Id == 3
                ////                select e).FirstOrDefault();


                ////companyDBContext.Entry(employee).Reference(nameof(employee.Department)).Load();



                ////if (employee is not null)
                ////{
                ////    Console.WriteLine($"Employee Name ={employee.Name} : Department = {employee.Department.Name} ");
                ////}
                //#endregion
                //#region Example02
                ////var department = (from d in companyDBContext.Departments
                ////                   .Include(d=>d.Employees)
                ////                  where d.DepartmentId == 1
                ////                  select d).FirstOrDefault();



                ////companyDBContext.Entry(department).Collection(nameof(department.Employees)).Load();


                ////if (department is not null)
                ////{
                ////    Console.WriteLine($"Department ID ={department.DepartmentId} , Department Name ={department.Name}");
                ////    foreach (var e in department.Employees)
                ////    {
                ////        Console.WriteLine($"=============Employee Name: {e.Name}  ================");
                ////    }

                ////}
                //#endregion


                //#endregion
                //#region Lazy Loading

                //#region Example01
                ////var employee = (from e in companyDBContext.Employees
                ////                where e.Id == 3
                ////                select e).FirstOrDefault();


                ////if (employee is not null)
                ////{
                ////    Console.WriteLine($"Employee Name ={employee.Name} : Department = {employee.Department.Name} ");
                ////}
                //#endregion


                //#endregion
                //#region Join
                ////var res = from d in companyDBContext.Departments
                ////          join e in companyDBContext.Employees
                ////          on d.DepartmentId equals e.DepartmentId
                ////          select new
                ////          {
                ////              DepartmentID=d.DepartmentId,
                ////              DepartmentName = d.Name,
                ////              EmployeeID = e.Id,
                ////              EmployeeName = e.Name
                ////          };
                ////foreach (var item in res) { Console.WriteLine(item); }

                ////res =  companyDBContext.Departments.Join(companyDBContext.Employees,d=>d.DepartmentId, e => e.DepartmentId,
                ////    (d, e) => new    
                ////    {
                ////        DepartmentID = d.DepartmentId,
                ////        DepartmentName = d.Name,
                ////        EmployeeID = e.Id,
                ////        EmployeeName = e.Name

                ////    });
                ////Console.WriteLine("------------------------------------------------------------");
                ////var GroupJoinRes = companyDBContext.Departments.GroupJoin(companyDBContext.Employees,
                ////    d => d.DepartmentId, e => e.DepartmentId,
                ////    (department, employee) => new
                ////    {
                ////        department,
                ////        employee
                ////    });
                ////foreach (var item in GroupJoinRes)
                ////{
                ////    Console.WriteLine($"DepartmentID : {item.department.DepartmentId} ,{item.department.Name}");
                ////    Console.WriteLine("--------------------------------------------------------------------");
                ////    foreach (var employee in item.employee)
                ////    {
                ////        {
                ////            Console.WriteLine($"Employee Name : {employee.Name}");
                ////        }
                ////    }
                ////    Console.WriteLine("--------------------------------------------------------------------");

                ////}



                #endregion
                #region EF05

                #region Left Outer Join
                //var GroupJoinRes = companyDBContext.Departments.GroupJoin(companyDBContext.Employees,
                //    d => d.DepartmentId, e => e.DepartmentId,
                //    (department, employee) => new
                //    {
                //        department,
                //        employee = employee.DefaultIfEmpty()
                //    }).SelectMany(gCol => gCol.employee, (gCol , emp)=> new
                //    {
                //        emp,
                //        gCol.department 
                //    });


                //foreach (var item in GroupJoinRes)
                //{
                //    Console.WriteLine($" {item.department.Name} , Employee Name : {item.emp?.Name?? "NULL"}");
                //} 
                #endregion
                #region Cross Join

                //    var crossJoin = from d in companyDBContext.Departments
                //                    from e in companyDBContext.Employees
                //                    select new
                //                    {
                //                        e, d
                //                    };
                //foreach (var item in crossJoin)
                //{
                //    Console.WriteLine($"{item.e.Name} , {item.d.Name}");
                //}


                #endregion
                #region Calling EmpDeptView
                //var ViewRes = companyDBContext.EmpDepView;

                //foreach (var item in ViewRes) 
                //{
                //    Console.WriteLine($"{item.DepartmentName} , {item.EmployeeName}");
                //} 
                #endregion


                #endregion



            }
        }
    }
}

