//Create a model class named User.cs and add the following code to it.
using System.ComponentModel.DataAnnotations;

namespace AztroWebApplication.Models
{
    public class User
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        [StringLength(50)]
        public string Name{ get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email{ get; set; } = string.Empty;
        [Required]
        [Range(18, 100, ErrorMessage ="Solo se permiten usuarios mayores de 18 años.")]
        public int Age{ get; set; }
        public User()
        {
        }
    }
}