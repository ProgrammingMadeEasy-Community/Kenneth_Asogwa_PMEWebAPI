using PMEWebAPI.Data;
using PMEWebAPI.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMEWebAPI.Models
{
    public class Employee: IEntity
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Fullname is required.")]
        [RegularExpression("^[A-Za-z ]*$", ErrorMessage = "Fullname should contain only characters.")]
        [StringLength(50, ErrorMessage = "Name should not exceed 50 characters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email should not contain only characters.")]
        [StringLength(50, ErrorMessage = "Email should not exceed 50 variable characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Invalid phone number.")]
        [StringLength(11, ErrorMessage = "Phone number should have a maximum length of 11 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(50, ErrorMessage = "Address should not exceed 50 variable characters")]
        public string? Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateEmployed { get; set; } 
    }
}
