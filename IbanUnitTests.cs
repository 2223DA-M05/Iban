namespace iban {

    public class IbanUnitTests
    {
        [Fact]
        public void ConvertsToUpper()
        {
            // Arrange
            var iban = new Iban("abcdefgh");
            
            // Act
            var processedIban = iban.IbanNumber;
            
            // Assert
            processedIban.Should().Be("ABCDEFGH");
        }

        [Fact]
        public void CreatesOnValidInput()
        {
            
        }

        [Fact]
        public void ThrowsOnInvalidInput()
        {
            // Arrange
            Action act = () => new Iban("Çñ");

            // Assert
            act.Should().Throw<ArgumentException>()
                .WithParameterName("input");
        }
    }
}