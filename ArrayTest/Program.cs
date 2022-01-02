using System;

namespace ArrayTest
{
    class Program
    {
        public static void printArray(int[]arr)
        {
            foreach (int j in arr)
            {
                Console.Write(j);
            }
            Console.WriteLine("");
        }

        static void printArray02(int[][] arr)
        {
            foreach (int[] x in arr)
            {
                foreach (int y in x)
                {
                    Console.Write(y);
                }
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String[] array1 = new String[6];  //[length]
            array1[0] = "5";
            //You can not only declear an array.
            double[] balance;
            //It must have a size;
            int[] x = new int[999];

            string[] str = new string[] { "F","M","L"};
            int[] array2 = new int[] { 6, 7, 9, 0, 7, 5, 4, 3, 77, };
            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);
            int y = array2.Length;

            // Two-dimensional array
            int[,] t = new int[2, 3];//[x,y] 行与列
            int[,] d = new int[3, 4]
            {
                {0,1,2,3 },
                {4,5,6,7},
                { 8,9,10,11},
            };
            /*
             * Test Array
             * 
             */
            //Array.Reverse();
            int[] testArray = new int[] { 1, 3, 5, 7, 9 };
            int[][] testArray02 = new int[3][] { new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 6, 7, 8 } };
            Console.WriteLine("Before the reverse: ");
            Program.printArray(testArray);

            Array.Reverse(testArray);
            Console.WriteLine("After the reverse: ");
            Program.printArray(testArray);

            Array.Reverse(testArray02);
            Console.WriteLine("testArray02: ");
            Program.printArray02(testArray02);
            //arrayName.ToString()
            //Represents the current object.

            Console.WriteLine(testArray.ToString());
            String ass = testArray02.ToString();
            Console.WriteLine("ass: {0}",ass);
            Console.WriteLine("testArray02: {0}",testArray02.ToString());
            //Return the number of array's dimensional
            int ans = d.Rank;
            //Total numbers of elements in the array,
            //no care about the dimensional
            int len = d.Length;
            //Care about the dimensional
            int len1 = d.GetLength(1);
            foreach (int e in d)
            {
                Console.WriteLine(e);
            };

            //交错数组是数组的数组。
            //Not the human's brain
            //It's a one dimensional array!!!!!

            int[][] brain = new int[5][];
            for (int i = 0; i < brain.Length; i++)
            {
                brain[i] = new int[4];
            }
            //doggy 是一个由两个数组组成的一维数组，其中doggy[0]是一个有两个元素的数组，
            //doggy[1]是一个有四个元素的数组
            int[][] doggy = new int[2][] { new int[] {1,2 },new int[] { 3,4,5,6} };
            Console.WriteLine("Doggy:->{0}",doggy);
            //Rnadom ran.Next()
            Random ran = new Random(6);
            Random ran1 = new Random();

            for (int i =0; i<y; i++)
            {
                //Console.WriteLine("RAN: "+ran.Next());
                Console.WriteLine("RAN1: " + ran.Next(1, 6));
                Console.WriteLine("array2[{0}]={1}",i,array2[i]);
            }



            Console.ReadKey();

        }
    }
}
