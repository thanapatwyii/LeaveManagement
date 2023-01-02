using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LMS_1.Models;

public class LeaveTypeVM
{
    public int Id { get; set; }

    [Display(Name = "Leave Type Name")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Dafault Number Of Days")]
    [Required]
    [Range (0,100, ErrorMessage ="Invalid Number")]
    public int DefaultDays { get; set; }
}