namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts
{
    public interface IEnchufeEuropeo
        : IEnchufe
    {
        string Flujo220V();
    }
}