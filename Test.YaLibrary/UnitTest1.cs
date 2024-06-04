using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using YaLibrary.Models;

namespace Test.YaLibrary
{
    public class UnitLibraryTest
    {
        private readonly UserManager<AppUser> userManager;

        public UnitLibraryTest(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }


        [Theory]
        [InlineData("Test", "User", "test@test.se", "Test@1234"), ]
        [InlineData("Test2", "User", "test2@test.se", "Test@1234")]
        [InlineData("Test2", "User", "test2@test.se", "Test@1234")]
        public async Task Test_User_Registration(
            string firstName, string lastName, string email, string password)
        {
            // arrange
            var newUser = new AppUser(firstName, lastName, email);
            // act
            var Library = new Library(userManager);
            var result = await Library.RegisterUser(newUser, password);
            // assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Theory]
        [InlineData("Act")]
        public void Test_Search_Book(string title)
        {
            
        }
    }
}