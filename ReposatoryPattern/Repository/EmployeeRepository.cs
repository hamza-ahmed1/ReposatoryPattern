using ReposatoryPattern.Models;

namespace ReposatoryPattern.Repository
{
    public class EmployeeRepository : IEmployee
    {
        public List<Employee> GetAllEmployees()
        {
            return Datasource();
        }

        public Employee? GetEmployeeById(int id)
        {
            //var emp = Datasource();
            //foreach (var item in emp)
            //{
            //    if (item.Id == id)
            //    {
            //        return item;
            //    }
            //}
            //return null;

            return Datasource().Where(x=>x.Id == id).FirstOrDefault();
        }

        private List<Employee> Datasource()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=1,Name="Hamza",Age=20,Salary=200000},
                new Employee{Id=2,Name="Daniyal",Age=30,Salary=400000},
                new Employee{Id=3,Name="ali",Age=40,Salary=500000},
                new Employee{Id=4,Name="ahmed",Age=50,Salary=600000},
            };
            return employees;
        }
    }
}
