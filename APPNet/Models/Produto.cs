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
        [Required]
        public string? Imagem  { get; set; }
    }
}