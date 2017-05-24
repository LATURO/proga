using System;

namespace jfjff
{
    class MainClass
    {
        class destionation{
            private int number;
            public static Random a = new Random();
            private string[] travel = new string[3];
            public destionation(){
                this.number = a.Next(1, 9999);
                this.travel[0] = "11";//сделаешь список с рандомом
                this.travel[1] = "11";
                this.travel[2] = "11";
            }
            public void add(int number,string[] travel){
                this.number = number;
                this.travel[0] =travel[0];
                this.travel[1] =travel[1];
                this.travel[2] = travel[2];
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}
