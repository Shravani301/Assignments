using AutoMapper;
using LazyEagerLoadingDemo.DTOs;
using LazyEagerLoadingDemo.Models;
using LazyEagerLoadingDemo.Repositories;

namespace LazyEagerLoadingDemo.Services
{
    public class StudentService:IService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public StudentService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<StudentDto> GetStudentsByEager()
        {
            var students = _repository.GetStudentsEager();
            var studentDtos = _mapper.Map<List<StudentDto>>(students); // Mapping using AutoMapper
            return studentDtos;
        }

        public List<StudentDto> GetStudentsByLazy()
        {
            var students =_repository.GetStudentsLazy();
            var studentDtos = _mapper.Map<List<StudentDto>>(students); // Mapping using AutoMapper
            return studentDtos;
        }
    }
}
