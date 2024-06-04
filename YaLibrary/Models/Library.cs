using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YaLibrary.Helper;

namespace YaLibrary.Models
{
    public class Library
    {
        private readonly UserManager<AppUser> userManager;

        public List<Book> Books { get; set; }
        public List<AppUser> Users { get; set; }

        public Library(UserManager<AppUser> userManager)
        {
            Books = new List<Book>();
            Users = new List<AppUser>();
            //            userManager = ServiceLocator.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
            this.userManager = userManager;
        }

        public async Task<ActionResult> RegisterUser(AppUser user, string _passwd)
        {
            if (userManager == null)
                return new BadRequestObjectResult("User manager not found");

            var result = await userManager.CreateAsync(user, _passwd);

            if (result.Succeeded)
            {
                return new OkObjectResult("User registered successfully");
            }

            return new BadRequestObjectResult(result.Errors);
        }
    }
}
