using System;

namespace jfjff
{
    class People{
        private string name;
        private int passport;
        private string hotel;
        private int days;
        static readonly Random a = new Random();
        public People(){
            this.passport = a.Next(100000, 999999);
            this.name = getname();
            this.days = a.Next(1, 100);
            this.hotel = gethotel();
        }
		public string getname()
		{
			return "Иванов Смирнов Кузнецов Попов Васильев Петров Соколов Михайлов Новиков Федоров Морозов Волков Алексеев Лебедев Семенов Егоров Павлов Козлов Степанов Николаев Орлов Андреев Макаров Никитин Захаров Зайцев Соловьев Борисов Яковлев Григорьев Романов Воробьев Сергеев Кузьмин Фролов Александров Дмитриев Королев Гусев Киселев Ильин Максимов Поляков Сорокин Виноградов Ковалев Белов Медведев Антонов Тарасов".Split(' ')[a.Next(0, 49)];
		}
        public string gethotel()//поменяй названия на отели
        {
            return "Иванов Смирнов Кузнецов Попов Васильев Петров Соколов Михайлов Новиков Федоров Морозов Волков Алексеев Лебедев Семенов Егоров Павлов Козлов Степанов Николаев Орлов Андреев Макаров Никитин Захаров Зайцев Соловьев Борисов Яковлев Григорьев Романов Воробьев Сергеев Кузьмин Фролов Александров Дмитриев Королев Гусев Киселев Ильин Максимов Поляков Сорокин Виноградов Ковалев Белов Медведев Антонов Тарасов".Split(' ')[a.Next(0, 49)];
        }
    }
    class MainClass
    {
        
        public static void Main(string[] args)
        {
        }
    }
}