using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POC_CCEE_Access.Driver;
using POC_CCEE_Access.Pages.CCEE;

namespace POC_CCEE_Access.Pages.CCEE
{
    public class CCEE_Filtro
    {
        private readonly IStefaniniWebDriver driver;

        public CCEE_Filtro(IStefaniniWebDriver _drive)
        {
            this.driver = _drive;
        }
    }
}
