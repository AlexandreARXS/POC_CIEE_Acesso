using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
            var coisa = valor.PegarListaDownload();
            string caminho = @"C:\Users\AAsilva\Downloads\Arquivos ENEVA";
            foreach(var item in coisa)
            {
                var link = item.GetAttribute("href");
                var nomeArquivo = item.Text;

                var destino = Path.Combine(caminho, nomeArquivo.Replace("/", "-"));
                WebClient client = new WebClient();
                client.DownloadFile(link, destino + ".pdf");
            }
        }
    }
}
