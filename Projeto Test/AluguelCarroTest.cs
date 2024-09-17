using TrabalhoApresentacao.uteis;

namespace TrabalhoApresentacao.Tests
{
    [TestClass]
    public class AluguelCarroTests
    {
        [TestMethod]
        public void TestCalcularCusto()
        {
            //cen�rio: Cria uma inst�ncia da classe AluguelCarro e define os par�metros de teste
            var aluguelCarro = new AluguelCarro();
            int dias = 5;
            double custoEsperado = 500.00;
            //a��o: Calcula o custo com base no n�mero de dias
            double custoCalculado = aluguelCarro.CalcularCusto(dias);
            //teste: Verifica se o custo calculado � igual ao custo esperado
            Assert.AreEqual(custoEsperado, custoCalculado);
        }
        [TestMethod]
        public void TestCalcularCustoComZeroDias()
        {
            //cen�rio
            var aluguelCarro = new AluguelCarro();
            int dias = 0;
            double custoEsperado = 0.00;
            //a��o
            double custoCalculado = aluguelCarro.CalcularCusto(dias);
            //teste
            Assert.AreEqual(custoEsperado, custoCalculado);
        }
    }
}