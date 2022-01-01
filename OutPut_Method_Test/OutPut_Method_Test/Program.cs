using System;

namespace OutPut_Method_Test
{
    class Program
    {
        public  static void Test01(int x, out int y, out int z)
        {
            y = 2 * x;
            z = 3 * x;
        }
        public  void Test02( int x, ref int y, ref int z)
        {
            y = 10 * x;
            z = -2 * x;
        }
        static void Main(string[] args)
        {
            Program t = new Program();
            int a ;
            int b ;

            int x = 7;
            int y ;


            Program.Test01(3, out a, out b);
            // out 关键字之后的参数不需要实际值。//相当于两个出口，
            // ref 关键字之后的参数需要实际值。
            //对于没有static关键字的method需要先实例化再调用。
            t.Test02(3, ref x, ref y);
            Console.WriteLine("Hello");

            for (int i = 0; i < 10;)
            {
                Console.WriteLine("KILL YOURSELF");
            }
            Console.WriteLine("Hello World!");

        }
    }
}
