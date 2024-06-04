using Microsoft.AspNetCore.Identity;
using YaLibrary.Models;

namespace YaLibrary.Helper
{
    public static class UserManagerAccessor
    {
        public static UserManager<AppUser> UserManager { get; set; } = null!;
    }
}
