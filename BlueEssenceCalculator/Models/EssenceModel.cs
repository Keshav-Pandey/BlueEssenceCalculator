using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlueEssenceCalculator.Models
{
    public class EssenceModel
    {
        [RegularExpression(@"[0-9]+",ErrorMessage = "Must be a valid number")]
        [Required]
        public int IP { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Must be a valid number")]
        [Required]
        public int Rune { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Must be a valid number")]
        [Required]
        public int RunePage { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Must be a valid number")]
        [Required]
        public int Earnings { get; set; }

        [RegularExpression(@"[0-9]+", ErrorMessage = "Must be a valid number")]
        [Required]
        public int Essence { get; set; }

        public double Total { get; set; }

        public int Skins { get; set; }

        public void CalculateTotal() {
            Total = IP + (Rune * 300) + (1500 * (RunePage % 4)) + (Earnings * 100) + (17.8 * Essence);
            Skins = RunePage / 4;
        }
    }
}