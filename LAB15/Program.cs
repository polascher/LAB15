using System;

namespace LAB15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool A=true;
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i=2; i<=a/2; i++)
            {
                if (a%i==0)
                {
                    A=false;
                    break;
                }
            }
            if (A)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не является простым, введите другое");
                return;
            }

            for (int i=2; i<=a; i++)
            {
                bool B=true;
                for (int j=2; j<=i/2; j++)
                    if (i%j==0)
                    {
                        B=false;
                        break;
                    }
                if (B) Console.WriteLine(i);
            }
        }
    }
}
