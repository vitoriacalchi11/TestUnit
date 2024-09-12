namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, CalculadoraExemple.Calculadora.Somar(2, 2));
        }
        public void Subtrair()
        {
            Assert.Equal(4, CalculadoraExemple.Calculadora.Subtrair(8, 2));
        }
        public void Dividir()
        {
            Assert.Equal(4, CalculadoraExemple.Calculadora.Dividir(8, 2));
        }
        public void Multiplicar()
        {
            Assert.Equal(4, CalculadoraExemple.Calculadora.Multiplicar(2, 2));
        }
    }
}