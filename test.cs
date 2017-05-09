using System;
using System.Linq;
using System.Collections;
using System.Text;
namespace homework
{
	class MainClass
	{
        public class Gas{
            protected string second_name;
            protected int tariff;
            private int all_habits;
			public string getname()
			{
                Random rand = new Random();
				return "Иванов Смирнов Кузнецов Попов Васильев Петров Соколов Михайлов Новиков Федоров Морозов Волков Алексеев Лебедев Семенов Егоров Павлов Козлов Степанов Николаев Орлов Андреев Макаров Никитин Захаров Зайцев Соловьев Борисов Яковлев Григорьев Романов Воробьев Сергеев Кузьмин Фролов Александров Дмитриев Королев Гусев Киселев Ильин Максимов Поляков Сорокин Виноградов Ковалев Белов Медведев Антонов Тарасов".Split(' ')[rand.Next(0, 49)];
			}
            public int gettariff(){
                Random a=new Random();
                return a.Next(0, 1000);
            }
            public Gas(){
                this.second_name = getname();
                this.tariff = gettariff();
                this.all_habits = gettariff();
            }
            private int calculate(){
                return this.tariff * this.all_habits;
            }
            public string name(){
                return this.second_name;
            }
			public int tarr()
			{
                return this.tariff;
			}
			public int habits()
			{
                return this.all_habits;
			}
			public void habitsset(int value){
                this.all_habits = value;
			}
        }
        public class Electro:Gas{
            private int middle_consumption;
            private int fixed_consumption;
            public Electro(){
                this.second_name = getname();
                this.tariff = gettariff();
                this.fixed_consumption = gettariff();
                this.middle_consumption = gettariff();
            }
			public int calculate()
			{
                return (this.middle_consumption - this.fixed_consumption)/2*this.tariff;
			}
        }
        public class Request{
            public void printGas(Gas[] array){
                for (int i = 0; i < array.Length;i++){
                    Console.WriteLine(" Фамилия " + array[i].name()+" тариф "+array[i].tarr()+" количество жителей "+ array[i].habits());
                }
            }
            public void printElectro(Electro[] array)
			{
				for (int i = 0; i < array.Length; i++)
				{
					Console.WriteLine("№ " + (i + 1) + " Фамилия " + array[i].name() + " тариф " + array[i].tarr()+" ");
				}
			}
        }
        public static void Main(string[] args)
        {
            Gas a=new Gas();
            Console.WriteLine(a.name());
        }
	}
}
