using OpenQA.Selenium.Chrome;
using SpecFlowAssignmentProject1.Drivers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowAssignmentProject1.Pages
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly driverHelper driverHelper;

        public Hooks1(driverHelper driverHelper)
        {
            this.driverHelper = driverHelper;
        }


        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            new DriverManager().SetUpDriver(new ChromeConfig()); //handles initialization of browsers
            var options = new ChromeOptions(); ////handles additional capability options
            options.AddArguments("--start-maximized", "--incognito");
            driverHelper.driver = new ChromeDriver(options); //initialization of browser object
        }


        [AfterScenario]
        public void AfterScenario()
        {
            if (driverHelper.driver != null)
            {
                driverHelper.driver.Quit();
            }
            driverHelper.driver = null;
        }
    }
}
