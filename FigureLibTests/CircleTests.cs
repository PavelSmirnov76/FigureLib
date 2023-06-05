namespace FigureLibTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_5_78()
        {
            // Arrange
            var radius = 5;
            var expected = 78.00d;
            //act
            // привожу к int что-бы отбросить дробную часть и сравнить примерные значения
            var actual = (int)(new Circle(radius).CalculateArea());
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateArea_0_0()
        {
            var radius = 0;
            var expected = 0;

            var actual = (int)(new Circle(radius).CalculateArea());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void newCircle_negative5_throwArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var negativeCircle = new Circle(-5);
            });
        }
    }
}