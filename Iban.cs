public class Iban {
    public string IbanNumber { get; set; }
    public Iban(string input) {
        IbanNumber = input.ToUpperInvariant();
    }
}