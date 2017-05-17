using System;

namespace refrtgrt
{
    class MainClass
    {
        public static void create(int[,] array,int n){
            Random a = new Random();
            for (int i = 0; i < n;i++){
                for (int j = 0; j < n;j++){
                    array[i, j] = a.Next(0, 9);
                }
            }
        }
        public static void print(int[,] array, int n)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
                    Console.Write(array[i, j] + " ");
				}
                Console.WriteLine();
			}
		}
		public static int count(int[,] array, int n)
		{
            int summ = 0;
			for (int i = 1; i < n; i+=2)
			{
				for (int j = 0; j < n; j++)
				{
                    summ += array[j, i];
				}
				Console.WriteLine();
			}
            return summ;
		}
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            create(array,n);
            print(array,n);
            Console.WriteLine(count(array,n));
        }
    }
}
