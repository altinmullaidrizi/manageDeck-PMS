using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manage_Deck___PMS.Models
{
    public enum PriorityType
    {
        Low,
        Medium,
        High,
    }
    public class Checklist
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter name"), MinLength(5), MaxLength(60)]
        public string Title { get; set; }

        [EnumDataType(typeof(PriorityType))]
        public PriorityType? Priority { get; set; }

        public bool Completed { get; set; }

        public Guid UserId { get; set; }

    }
}
