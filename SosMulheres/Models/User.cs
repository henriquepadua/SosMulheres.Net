using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace SosMulheres.Models
{
    [MetadataType(typeof(User))]
    public class User
    {
        public int Id { get; set; }
        public string? Senha { get; set; }
        // [Required]
        public string? NomeCompleto { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

    }
}