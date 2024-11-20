using PasswordHashing.DTOs;
using PasswordHashing.Models;

namespace PasswordHashing.Services
{
    public interface IService
    {
        public Guid Add(EmployeeDto employee);
        public List<Employee> GetAll();
        public string Login(LoginDto login);
    }
}
