using System.ComponentModel.DataAnnotations;

namespace PasswordHashing.DTOs
{
    public class EmployeeDto
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "The name field required!")]
        [StringLength(25, ErrorMessage = "Name should be less than or equal to the 25 characters.")]
        public string Name { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
