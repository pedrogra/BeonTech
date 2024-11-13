using OpenQA.Selenium;

namespace SeleniumPractice.Models;

public class GoogleResult
{
    public GoogleResult(WebDriver _driver)
    {
        driver = _driver;
    } 
    private WebDriver driver;
    private string titleXpath = "//div[@data-attrid='title']";

    public void AssertSearch(string title)
    {
        Assert.IsTrue(driver.Url.Contains($"search?q={title.Replace(" ", "+")}"));
        Assert.AreEqual(title.Replace(" ",".").ToLowerInvariant(), driver.FindElement(By.XPath(titleXpath)).Text.ToLowerInvariant());
    }
}