namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        protected readonly decimal _lado;

        public FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
