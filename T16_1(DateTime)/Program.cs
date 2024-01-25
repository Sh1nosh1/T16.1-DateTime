using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16_1_DateTime_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Task 1
                //Вывести сообщение с информацией о текущей системной дате, применив несколько форматов.

                WriteLine("Текущая дата: \n");

                //Вывод текущей даты
                WriteLine(DateTime.Now);

                //Вариант 1 (Образец: 20.01.2022)
                DateTime date1 = new DateTime(2024, 01, 26);
                WriteLine(date1);

                //Вариант 2 (Образец: 20 янв 2022)
                WriteLine(date1.ToString("dd MMM yyyy"));

                //Вариант 3 (Образец: 20 января 2022 г.)
                WriteLine(date1.ToString("dd MMMM yyyy г."));

                //Вариант 4 (Образец: Чт, 20 янв 2022)
                WriteLine(date1.ToString("ddd, dd MMM yyyy"));

                //Вариант 5 (Образец: четверг, 20 января 2022)
                WriteLine(date1.ToString("dddd, dd MMMM yyyy"));

                WriteLine("\nТекущее время: \n");

                //Вариант 1 (Образец: 13:05:20)
                DateTime date2 = DateTime.Today.Add(new TimeSpan(13, 05, 20));
                WriteLine(date2.ToString("HH:mm:ss"));

                //Вариант 2 (Образец: 13:05)
                WriteLine(date2.ToString("HH:mm"));

                WriteLine("\nТекущая дата и время: \n");

                //Вариант 1 (Образец: 20.01.2022 13:05:20)
                DateTime date3 = new DateTime(2024, 01, 26).Add(new TimeSpan(13, 05, 20));
                WriteLine(date3);

                //Вариант 2 (Образец: 20 января 2022 г. 13:05)
                WriteLine(date3.ToString("dd MMMM yyyy г. HH:mm"));

                //Вариант 3 (Образец: 20 января 2022 г. 13:05:20)
                WriteLine(date3.ToString("dd MMMM yyyy г. HH:mm:ss"));

                //Вариант 4 (Образец: Thu, 20 Jan 2022 13:05:20 GMT)
                WriteLine(date3.ToString("ddd, dd MMM yyyy HH:mm:ss 'GMT'"));

                //Вариант 5 (Образец: 2022-01-20T13:05:20)
                WriteLine(date3.ToString("yyyy-MM-ddTHH:mm:ss"));

                //Task 2
                //Запросить с клавиатуры возраст человека и вывести на экран следующее сообщение: Ты родился в .... году

                Write("\nВведите Ваш возраст: ");
                sbyte age = Convert.ToSByte(ReadLine());
                DateTime date = DateTime.Now.AddYears(-age);
                WriteLine(date.ToString("Вы родились в yyyy году"));

                //Task 3
                //Определить возраст человека

                Write("\nВведите год Вашего рождения: ");
                int year = Convert.ToInt32(ReadLine());
                DateTime date_1 = DateTime.Now.AddYears(-year);
                WriteLine(date_1.ToString("Ваш возраст yy лет"));

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
