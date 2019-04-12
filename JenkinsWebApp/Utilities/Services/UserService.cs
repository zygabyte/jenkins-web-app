using JenkinsWebApp.Models;
using JenkinsWebApp.Utilities.Enums;

namespace JenkinsWebApp.Utilities.Services
{
    public static class UserService
    {
        public static bool IsUserVggUser(User user)
        {
            if (user.Email.Contains("@venturegardengroup.com") || user.Email.Contains("@splasherstech.com"))
                return true;

            return false;
        }

        public static string GetUserType(User user)
        {
            switch (user.UserRole)
            {
                case UserRole.Admin:
                    return UserRole.Admin.ToString();

                case UserRole.User:
                    return UserRole.User.ToString();

                case UserRole.Client:
                    return UserRole.Client.ToString();

                default:
                    return "";
            }
        }
    }
}