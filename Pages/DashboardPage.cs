using Microsoft.Playwright;


namespace PlaywrightFramework.Pages;

public class DashboardPage
{
    private readonly IPage _page;

    public DashboardPage(IPage page)
    {
        _page = page;
    }


    private ILocator WelcomeMessage => _page.Locator(".app_logo");

    public async Task<bool> IsDashboardVisible()
    {
        return await WelcomeMessage.IsVisibleAsync();
    }

    
}