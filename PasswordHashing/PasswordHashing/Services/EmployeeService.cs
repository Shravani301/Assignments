using AutoMapper;
using PasswordHashing.DTOs;
using PasswordHashing.Exceptions;
using PasswordHashing.Models;
using PasswordHashing.Repositories;

namespace PasswordHashing.Services
{
    public class EmployeeService:IService
    {
        private readonly IRepository<Employee> _repository;
        private readonly IMapper _mapper;
        public EmployeeService(IRepository<Employee> reposiory,IMapper mapper)
        {
            _repository = reposiory;
            _mapper = mapper;
        }
        public Guid Add(EmployeeDto employeeDto)
        {
            var employee=_mapper.Map<Employee>(employeeDto);
            _repository.Add(employee);
            return employee.Id;
        }
        public List<Employee> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        
        public string Login(LoginDto loginDto)
        {
            var employee = _repository.GetAll().FirstOrDefault(e => e.Name == loginDto.Name);

            if (employee == null)
                throw new UserNotFoundException("The username does not exist.");

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(loginDto.Password, employee.PasswordHash);
            return isPasswordValid ? "Login successful!" : throw new InvalidPasswordException("The password provided is incorrect.");

        }
    }
}
