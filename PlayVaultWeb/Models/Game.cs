using System.ComponentModel.DataAnnotations;
using PlayVaultWeb.Enums;
namespace PlayVaultWeb.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Producer { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public TypeOfGenre Genre { get; set; }
        public TypeOfOS OS { get; set; }
        public TypeOfAudience Audience { get; set; }
        public string ControllerSupport { get; set; }
        public TypeOfRating Rating { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public int Sales { get; set; }
    }
}
