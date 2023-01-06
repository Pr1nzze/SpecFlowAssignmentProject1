using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowAssignmentProject1.Waithelpers
{
    public static class WaitAction
    {
        public static bool WaitForDisplayed(this IWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            return wait.Until(x => element.Displayed);
        }
    }
}
