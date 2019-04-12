using JenkinsWebApp.Utilities.Enums;

namespace JenkinsWebApp.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole UserRole { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}