using POC_CCEE_Access.Driver;
using POC_CCEE_Access.Services;

namespace POC_CCEE_Access
{
    class Program
    {
        static void Main(string[] args)
        {
            //var servico = new CCEE_Service(new StefaniniWebDriver());
            //servico.AcessarConteudoRestrito();

            var menu = new CCEE_Menu(new StefaniniWebDriver());
            menu.AcessarOQueFazemos();
        }
    }


}