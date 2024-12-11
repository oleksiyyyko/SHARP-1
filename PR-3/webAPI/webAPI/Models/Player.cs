using System.ComponentModel.DataAnnotations;

namespace webAPI.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
