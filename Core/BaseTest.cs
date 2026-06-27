 using Microsoft.Playwright;
 using NUnit.Framework;

 namespace PlaywrightFramework.Core
{
 public class BaseTest
 {
    protected IPlaywright playwright;
    protected IBrowser browser;
    protected IPage page;

    [SetUp]
    public async Task SetUp()
    {
        playwright = await Playwright.CreateAsync();
        browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        page = await browser.NewPageAsync();
    }


    //[TearDown]
    public async Task TearDown()
    {
       
         if (browser != null)
        {
        await page.CloseAsync();
        await browser.CloseAsync();
        playwright.Dispose();
        }

    }

    }
}