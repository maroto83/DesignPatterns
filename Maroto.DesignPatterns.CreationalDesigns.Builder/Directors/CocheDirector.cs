using Maroto.DesignPatterns.CreationalDesigns.Builder.Contracts;

namespace Maroto.DesignPatterns.CreationalDesigns.Builder.Directors
{
    public class CocheDirector
    {
        private readonly ICocheBuilder _builder;

        public CocheDirector(ICocheBuilder builder)
        {
            _builder = builder;
        }

        public void BuildBasico()
        {
            _builder.Reset();
            _builder.SetAsientos(4);
            _builder.SetMotor("motor básico");
        }

        public void BuildTodoIncluido()
        {
            _builder.Reset();
            _builder.SetAsientos(5);
            _builder.SetMotor("motor superior");
            _builder.SetOrdenadorABordo();
            _builder.SetGPS();
        }
    }
}