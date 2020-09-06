using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int Resultado;
        private Calculator _calculadora = new Calculator();

        [Given("que o primeiro número seja (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculadora.FirstNumber = number;
        }

        [Given("o segundo número seja (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculadora.SecondNumber = number;
        }

        [When("há uma (.*)")]
        public void WhenAreOneOperation(string operation)
        {
            switch (operation)
            {
                case "soma":
                    Resultado = _calculadora.Addition();
                    break;
                case "subtração":
                    Resultado = _calculadora.Subtraction();
                    break;
                case "multiplicação":
                    Resultado = _calculadora.Multiplication();
                    break;
                case "divisão":
                    Resultado = _calculadora.Division();
                    break;
                default:
                    Assert.Fail();
                    break;
            }
        }

        [Then("o resultado deve ser (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, Resultado);
        }
    }
}
