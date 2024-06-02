namespace DesignPatterns.ChainofResponsibility;

public interface IValidator
{
    void Validate(ProductRequest request);
}