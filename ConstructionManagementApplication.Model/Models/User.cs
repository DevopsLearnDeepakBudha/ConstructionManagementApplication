using System;

namespace ConstructionManagementApplication.Model
{
    public class User
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string LastName { get; set; }
        public static DateTime CreatedOn { get; set; }
        public static bool IsSuccess { get; set; }
        public static string Message { get; set; }
    }
}
