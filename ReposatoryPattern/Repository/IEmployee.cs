using ReposatoryPattern.Models;

namespace ReposatoryPattern.Repository
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);


    }
}
