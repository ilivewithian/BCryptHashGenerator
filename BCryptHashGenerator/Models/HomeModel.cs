using System.ComponentModel.DataAnnotations;

namespace BCryptHashGenerator.Models
{
    public class HomeModel
    {
        [Display(Name = "Plain Text")]
        public string PlainText { get; set; }

        [Display(Name = "BCrypt Hash")]
        public string BCryptHash { get; set; }
    }
}