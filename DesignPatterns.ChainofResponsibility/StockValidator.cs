namespace DesignPatterns.ChainofResponsibility;

public class StockValidator : AbstractValidator
{
    const int STOCK_SIZE = 20;

    public override void Validate(ProductRequest request)
    {
        if (request.Quantity > STOCK_SIZE)
        {
            Console.WriteLine("There is not enough stock for the product!");
            return;
        }

        base.Validate(request);
    }
}