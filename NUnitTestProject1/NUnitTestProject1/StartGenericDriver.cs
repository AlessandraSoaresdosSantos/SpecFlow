using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NUnitTestProject1
{
    [TestFixture]
    public class StartGenericDriver : GenericDriver
    {
        [TearDown]
        public void TearDown()

        {
            Dispose();

        }

        [BeforeScenario]
        public void Setup()
        {
            //navegar para url base
        }

        [AfterScenario("after")]
        public void after()

        {
            if (ScenarioContext.Current.TestError != null)
            {

                NUnitTestProject1.TearDown.TakeScreenshot(Instance);
            }

            Dispose();

        }


    }
}