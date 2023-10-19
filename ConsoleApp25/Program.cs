namespace ConsoleApp25
{
    using System;

    delegate Person GetNextDay(int i);

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр делегата с использованием лямбда-выражения
            GetNextDay getNextDay = (int i) =>
            {

               Person person = new Person() { Id = i };

                do    
                {
                    DateTime     today = DateTime.Today;
                    DateTime nextDay = today.AddDays(i);
                  
                    Console.WriteLine(nextDay.DayOfWeek.ToString());
                    i++;
                } while (i <= 7);
               
                return person;
            };

            int i = 1;
           var d =          getNextDay(i);
       
        
            Console.ReadLine();
        }
    }

}