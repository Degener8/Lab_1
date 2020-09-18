using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string day, month, year, name;
            DateTime now = DateTime.Today;
            int cyear = now.Year;
            int cmonth = now.Month;
            int cday = now.Day;
            int bday, bmonth, byear, age, i=0;

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            do
            {
                if(i>0)
                { Console.WriteLine("Некорректная дата. Попробуйте ещё раз."); }
                
                ++i;
                do
                {
                    Console.Write("Введите день своего рождения: ");
                    day = Console.ReadLine();
                    bday = int.Parse(day);
                }
                while (bday<1 || bday>31);

                do
                {
                    Console.Write("Введите месяц вашего рождения: ");
                    month = Console.ReadLine();
                    bmonth = int.Parse(month);
                }
                while (bmonth<1 || bmonth>12);

                do
                {
                    Console.Write("Введите год вашего рождения: ");
                    year = Console.ReadLine();
                    byear = int.Parse(year);
                }
                while (byear < cyear-122 || byear > cyear-3);
            }
            while ((bmonth == 2 && bday>29 && byear%4==0) || (bmonth == 2 && bday > 28 && byear%4 != 0 ) || ((bmonth == 4 || bmonth == 6 || bmonth == 9 || bmonth == 11) && bday>30) || (byear%100==0 && byear%400 != 0 && bday>28 && bmonth==2));

            age = cyear - byear;
            if (bmonth > cmonth || (cmonth == bmonth && bday > cday))
                age--;

            Console.WriteLine($"Привет, {name}. Ваш возраст равен {age} лет. Приятно познакомиться.");
        }
    }
}
