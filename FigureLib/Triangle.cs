namespace FigureLib
{
    public class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if(A > B + C || B > A + C || C > A + B)
            {
                throw new ArgumentException("This is not triangle");
            }
        }

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A", "Side cannot be negative");
                }
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("B", "Side cannot be negative");
                }
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value >= 0)
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("C", "Side cannot be negative");
                }
            }
        }

        public double CalculateArea()
        {
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightTriangle()
        {
            if( A > B)
            {
                if(A > C)
                {
                    return A * A == C * C + B * B;
                }
                else
                {
                    return C * C == A * A + B * B;
                }
            }  
            else
            {
                if (B > C)
                {
                    return B * B == C * C + A * A;
                }
                else
                {
                    return C * C == A * A + B * B;
                }
            }
        }
    }
}
