using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Web.Models
{
	public class Patient
	{
        public int Id { get; set; }

        [Display(Name = "Patient Name")]
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "The Name length should be between 4 and 20.", MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

		[Required]
        [Display(Name = "Visit Date")]
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }
    }
}
