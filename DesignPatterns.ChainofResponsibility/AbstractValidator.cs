namespace DesignPatterns.ChainofResponsibility;

public abstract class AbstractValidator : IValidator
{
    public IValidator? NextValidator { get; set; }

    public virtual void Validate(ProductRequest request)
    {
        if (NextValidator is null)
        {
            Console.WriteLine("Validation completed!");
            return;
        }

        NextValidator.Validate(request);
    }
}