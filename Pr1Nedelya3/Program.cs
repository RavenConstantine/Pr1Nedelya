using System;

namespace Pr1Nedelya3
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Жизнь - тлен";
            string password = "Жизнь - боль";

            Console.WriteLine("На скамье, в тени сидит человек. Вы подходите к нему и говорите:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Пароль (" + (i + 1) + "/3): ");
                string str = Console.ReadLine();
                if (str == password)
                {
                    Console.WriteLine("Отзыв: " + message);
                    Console.ReadLine();
                    break;
                }
                else if (i==2)
                    Console.WriteLine("Вас раскрыли. Резким ударом меча человек со скамьи отделяет вашу голову от тела.\nВремя смерти: "+ DateTime.Now.ToString());
            }
        }
    }
}
