using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoalSystem.Models
{
    /// <summary>
    /// Car
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Int Id of the car
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Car Make
        /// </summary>
        [Display(Name = "Marca")]
        public string Make { get; set; }

        /// <summary>
        /// Car Model
        /// </summary>
        [Display(Name = "Modelo")]
        public string Model { get; set; }

        /// <summary>
        /// Car Registration
        /// </summary>
        [Display(Name = "Matrícula")]
        [Required(ErrorMessage ="Campo obligatorio")]
        public string CarRegistration { get; set; }

        /// <summary>
        /// Car Review
        /// </summary>
        [Display(Name = "Próxima Revisión")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime CarReview { get; set; }

        /// <summary>
        /// Car Kilometers
        /// </summary>
        [Display(Name = "Kilómetros")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public decimal Kilometers { get; set; }

        /// <summary>
        /// Car Status
        /// </summary>
        //Status = 1 available ; 2 on route
        public int Status { get; set; }
    }
}