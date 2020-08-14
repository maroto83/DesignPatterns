namespace Maroto.DesignPatterns.CreationalDesigns.Builder.Contracts
{
    public interface ICocheBuilder
    {
        void Reset();
        void SetAsientos(int numeroDeAsientos);
        void SetMotor(string motor);
        void SetOrdenadorABordo();
        void SetGPS();
    }
}