using DesignPatterns.ChainofResponsibility;

class ECommerceWebsite
{
    public void Order(ProductRequest request, AbstractValidator validator)
    {
        validator.Validate(request);
    }
}


class Program
{
    public static void Main(String[] args)
    {
        var request = new ProductRequest
        {
            CrediCardNumber = "4432123412341234",
            ProductName = "Test-Product",
            Quantity = 20,
            ShippingAddress = "Address POST CODE: 1234"
        };

        var validator = new StockValidator();
        validator.NextValidator = new CreditCardValidator();
        (validator.NextValidator as AbstractValidator)!.NextValidator = new ShippingAddressValidator();

        var ecommerceWebsite = new ECommerceWebsite();
        ecommerceWebsite.Order(request, validator);
    }
}