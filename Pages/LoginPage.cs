using Microsoft.Playwright;

namespace PlaywrightFramework.Pages
{


    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }

        private ILocator Username => _page.Locator("#user-name");
        private ILocator Password => _page.Locator("#password"); 
        private ILocator LoginButton => _page.Locator("#login-button");   
        //private ILocator LoginButton => _page.Locator("#login");



        public async Task NavigateToLoginPage()
        {
            //await _page.GotoAsync("https://example.com/login");
            await _page.GotoAsync("https://www.saucedemoXX.com/");
        }

        public async Task Login(string username, string password)
        {
            await Username.FillAsync(username);
            await Password.FillAsync(password);
            await LoginButton.ClickAsync();
        }

    }
}
