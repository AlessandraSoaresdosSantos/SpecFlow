using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnitTestProject1
{
    [Binding]
    public class FeatureSiteSteps
    {
        readonly IWebDriver driver = new FirefoxDriver(".");


        [Given(@"que eu esteja no site jobmidia")]
        public void GivenQueEuEstejaNoSiteJobmidia()
        {
            driver.Navigate().GoToUrl("http://www.jobmidia.com.br");
            
        }

        [When(@"eu clicar no link contato")]
        public void WhenIPressAdd()
        {
            driver.FindElement(By.Id("contatomenu")).Click();
            Thread.Sleep(3000);
        }

        [When(@"para entrar em contato e necessario informar todos os dados obrigatorios do formulario: (.*),(.*),(.*),(.*)")]
        public void WhenParaEntrarEmContatoENecessarioInformarTodosOsDadosObrigatoriosDoFormulario(string p0, string p1, string p2, string p3)
        {
            driver.FindElement(By.Id("name")).Click();
            driver.FindElement(By.Id("name")).Clear();
            driver.FindElement(By.Id("name")).SendKeys(p0);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys(p1);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys(p2);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("message")).Click();
            driver.FindElement(By.Id("message")).Clear();
            driver.FindElement(By.Id("message")).SendKeys(p3);
            Thread.Sleep(1000);
        }

        [When(@"eu clicar em Enviar")]
        public void WhenEuClicarEmEnviar()
        {
            driver.FindElement(By.Id("enviarbotao")).Click();
        }

        [Then(@"finizar o site")]
        public void ThenFinalizarOSite()
        {
            driver.Quit();
        }
        
    }
}
