using System;

namespace jfjff
{
	class Players{
        public string name;
        private int res1, res2, res3;
        public static readonly Random a=new Random();
        public static readonly Random rand= new Random();
		public string getname()
		{
			return "Иванов Смирнов Кузнецов Попов Васильев Петров Соколов Михайлов Новиков Федоров Морозов Волков Алексеев Лебедев Семенов Егоров Павлов Козлов Степанов Николаев Орлов Андреев Макаров Никитин Захаров Зайцев Соловьев Борисов Яковлев Григорьев Романов Воробьев Сергеев Кузьмин Фролов Александров Дмитриев Королев Гусев Киселев Ильин Максимов Поляков Сорокин Виноградов Ковалев Белов Медведев Антонов Тарасов".Split(' ')[rand.Next(0, 49)];
		}
        public Players(){
            this.res1 = a.Next(0, 100);
            this.res2 = a.Next(0, 100);
            this.res3 = a.Next(0, 100);
            name = getname();
        }
        public int best(int a,int b,int c){
            b = Math.Max(b, c);
            b = Math.Max(a, b);
            return b;
        }
        public void print(){
            Console.WriteLine("Фамилия "+name+" лучший результат "+best(res1,res2,res3));
        }
	}
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Players[] array = new Players[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = new Players();
                array[i].print();
            }

        }
    }
}
