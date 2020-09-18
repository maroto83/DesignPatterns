namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts
{
    public interface IEnchufeAmericano
        : IEnchufe
    {
        string Flujo110V();
    }
}