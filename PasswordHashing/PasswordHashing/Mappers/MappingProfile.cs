using AutoMapper;
using PasswordHashing.DTOs;
using PasswordHashing.Models;

namespace PasswordHashing.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeDto, Employee>()
                .ForMember(dest => dest.PasswordHash,
                           opt => opt.MapFrom(src => BCrypt.Net.BCrypt.HashPassword(src.Password)));
            
        }

    }
}
