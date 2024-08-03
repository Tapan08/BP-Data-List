using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TPAssignment_1.Models
{
    public class BP
    {
        public int Id { get; set; }



        [Required(ErrorMessage = "Please enter your systolic Value.")]
        [Range(20, 400, ErrorMessage = "Systolic Value must be between 20 and 400.")]

        public int systolic { get; set; }

        public enum BPReadingCategory
        {
            Normal,
            Elevated,
            HypertensionStage1,
            HypertensionStage2,
            HypertensiveCrisis
        }


        [Required(ErrorMessage = "Please enter your diastolic Value.")]
        [Range(10, 300, ErrorMessage = "Diastolic Value must be between 10 and 300.")]
        public int diastolicValues { get; set; }

        [Required(ErrorMessage = "Please enter Position.")]
        public string PositionId { get; set; } = string.Empty;


        [ValidateNever]
        public Position Position { get; set; } = null!;

        public DateTime DateCreated { get; set; }
    }
}
