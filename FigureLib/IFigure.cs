namespace FigureLib
{
    // Интерфейс IFigure используется для реализации паттерна стратегия, который позволяет легко создавать новые классы фигур и выбирать между ними. 
    public interface IFigure
    {
        public double CalculateArea();
    }
}