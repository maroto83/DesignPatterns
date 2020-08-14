using Maroto.DesignPatterns.CreationalDesigns.Builder.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.Models
{
    public class ManualDelCoche
        : ICoche
    {
        public int NumeroDeAsientos { get; set; }
        public string Motor { get; set; }
        public string OrdenadorABordo { get; set; }
        public string GPS { get; set; }
    }
}