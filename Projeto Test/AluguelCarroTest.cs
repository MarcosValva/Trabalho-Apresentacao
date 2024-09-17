using TrabalhoApresentacao.uteis;

namespace TrabalhoApresentacao.Tests
{
    [TestClass]
    public class AluguelCarroTests
    {
        [TestMethod]
        public void TestCalcularCusto()
        {
            //cenário: Cria uma instância da classe AluguelCarro e define os parâmetros de teste
            var aluguelCarro = new AluguelCarro();
            int dias = 5;
            double custoEsperado = 500.00;
            //ação: Calcula o custo com base no número de dias
            double custoCalculado = aluguelCarro.CalcularCusto(dias);
            //teste: Verifica se o custo calculado é igual ao custo esperado
            Assert.AreEqual(custoEsperado, custoCalculado);
        }
        [TestMethod]
        public void TestCalcularCustoComZeroDias()
        {
            //cenário
            var aluguelCarro = new AluguelCarro();
            int dias = 0;
            double custoEsperado = 0.00;
            //ação
            double custoCalculado = aluguelCarro.CalcularCusto(dias);
            //teste
            Assert.AreEqual(custoEsperado, custoCalculado);
        }
    }
}