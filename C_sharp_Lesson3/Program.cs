using System;

namespace C_sharp_Lesson3
{
    class Program
    {
        static int b = 5;

        public static void task1(ref int a)
        {
            a = a + 1;
            int b = 3;
            Console.WriteLine("b: " + b);
        }

        static string formatNew(Object d)
        {
            return String.Format("{0,15:F02}", d);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(5.2 % 2.1);


            int a = 3, b = 2, c = 2;
            // a = Convert.ToInt32(Console.ReadLine());
            task1(ref a);
            Console.WriteLine("a = " + a + ", b = " + b);
            task1(ref a);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            task1(ref a);
            Console.WriteLine($"a = {a}, b = {b}");
            const double d = 123.452748536589476475645678;
            a = 67;
            // d = 1.3;
            Console.WriteLine($"{d}");
            Console.WriteLine($"{formatNew(d)}");

            a = a + 1 + a + a;
            Console.WriteLine(sizeof(long));
            Console.WriteLine(typeof(int));
            Console.WriteLine(-a);


            Console.WriteLine("\nПобитовые операции");
            a = 18; // 00010010
                    // 11101101

            Console.WriteLine(a);
            Console.WriteLine(~a);
            a = a + ~a;
            Console.WriteLine(a + 1);
            a = (int)d;
            Console.WriteLine(a);



            double q = (new Random()).Next(10000);
            Console.WriteLine(q = q / 100);
            Console.WriteLine((int)(q * 10) / 10.0);


            Console.WriteLine("\nПобитовый сдвиг");
            a = 12; // 00001100
                    // 00000011
            Console.WriteLine("-15 >> 2 = " + (-15 >> 2)); // 12 / 4 = 3

            double z = 5;
            z = z + 3;  // z +=3;
            int n = 4;
            n = n << 2; // 4 * 2 * 2 = 16
            n <<= 2;    // 16 * 2 * 2 = 64
            Console.WriteLine(n);



            Console.WriteLine("\nТернарный оператор");
            bool res1 = false, res2 = false;
            int d1 = ((res1 = 112 < 120) | (res2 = 167 < 200)) ? 1 : 0;
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(d1);


            Console.WriteLine("\nУсловные операторы");
            if (c != 0 && d != 0)
            {
                z = a * b / (c * d) - (a * b - c) / (c * d);
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("No solutions");
            }

            if (c == 0 || d == 0)
            {
                Console.WriteLine("No solutions");
            }
            else
            {
                z = a * b / (c * d) - (a * b - c) / (c * d);
                Console.WriteLine(z);
            }


            Console.WriteLine(d + "  " + (d % 2 == 0 ? "Chet" : "NeChet"));


            Console.WriteLine("Если тангенс, то некомплексное решение есть не на всей числовой оси");
            double y = 12.5, x = Math.PI / 2, result = 0;
            if (Math.Cos(x) != 0)
            {
                result = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
                Console.WriteLine($"Result is: {result}");
            }
            else
            {
                Console.WriteLine("No solutions");
            }

            //if (x >= -1 && Math.Cos(12 * y - 4) != 0)
            x = 0;
            Console.WriteLine(x == 0 ? "No solutions" : "" + y / x);

            if (a > b)
                c = 5;
            else
                c = 6;

            c = a > b ? 5 : c;

            if (a > b)
                c = 5;


            a = 20;
            a >>= 2;
            Console.WriteLine("a="+a);
            /* 
// Переполнение и типы результата операций
            int b = 20;
            b *= 5;  // b = b * 5;
            Console.WriteLine(b);
            //if ((a > b) || (c > d))

            byte b1 = 1, b2 = 2, b3;
            short sh1;
            int in1;
            //b3 = b1 + b2; //ошибка: результат типа int
            b3 = (byte)(b1 + b2);
            //sh1 = b1 + b2; //ошибка: результат типа int
            sh1 = (short)(b1 + b2);
            in1 = b1 + b2 + sh1;
            Console.WriteLine("b3= " + b3 + " sh1= " + sh1 + " in1= " + in1);
            */


            Console.WriteLine("Проверка, является ли билет счастливым");
            int ticket = 924456;

            int ed = 0, de = 0, so = 0, ty = 0, dt = 0, st = 0;
            st = (ticket / 100000) % 10;
            dt = (ticket / 10000) % 10;
            ty = (ticket / 1000) % 10;
            so = (ticket / 100) % 10;
            de = (ticket / 10) % 10;
            ed = (ticket / 1) % 10;

            Console.WriteLine($"{st} {dt} {ty} {so} {de} {ed}");

            if ((st + dt + ty) == (so + de + ed))
                Console.WriteLine("Happy ticket. Eat it!");
            else
                Console.WriteLine("UnHappy ticket");



            // Проверка, является ли год високосным
            int year = 0;
            bool error = true;

            Console.WriteLine("\nВведите год: ");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            if (error == false)
            {
                if ((year % 4 != 0) || ((year % 400 != 0) && (year % 100 == 0)))
                    Console.WriteLine("Невисокосный");
                else
                    Console.WriteLine("Високосный");

                Console.WriteLine((((year % 4 != 0) || ((year % 100 == 0) && (year % 400 != 0))) ? "Нев" : "В") + "исокосный");
            }


        }
    }
}
