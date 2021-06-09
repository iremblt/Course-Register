using System.ComponentModel.DataAnnotations;

namespace CourseRegister.Models
{
    public class Students
    {
        [Required (ErrorMessage="Enter your name")]
        public string StudentName { get; set; }
        [Required (ErrorMessage="Enter your Email")]
        [EmailAddress(ErrorMessage ="Your email address is wrong")]
        public string StudentEmail { get; set; }
        [Required (ErrorMessage="Enter your Phone Number")]
        public string StudentPhone { get; set; }
        [Required (ErrorMessage="Select one of the options")]        
        public bool? IsConfirm { get; set; }
    }
}