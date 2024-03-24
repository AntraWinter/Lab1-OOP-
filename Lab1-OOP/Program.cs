using Lab4_1_OOP_;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите первую дробь: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        var a = new Fraction(x1, y1);
        Console.WriteLine(a.ToString());
        
        Console.WriteLine("Введите вторую дробь: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        var b = new Fraction(x2, y2);
        Console.WriteLine(b.ToString());

        Fraction res = null;
        Console.WriteLine("\nСумма дробей: ");
        res = a + b;
        Console.WriteLine(res.ToString());


        Console.WriteLine("\nРазница дробей: ");
        res = a - b;
        Console.WriteLine(res.ToString());

        Console.WriteLine("\nПроизведение дробей: ");
        res = a * b;
        Console.WriteLine(res.ToString());


        Console.WriteLine("\nДеление дробей: ");
        res = a / b;
        Console.WriteLine(res.ToString());


        Console.WriteLine("\nДробь с противоположным знаком: ");
        res = -a;
        Console.WriteLine(res.ToString());

        Console.WriteLine("\nПроверка на == и !=");
        if (a == b) Console.WriteLine($"{a.ToString()} == {b.ToString()}");
        else if (a != b) Console.WriteLine($"{a.ToString()} != {b.ToString()}");


        Console.WriteLine("\nПроверка на < и >");
        if (a < b) Console.WriteLine($"{a.ToString()} < {b.ToString()}");
        else if (a > b) Console.WriteLine($"{a.ToString()} > {b.ToString()}");

        Console.WriteLine("\nПроверка на <= и >=");
        if (a <= b) Console.WriteLine($"{a.ToString()} <= {b.ToString()}");
        if (a >= b) Console.WriteLine($"{a.ToString()} >= {b.ToString()}");

    }


        

}