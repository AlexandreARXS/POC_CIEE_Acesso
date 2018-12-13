using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POC_CCEE_Access.Driver;
using POC_CCEE_Access.Pages.CCEE;

namespace POC_CCEE_Access.Services
{
    class CCEE_Menu
    {
        private readonly IStefaniniWebDriver driver;
        public CCEE_Menu(IStefaniniWebDriver _driver)
        {
            driver = _driver;
        }

        public void AcessarOQueFazemos()
        {
            var HomePage = new CCEE_HomePage(driver);
            var valor = HomePage.IrPara();
            valor.ClicarFiltro();
            valor.PegarListaDownload();
        }
    }
}
