using NUnit.Framework;
using PlaywrightFramework.Core;
using PlaywrightFramework.Pages;

namespace PlaywrightTests.Tests
{
    
    public class LoginTests : BaseTest
    {

             

        [Test]
        public async Task UserCanLogin()
        {
       
            //await LoginPage.NavigateToLoginPage();

            var loginPage=new LoginPage(page);
            
            await loginPage.NavigateToLoginPage();

            var dashboardPage=new DashboardPage(page);

            await loginPage.Login("standard_user", "secret_sauce");
            
            bool isDashboardVisible = await dashboardPage.IsDashboardVisible();
            Assert.IsTrue(isDashboardVisible, "Dashboard should be visible after successful login.");
            
        }
    }
}