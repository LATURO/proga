using System;

namespace refrtgrt
{
    class MainClass
    {
        public static void create(int[,] array, int n, int k)
        {
            Random a = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    array[i, j] = a.Next(0, 9);
                }
            }
        }
        public static void print(int[,] array, int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static bool proc(int n){//проверка числа на простоту
            bool flag = true;
            for (int i = 2; i < n;i++){
                if(n%i==0){
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static void check(int[,] array, int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(array[i,j]+" ");
                    bool ch = proc(array[i,j]);
                    if(ch==true){
                        Console.Write("- простое ");
                    }
                    else{
                        Console.Write("- не простое ");
                    }
                }
                Console.WriteLine();
            }

        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[,] array = new int[n, k];
            create(array, n, k);
            print(array, n, k);
            check(array, n, k);
        }
    }
}
