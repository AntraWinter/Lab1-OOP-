namespace Lab4_1_OOP_
{
    public class Fraction : Object
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int a1, int a2)
        {
            if (a2 == 0)
                throw new ArgumentException("Делить на ноль нельзя", nameof(a2));

            Numerator = a1 / NOD(a1, a2);
            Denominator = a2 / NOD(a1, a2);
            if (Numerator < 0)
            {
                if (Denominator < 0)
                {
                    Numerator = Math.Abs(Numerator);
                    Denominator = Math.Abs(Denominator);
                }
                else
                {
                    Numerator = Math.Abs(Numerator);
                    Denominator = Math.Abs(Denominator);
                    Numerator = -Numerator;
                }
            }
            else
            {
                if (Denominator < 0)
                {
                    Numerator = Math.Abs(Numerator);
                    Denominator = Math.Abs(Denominator);
                    Numerator = -Numerator;
                }
            }

        }

        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            if (Numerator == 0) return "0";
            else
            {
                if (Denominator == 1) return Numerator.ToString();
                else return $"{Numerator}/{Denominator}";

            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            if (a.Denominator == b.Denominator)
            {
                var Numerator = a.Numerator + b.Numerator;
                var Denominator = a.Denominator;
                return new Fraction(Numerator, Denominator);
            }
            else
            {
                var Numerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
                var Denominator = a.Denominator * b.Denominator;
                return new Fraction(Numerator, Denominator);
            }
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            if (a.Denominator == b.Denominator)
            {
                var Numerator = a.Numerator - b.Numerator;
                var Denominator = a.Denominator;
                return new Fraction(Numerator, Denominator);
            }
            else
            {
                var Numerator = (a.Numerator * b.Denominator) - (b.Numerator * a.Denominator);
                var Denominator = a.Denominator * b.Denominator;
                return new Fraction(Numerator, Denominator);
            }
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            
            var Numerator = a.Numerator * b.Numerator;
            var Denominator = a.Denominator * b.Denominator;
            return new Fraction(Numerator, Denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            
            var Numerator = a.Numerator * b.Denominator;
            var Denominator = a.Denominator * b.Numerator;
            return new Fraction(Numerator, Denominator);
        }

        public static Fraction operator -(Fraction a)
        {
            
            var Numerator = -a.Numerator;
            var Denominator = a.Denominator;
            return new Fraction(Numerator, Denominator);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            Fraction _a = a;
            Fraction _b = b;
            if (_a.Numerator == _b.Numerator && _a.Denominator == _b.Denominator) return true;
            else return false;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            Fraction _a = a;
            Fraction _b = b;
            if (_a.Numerator != _b.Numerator || _a.Denominator != _b.Denominator) return true;
            else return false;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            Fraction _a = a;
            Fraction _b = b;
            if (_a.Denominator == _b.Denominator)
            {
                if (_a.Numerator < _b.Numerator) return true;
                else return false;
            }
            else
            {
                if ((_a.Numerator * _b.Denominator) < (_b.Numerator * _a.Denominator)) return true;
                else return false;
            }
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            Fraction _a = a;
            Fraction _b = b;
            if (_a.Denominator == _b.Denominator)
            {
                if (_a.Numerator > _b.Numerator) return true;
                else return false;
            }
            else
            {
                if ((_a.Numerator * _b.Denominator) > (_b.Numerator * _a.Denominator)) return true;
                else return false;
            }
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            Fraction _a = a;
            Fraction _b = b;
            if (_a.Denominator == _b.Denominator)
            {
                if (_a.Numerator <= _b.Numerator) return true;
                else return false;
            }
            else
            {
                if ((_a.Numerator * _b.Denominator) <= (_b.Numerator * _a.Denominator)) return true;
                else return false;
            }
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            Fraction _a = a;
            Fraction _b = b;
            if (_a.Denominator == _b.Denominator)
            {
                if (_a.Numerator >= _b.Numerator) return true;
                else return false;
            }
            else
            {
                if ((_a.Numerator * _b.Denominator) >= (_b.Numerator * _a.Denominator)) return true;
                else return false;
            }
        }
    }
}
