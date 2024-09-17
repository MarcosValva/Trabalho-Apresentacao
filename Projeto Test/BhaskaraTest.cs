using TrabalhoApresentacao.uteis;

namespace TrabalhoApresentacao.Tests
{
    [TestClass]
    public class BhaskaraTest
    {
        [TestMethod]
        public void CalcularRaizes_EquacaoComRaizesReais_RetornaRaizesCorretas()
        {
            //cenário: Define os coeficientes da equação e as raízes esperadas
            double a = 1;
            double b = -3;
            double c = 2;
            double raiz1Esperada = 2.0;
            double raiz2Esperada = 1.0;
            //ação: Calcula as raízes usando o método Bhaskara
            (bool sucesso, double raiz1, double raiz2) = Bhaskara.CalcularRaizes(a, b, c);
            //teste: Verifica se o cálculo foi bem-sucedido e se as raízes retornadas são as esperadas
            Assert.IsTrue(sucesso);
            Assert.AreEqual(raiz1Esperada, raiz1, 0.01);
            Assert.AreEqual(raiz2Esperada, raiz2, 0.01);
        }

        [TestMethod]
        public void CalcularRaizes_EquacaoSemRaizesReais_RetornaFalso()
        {
            //cenário: Define os coeficientes da equação quadrática que resultam em raízes não reais
            double a = 1;
            double b = 2;
            double c = 5;
            //ação: Calcula as raízes usando o método Bhaskara
            (bool sucesso, double raiz1, double raiz2) = Bhaskara.CalcularRaizes(a, b, c);
            //teste: Verifica se o cálculo não foi bem-sucedido, indicando que não há raízes reais
            Assert.IsFalse(sucesso);
        }
    }
}
