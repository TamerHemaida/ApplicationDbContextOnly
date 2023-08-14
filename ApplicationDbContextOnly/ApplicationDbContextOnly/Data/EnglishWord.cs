using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDbContextOnly.Models
{
    public class EnglishWord
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(255)]
        public string Word { get; set; }

        [MaxLength(255)]
        public string Meaning { get; set; }


        [MaxLength(255)]
        public string DifficultyLevel { get; set; }
        public bool State { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}