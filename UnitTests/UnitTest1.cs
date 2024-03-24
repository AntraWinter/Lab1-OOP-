using Lab4_1_OOP_;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        [TestCase(1, 0)]
        public void ErrorTest(int a1, int a2)
        {
            Assert.Throws<ArgumentException>(delegate { new Fraction(a1, a2); });
        }

        [TestCase(1, 4, 2, 4, 3, 4)]
        [TestCase(1, 4, 1, 3, 7, 12)]
        [TestCase(1, -4, 1, 4, 0, 4)]
        [TestCase(20, 4, -10, 5, 3, 1)]
        public void Addition(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            //arrange
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);
            Fraction expected = new Fraction(r1, r2);

            //act
            Fraction actual = a + b;

            //assert 
            Assert.That(expected.Numerator == actual.Numerator, Is.True);
            Assert.That(expected.Denominator == actual.Denominator, Is.True);
        }

        [Test]
        [TestCase(3, 4, 2, 4, 1, 4)]
        [TestCase(1, -4, 1, 4, -1, 2)]
        [TestCase(20, 4, -10, 5, 7, 1)]
        [TestCase(10, -5, -10, 5, 0, 5)]
        public void Subtraction(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            //
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);
            Fraction expected = new Fraction(r1, r2);
            //
            Fraction actual = a - b;
            //
            Assert.That(expected.Numerator == actual.Numerator, Is.True);
            Assert.That(expected.Denominator == actual.Denominator, Is.True);
        }

        [Test]
        [TestCase(1, 4, 2, 4, 2, 16)]
        [TestCase(1, 4, 2, 4, 1, 8)]
        [TestCase(1, 4, 0, 4, 0, 16)]
        [TestCase(1, 4, 4, 1, 1, 1)]
        [TestCase(1, -4, 2, 4, -2, 16)]
        [TestCase(-1, 4, 2, 4, 1, -8)]
        public void Multiplication(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);
            Fraction expected = new Fraction(r1, r2);

            Fraction actual = a * b;

            Assert.That(expected.Numerator == actual.Numerator, Is.True);
            Assert.That(expected.Denominator == actual.Denominator, Is.True);
        }

        [Test]
        [TestCase(1, 4, 2, 4, 4, 8)]
        [TestCase(1, -4, 2, 4, -4, 8)]
        [TestCase(1, -4, 2, -4, 1, 2)]
        [TestCase(0, 3, 2, 5, 0, 6)]
        public void Mivision(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);
            Fraction expected = new Fraction(r1, r2);

            Fraction actual = a / b;

            Assert.That(expected.Numerator == actual.Numerator, Is.True);
            Assert.That(expected.Denominator == actual.Denominator, Is.True);
        }

        [Test]
        [TestCase(1, 4, -1, 4)]
        [TestCase(1, 4, 1, -4)]
        [TestCase(0, 4, -0, 4)]
        [TestCase(4, 2, -2, 1)]
        public void Mnversion(int a1, int a2, int r1, int r2)
        {
            Fraction a = new Fraction(a1, a2);
            Fraction expected = new Fraction(r1, r2);

            Fraction actual = -a;

            Assert.That(expected.Numerator == actual.Numerator, Is.True);
            Assert.That(expected.Denominator == actual.Denominator, Is.True);
        }

        [Test]
        [TestCase(1, 4, 1, 4)]
        [TestCase(0, 4, 0, 4)]
        [TestCase(4, 4, 3, 3)]
        [TestCase(12, 4, 9, 3)]
        [TestCase(-1, 4, 1, -4)]
        [TestCase(1, -4, -1, 4)]
        public void Same(int a1, int a2, int b1, int b2)
        {
            int flag = 1;
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);

            int actual = 0;
            if (a == b) actual = 1;

            Assert.That(flag == actual, Is.True);
        }

        [Test]
        [TestCase(1, 4, 3, 4)]
        [TestCase(1, 4, 1, 3)]
        [TestCase(1, 4, 0, 4)]
        [TestCase(4, 4, 3, 4)]
        [TestCase(4, 4, 3, 1)]
        public void Different(int a1, int a2, int b1, int b2)
        {
            int flag = 1;
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);

            int actual = 0;
            if (a != b) actual = 1;

            Assert.That(flag == actual, Is.True);
        }

        [Test]
        [TestCase(1, 4, 2, 4)]
        [TestCase(1, 4, 8, 4)]
        [TestCase(0, 4, 1, 4)]
        [TestCase(1, 4, 1, 3)]
        [TestCase(1, -3, -1, 4)]
        [TestCase(-1, 3, 1, -4)]
        public void Less(int a1, int a2, int b1, int b2)
        {
            int flag = 1;
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);

            int actual = 0;
            if (a < b) actual = 1;

            Assert.That(flag == actual, Is.True);
        }

        [Test]
        [TestCase(2, 4, 1, 4)]
        [TestCase(4, 4, 1, 4)]
        [TestCase(4, 2, 0, 4)]
        public void More(int a1, int a2, int b1, int b2)
        {
            int flag = 1;
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);

            int actual = 0;
            if (a > b) actual = 1;

            Assert.That(flag == actual, Is.True);
        }

        [Test]
        [TestCase(1, 4, 1, 4)]
        [TestCase(1, 4, 2, 4)]
        [TestCase(0, 4, 1, 4)]
        public void LessThanOrEqualTo(int a1, int a2, int b1, int b2)
        {
            int flag = 1;
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);

            int actual = 0;
            if (a <= b) actual = 1;

            Assert.That(flag == actual, Is.True);
        }

        [Test]
        [TestCase(4, 4, 1, 4)]
        [TestCase(2, 4, 1, 4)]
        [TestCase(4, 4, 0, 4)]
        [TestCase(4, 4, 2, 2)]
        public void GreaterThanOrEqualTo(int a1, int a2, int b1, int b2)
        {
            int flag = 1;
            Fraction a = new Fraction(a1, a2);
            Fraction b = new Fraction(b1, b2);

            int actual = 0;
            if (a >= b) actual = 1;

            Assert.That(flag == actual, Is.True);
        }
    }
}