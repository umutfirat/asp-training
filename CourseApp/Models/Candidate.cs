

using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is Required.")]
        public String? Email {get; set;} = String.Empty;

        [Required(ErrorMessage = "First Name is Required.")]
        public String? FirstName {get; set;} = String.Empty;

        [Required(ErrorMessage = "Last Name is Required.")]
        public String? LastName {get; set;} = String.Empty;

        public int? Age {get; set;}

        public String? SelectedCourse {get; set;} = String.Empty;

        public DateTime ApplyAt {get; set;}

        public String FullName => $"{FirstName} {LastName?.ToUpper()}";

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}