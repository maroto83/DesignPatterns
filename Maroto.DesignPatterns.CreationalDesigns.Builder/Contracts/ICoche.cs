namespace Maroto.DesignPatterns.CreationalDesigns.Builder.Contracts
{
    public interface ICoche
    {
        int NumeroDeAsientos { get; set; }
        string Motor { get; set; }
        string OrdenadorABordo { get; set; }
        string GPS { get; set; }
    }
}
