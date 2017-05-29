using System;

namespace jfjff
{
    class MainClass
    {
        public static int chet(int a){
            int c = 0;
            for (int i = 1; i <= a;i++){
                if(a%i==0){
                    c++;
                }
            }
            return c;
        }
        public static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            Console.Write(chet(a));
        }
    }
}
