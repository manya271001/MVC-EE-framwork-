using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class User
    {
        [Required(ErrorMessage ="Name is required")]
        [StringLength(50,ErrorMessage ="Name cannot exceed 50 character")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress( ErrorMessage = "Email is required")]

        public string Email { get; set; }
        [Range (18,100,ErrorMessage ="Age must be btw 18-100")]

       public int age { get; set; }

    }
}
