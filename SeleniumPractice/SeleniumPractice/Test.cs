using OpenQA.Selenium.Chrome;
using SeleniumPractice.Models;

namespace SeleniumPractice;

[TestClass]
public class Test
{
    private readonly ChromeDriver _driver = new ChromeDriver();

    [TestMethod]
    public void GoogleSearchTest()
    {
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl("https://www.google.com/");
        
        Google google = new Google(_driver);
        google.Search("BEON Tech");
        GoogleResult googleResult = new GoogleResult(_driver);
        googleResult.AssertSearch("BEON Tech");
    }
}