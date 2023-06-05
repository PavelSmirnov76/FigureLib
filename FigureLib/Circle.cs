namespace FigureLib
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius 
        {
            get
            {
                return radius;
            } 
            set
            {
                if(value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Radius", "cannot be negative");
                }
            }
        }


        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
