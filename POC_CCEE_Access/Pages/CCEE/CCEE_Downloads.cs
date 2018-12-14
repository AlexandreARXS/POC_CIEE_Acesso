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
    public class CCEE_Downloads
    {
        private readonly IStefaniniWebDriver driver;

        public CCEE_Downloads(IStefaniniWebDriver _driver)
        {
            this.driver = _driver;
        }
    }
}
