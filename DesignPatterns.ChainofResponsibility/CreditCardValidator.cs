namespace DesignPatterns.ChainofResponsibility;

public class CreditCardValidator : AbstractValidator
{
    const string CREDIT_CARD_PREFIX = "4432";

    public override void Validate(ProductRequest request)
    {
        if (!request.CrediCardNumber.StartsWith(CREDIT_CARD_PREFIX))
        {
            Console.WriteLine("Credit card number is invalid!");
            return;
        }

        base.Validate(request);
    }
}