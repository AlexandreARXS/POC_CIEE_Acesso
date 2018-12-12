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
    public class CCEE_OQueFazemos
    {
        private readonly IStefaniniWebDriver driver;
        public CCEE_OQueFazemos(IStefaniniWebDriver _driver)
        {
            this.driver = _driver;
        }

        public CCEE_OQueFazemos ClicarEmLeiloes()
        {
            var button_Locator = By.TagName("leiloes");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(button_Locator));
            driver.FindElement(button_Locator).Click();
            return this;
        }
        public CCEE_OQueFazemos BuscarLinkReceitaDeVendas()
        {
            var link_Locator = By.TagName("receita-de-vendas");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(link_Locator));
            driver.FindElement(link_Locator).Click();
            return this;
        }
    }
}
