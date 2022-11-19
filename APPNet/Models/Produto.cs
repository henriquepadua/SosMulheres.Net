using System.ComponentModel.DataAnnotations;

namespace APPNet.Models
{
    public class Produto
    {
        public int Id  { get; set; }
        [Required]
        public string? Nome  { get; set;} 

        [Required]
        public string? Descricao  { get; set; }
        [Required]
        public decimal Valor  { get; set; }

        public string? Imagem  { get; set; }

        public IFormFile? File  { get; set; }
    }
}