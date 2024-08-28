using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System.Globalization;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string result = GetDepartmentsWithMoreThan5Employees(context);
            Console.WriteLine(result);
        }

        //03. Employees full information
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var employees = context.Employees.Select(x => new
            {
                x.EmployeeId,
                x.FirstName,
                x.MiddleName,
                x.LastName,
                x.JobTitle,
                x.Salary

            }).OrderBy(x => x.EmployeeId).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");

            return sb.ToString().TrimEnd();
        }
        //4. Employees with salary over 50 000
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context.Employees.Select(e => new
            {
                e.FirstName,
                e.Salary
            })
                .Where(e => e.Salary > 50000)
                .OrderBy(e => e.FirstName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }
        //5. Employees from Research and Development
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees
                 .Where(e => e.Department.Name == "Research and Development")
                 .Select(x => new
                 {
                     x.FirstName,
                     x.LastName,
                     x.Department.Name,
                     x.Salary
                 })
                 .OrderBy(x => x.Salary).ThenByDescending(x => x.FirstName).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Name} - ${employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }
        //6. Adding a New Address and Updating Employee
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address newAddress = new Address() { AddressText = "Vitoshka 15", TownId = 4 };
            context.Addresses.Add(newAddress);

            var nakov = context.Employees.First(x => x.LastName == "Nakov");
            nakov.Address = newAddress;

            context.SaveChangesAsync();

            var addressText = context.Employees.OrderByDescending(x => x.AddressId).Take(10)
                .Select(x => x.Address.AddressText).ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var ad in addressText) sb.AppendLine(ad);

            return sb.ToString().TrimEnd();
        }
        //7. Employees and Projects
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees
                .Take(10)
                .Include(e => e.EmployeesProjects)
                .ThenInclude(ep => ep.Project)
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.Manager,
                    Projects = x.EmployeesProjects.Where(x => x.Project.StartDate.Year >= 2001 && x.Project.StartDate.Year <= 2003)
                    .Select(p => new
                    {
                        p.Project.Name,
                        StartDate = p.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt"),
                        EndDate = p.Project.EndDate.HasValue ? p.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished"
                    }).ToList()
                })
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.Manager.FirstName} {employee.Manager.LastName}");

                foreach (var project in employee.Projects)
                {
                    sb.AppendLine($"--{project.Name} - {project.StartDate} - {project.EndDate}");
                }
            }

            return sb.ToString().TrimEnd();
        }
        //8. Addresses by Town
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Include(e => e.Employees)
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .ThenBy(a => a.AddressText)
                .Select(a => new
                {
                    adressText = a.AddressText,
                    town = a.Town,
                    employeesCount = a.Employees.Count()
                })
                .Take(10)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var address in addresses)
            {
                sb.AppendLine($"{address.adressText}, {address.town.Name} - {address.employeesCount} employees");
            }

            return sb.ToString().TrimEnd();
        }
        //9. Employee 147
        public static string GetEmployee147(SoftUniContext context)
        {

            var content = new StringBuilder();

            var employee = context.Employees.First(e => e.EmployeeId == 147);

            var projects = employee.EmployeesProjects.OrderBy(project => project.Project.Name);

            content.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var project in projects)
            {
                content.AppendLine(project.Project.Name);
            }

            return content.ToString().TrimEnd();
        }
        //10. Departments with More Than 5 Employees
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departmetns = context.Departments
                .Where(x=>x.Employees.Count>5)
                 .Select(d => new
                 {
                     DepartmentName = d.Name,
                     ManagerFirstName = d.Manager.FirstName,
                     ManagerLastName = d.Manager.LastName,
                     Employees=d.Employees
                 })
                 .OrderBy(x=>x.Employees.Count)
                 .ThenBy(x => x.DepartmentName)
                 .ToList();
            
            StringBuilder sb = new StringBuilder();
            foreach (var department in departmetns)
            {
                sb.AppendLine($"{department.DepartmentName} - { department.ManagerFirstName} { department.ManagerLastName}");

                foreach (var employee in department.Employees.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName))
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }
            return sb.ToString().TrimEnd();
        }
        //11. Find Latest 10 Projects
        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects
                .OrderByDescending(x => x.StartDate)
                .Take(10)
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    Name = x.Name,
                    Description = x.Description,
                    StartDate = x.StartDate.ToString("M/d/yyyy h:mm:ss tt")
                })
                .ToList();

            StringBuilder content = new StringBuilder();

            foreach (var project in projects)
            {
                content.AppendLine($"{project.Name}");
                content.AppendLine($"{project.Description}");
                content.AppendLine($"{project.StartDate}");
            }

            return content.ToString().TrimEnd();
        }
        // 12. Increase Salaries
        public static string IncreaseSalaries(SoftUniContext context)
        {
            HashSet<string> departments = new HashSet<string>()
            {
                "Engineering", "Tool Design", "Marketing", "Information Services"
            };

            var employees = context.Employees
                .Where(e => departments.Contains(e.Department.Name))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < employees.Count; i++)
            {
                var employee = employees[i];
                employee.Salary *= 1.12m;
            }
            context.SaveChanges();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }
        //13. Find Employees by First Name Starting with "Sa"
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Job = e.JobTitle,
                    Salary = e.Salary
                })
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.Job} - (${employee.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }
        //14. Delete Project by Id
        public static string DeleteProjectById(SoftUniContext context)
        {
            var project2 = context.Projects.Find(2);
            var employeesProjectsToDelete = context.EmployeesProjects
                .Where(ep => ep.ProjectId == 2)
                .ToArray();

            foreach (var pToDelete in employeesProjectsToDelete)
                context.EmployeesProjects.Remove(pToDelete);

            context.Projects.Remove(project2);
            context.SaveChanges();

            var projects = context.Projects.Take(10).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var project in projects)
            {
                sb.AppendLine($"{project.Name}");
            }
            return sb.ToString().TrimEnd();
        }
        //15. Remove Town
        public static string RemoveTown(SoftUniContext context)
        {
            var townToRemove = context.Towns.FirstOrDefault(t => t.Name == "Seattle");
            var addresses = context.Addresses.Where(a => a.TownId == townToRemove.TownId);

            var count = addresses.Count();

            var employees = context.Employees.Where(e => addresses.Any(a => a.AddressId == e.AddressId));

            foreach (var employee in employees) employee.AddressId = null;
            foreach (var address in addresses) context.Addresses.Remove(address);

            context.Towns.Remove(townToRemove);

            context.SaveChanges();

            return $"{count} addresses in Seattle were deleted";
        }
    }
}