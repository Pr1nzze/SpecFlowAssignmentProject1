using OpenQA.Selenium;
using SpecFlowAssignmentProject1.Drivers;
using SpecFlowAssignmentProject1.Extensions;
using SpecFlowAssignmentProject1.Waithelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAssignmentProject1.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver _driver) 
        {
            this.driver = _driver;
        }


        ReadOnlyCollection<IWebElement> elements => driver?.FindElements(By.XPath("//div[@class='card mt-4 top-card']"))!;



        public void NavigateToSite(string url) => driver.Navigate().GoToUrl(url);

        public void ClickElements()
        {
            //elements[0].clickViaJs(driver);
            //elements.FirstOrDefault(x => x.Text.Equals("Elements")).Click();
            //driver?.clickViaJs(elements[0]);
            driver.WaitForDisplayed(elements[0]);
            jsExtensions.clickViaJs(driver, elements.FirstOrDefault(x => x.Text.Equals("Elements"))!);
        }
    }
}
