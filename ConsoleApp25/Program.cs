namespace ConsoleApp25
{
    using System;

    delegate string GetNextDay();

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр делегата с использованием лямбда-выражения
            GetNextDay getNextDay = () =>
            {
                DateTime today = DateTime.Today;
                DateTime nextDay = today.AddDays(1);
                return nextDay.DayOfWeek.ToString();
            };

            // Первый вызов делегата
            Console.WriteLine("Сегодня: " + DateTime.Today.DayOfWeek);
            Console.WriteLine("Завтра: " + getNextDay());

            // Последующие вызовы делегата
            Console.WriteLine("Послезавтра: " + getNextDay());
            Console.WriteLine("Через три дня: " + getNextDay());
            Console.ReadLine();
        }
    }

}