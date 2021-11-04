using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class DaysModel
    {
        [Display(Name = "Dzień urodzenia")]
        public int Day { get; set; }
        [Display(Name = "Miesiąc urodzenia")]
        public int Month { get; set; }
        [Display(Name = "Rok urodzenia")]
        public int Year { get; set; }
    }
}
