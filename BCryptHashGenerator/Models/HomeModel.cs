using System.ComponentModel.DataAnnotations;

namespace BCryptHashGenerator.Models
{
    public class HomeModel
    {
        [Required]
        public string PlainText { get; set; }
        public string BCryptHash { get; set; }
    }
}