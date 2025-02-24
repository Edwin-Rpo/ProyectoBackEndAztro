using System.ComponentModel.DataAnnotations;

public class CreateUserRequest
{
    [Required]
    [StringLength(20)]
    public string? Name { get; set; }

    [Required]
    [MinLength(8)]
    public string? Email { get; set; }
    
    [Range(18, 100, ErrorMessage ="Solo se permite usuarios mayores de 18 años")]
    public int Age { get; set; }
}