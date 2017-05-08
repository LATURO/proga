using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace homework
{
	class MainClass
	{
        public class Gas{
            protected string second_name;
            protected int tariff;
            private int all_habits;
            public Gas(string second_name, int tariff){
                this.second_name = second_name;
                this.tariff = tariff;
 
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
            public Electro(string second_name, int tariff, int middle_consumption, int fixed_consumption):base(second_name,tariff){
                this.second_name = second_name;
                this.tariff = tariff;
                this.fixed_consumption = fixed_consumption;
                this.middle_consumption = middle_consumption;
            }
        }
        public class Request{
            public void printGas(Gas[] array){
                for (int i = 0; i < array.Length;i++){
                    Console.WriteLine("№ " + (i + 1) + " Фамилия " + array[i].name()+" тариф "+array[i].tarr()+" количество жителей "+ array[i].habits());
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
		public static void Main(string[] args){
            
		}
	}
}
