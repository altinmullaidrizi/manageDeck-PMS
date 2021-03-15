using System;
using System.ComponentModel.DataAnnotations;

namespace Manage_Deck___PMS.Models
{
    public class Project
    {
        public Guid ProjectId { get; set; }

        [Required(ErrorMessage = "Please enter projects name"), MinLength(5), MaxLength(60), Display(Name = "Project")]
        public string ProjectName { get; set; }

        [Display(Name = "Description")]
        public string ProjectDescription { get; set; }

        [Display(Name = "Created")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedTime { get; set; }

    }
}
