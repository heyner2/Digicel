using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigicelApps.Models.DTOs
{
    public class CategoryCreationDto
    {
        [Required(ErrorMessage ="Este campo mandatorio")]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}
