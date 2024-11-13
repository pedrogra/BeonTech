using OpenQA.Selenium;

namespace SeleniumPractice.Models;

public class Google
{
    public Google(WebDriver _driver)
    {
        driver = _driver;
    }
    private WebDriver driver;
    private string queryTextArea = "//textarea[@name='q']";
    private string searchButton = "(//input[@role='button'])[1]";

    public void Search(string topic)
    {
        IWebElement input = driver.FindElement(By.XPath(queryTextArea));
        input.SendKeys(topic);
        
        IWebElement search = driver.FindElement(By.XPath(searchButton));
        //search.Click();
        input.SendKeys(Keys.Enter);
    }
}