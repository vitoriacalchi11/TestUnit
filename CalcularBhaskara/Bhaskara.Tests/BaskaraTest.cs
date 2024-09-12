namespace Bhaskara.Tests
{
    public class BaskaraTest
    {
        [Fact]
        public void DeveRetornarDuasRaizesReais()
        {
            // Arrange
            double n1 = 1, n2 = -3, n3 = 2; // Raízes esperadas: 2 e 1

            // Act
            var resultado = CalcularBhaskara.Bhaskara.CalcularRaizes(n1, n2, n3);

            // Assert
            Assert.Equal(2, resultado.Item1);
            Assert.Equal(1, resultado.Item2);
        }

        [Fact]
        public void DeveRetornarNenhumaRaizReal()
        {
            // Arrange
            double n1 = 1, n2 = 2, n3 = 5; // Delta negativo, sem raízes reais

            // Act
            var resultado = CalcularBhaskara.Bhaskara.CalcularRaizes(n1, n2, n3);

            // Assert
            Assert.Null(resultado.Item1);
            Assert.Null(resultado.Item2);
        }
    }
}