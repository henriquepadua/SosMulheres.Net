namespace SOSMulheres.Models
{
        public class User
        {
            public int Id { get; set; }
            public string? Senha { get; set; }
            // [Required]
            public string? NomeCompleto { get; set; }
            public string? Email { get; set; }

        }
}
