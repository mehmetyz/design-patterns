namespace DesignPatterns.ChainofResponsibility;

public class ShippingAddressValidator : AbstractValidator
{
    const string POST_CODE_MATCH = "POST CODE:";

    public override void Validate(ProductRequest request)
    {
        if (!request.ShippingAddress.Contains(POST_CODE_MATCH))
        {
            Console.WriteLine("The shipping address has not post code!");
            return;
        }

        base.Validate(request);
    }
}