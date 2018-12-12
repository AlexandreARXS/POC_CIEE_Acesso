using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POC_CCEE_Access.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_CCEE_Access.Pages.CCEE
{
    public class CCEE_ProximaPagina
    {
        private readonly IStefaniniWebDriver driver;
        public CCEE_ProximaPagina(IStefaniniWebDriver _driver)
        {
            this.driver = _driver;
        }
        public CCEE_ProximaPagina ClicarProxima()
        {
            var button_Locator = By.TagName("lista_relats_rrv_table_next");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(button_Locator));
            driver.FindElement(button_Locator).Click();
            return this;
        }
    }
}
