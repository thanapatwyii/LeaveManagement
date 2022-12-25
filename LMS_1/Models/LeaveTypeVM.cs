using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LMS_1.Models
{

    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]

        public string? Name { get; set; }

        [Display(Name = "Dafault Number Of Days")]

        public int DefaultDays { get; set; }
    }
}