namespace Maroto.DesignPatterns.CreationalDesigns.AbstractFactory.Contracts
{
    public interface IFabricaDeMuebles
    {
        ISilla CrearSilla();
        ISofa CrearSofa();
        IMesilla CrearMesilla();
    }
}