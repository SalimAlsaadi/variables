namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            string num1 = Console.ReadLine();
            int  num4 = (int)Convert.ToInt64(num1);
            Console.WriteLine("Enter second Number ");
            string num2 = Console.ReadLine();
            int num5 = (int)Convert.ToInt64(num2);

            int num3 = num4 + num5;
            Console.WriteLine("num1 + num2 = " + num3);
             num3 = num4 - num5;
            Console.WriteLine("num1 - num2 = " + num3);
            num3 = num5 - num4;
            Console.WriteLine("num2 - num1 = " + num3);
            num3 = num4 / num5;
            Console.WriteLine("num1 / num2 = " + num3);
            num3 = num5 / num4;
            Console.WriteLine("num2 / num1 =" + num3);
            num3 = num4 * num5;
            Console.WriteLine("num1 * num2 = " + num3);
            num3 = num4 % num5;
            Console.WriteLine("num1 % num2 = " + num3);
            num3 = num5 % num4;
            Console.WriteLine("num2 % num1 = " + num3);

            int a = 10;
            int b = 20;
            Console.WriteLine("Before SWAP : value of A =" + a + " value of B =" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After SWAP: value of A ="+ a +" " +"value of B ="+ b);

            string x = "hello";
            string y = "world";
            x = x + y;
            y = x.Substring(0, x.Length - y.Length);
            x = x.Substring(y.Length);
            Console.WriteLine("x is " + x + "  y is " + y);




        }
    }
}