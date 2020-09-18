namespace Maroto.DesignPatterns.StructuralDesigns.Adapter.Contracts
{
    public interface IEnchufe
    {
        int Voltaje { get; }
        int Bornes { get; }
        string ObtenerNumeroDeBornes();
    }
}