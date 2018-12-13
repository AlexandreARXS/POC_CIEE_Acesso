using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POC_CCEE_Access.Driver;

namespace POC_CCEE_Access.Pages.CCEE
{
    public class CCEE_HomePage
    {
        private readonly IStefaniniWebDriver driver;

        public CCEE_HomePage(IStefaniniWebDriver _driver)
        {
            this.driver = _driver;
        }

        public CCEE_HomePage IrPara()
        {
            driver.Navigate().GoToUrl("http://www.ccee.org.br/portal/faces/pages_publico/o-que-fazemos/como_ccee_atua/receita_vendas");
            return this;
        }

        public CCEE_ConteudoExclusivoPage ClicarNaAreaConteudoExclusivo()
        {
            var conteudoExclusivo_Locator = By.ClassName("acesso-conteudo-exclusivo");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(conteudoExclusivo_Locator));
            driver.FindElement(conteudoExclusivo_Locator).Click();
            return new CCEE_ConteudoExclusivoPage(driver);
        }
        public CCEE_ProximaPagina ClicarProxima()
        {
            var button_Locator = By.TagName("lista_relats_rrv_table_next");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(button_Locator));
            driver.FindElement(button_Locator).Click();
            return new CCEE_ProximaPagina(driver);
        }
        public CCEE_Filtro ClicarFiltro()
        {
            var filtro = driver.FindElement(By.Id("evento_rrv_selecionado"));
            var selectElement = new SelectElement(filtro);
            selectElement.SelectByValue("Custo Variável Unitário");
            selectElement.SelectByValue("Custo Variável Unitário Revisado");
            return new CCEE_Filtro(driver);
        }
        public CCEE_Downloads PegarListaDownload()
        {
            var button_Locator = By.ClassName("link-tabela-comunicado");
            driver.Wait.Until(ExpectedConditions.ElementIsVisible(button_Locator));
            driver.FindElement(button_Locator).Click();
            return new CCEE_Downloads(driver);
        }
    }
}