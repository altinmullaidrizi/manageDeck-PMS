using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Deck___PMS.Models
{

    public enum LabelType
    {
        FrontEnd,
        Backend,
        Design,
        SEO,
        Management,
        QA
    }

    public class Task
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter name"), MinLength(5), MaxLength(60)]
        public string TaskName { get; set; }

        public string TaskDescription { get; set; }

        public LabelType? Label { get; set; }

        [Display(Name = "Due Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DueDate { get; set; }

        public bool Completed { get; set; }

        public Guid Assignee { get; set; }

        public Guid Reporter { get; set; }

        [Required(ErrorMessage = "Task need to be assigned to a Project")]
        public Guid ProjectId { get; set; }
    }
}