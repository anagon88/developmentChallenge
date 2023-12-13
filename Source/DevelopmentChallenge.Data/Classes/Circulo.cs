using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica 
    { 
        public Circulo(decimal ancho) : base(ancho)
        {

        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }
    }
}
