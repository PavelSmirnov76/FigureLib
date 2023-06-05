namespace FigureLibTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_3_4_5_6()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expected = 6;

            var actual = new Triangle(a, b, c).CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsRightTriangle_3_4_5_6()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expected = true;

            var actual = new Triangle(a, b, c).IsRightTriangle();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateArea_1_1_2_0()
        {
            var a = 1;
            var b = 1;
            var c = 2;
            var expected = 0;

            var actual = new Triangle(a, b, c).CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NewTriangle_Negative5_3_2_throwArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var negativeCircle = new Triangle(-5, 3, 2);
            });
        }

        [Fact]
        public void NewTriangle_1_1_3_throwArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var negativeCircle = new Triangle(1, 1, 3);
            });
        }
    }
}
