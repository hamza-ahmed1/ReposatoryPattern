using Microsoft.AspNetCore.Mvc;
using ReposatoryPattern.Models;
using ReposatoryPattern.Repository;
using System.Diagnostics;

namespace ReposatoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeRepository _employeeRepository = null;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _employeeRepository= new EmployeeRepository();
        }

        public List<Employee> GetallEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }
        public Employee? GetEmployee(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}