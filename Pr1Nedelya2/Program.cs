using System;

namespace Pr1Nedelya2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text="";
            bool stay = true;

            Console.WriteLine("Прежде чем уснуть, вы садитесь за стол и открываете свой походный дневник, чтобы написать пару строк");
            while (stay)
            {
                Console.WriteLine("(Напиште что угодно. Для завершения введите только слово \"exit\")");
                string str = Console.ReadLine();
                if (str == "exit")
                    stay = false;//Завершение ввода
                else
                    text += str + "\n";
                Console.Clear();
            }
            Console.WriteLine("Вы перчитываете написанное:\n\n" + text);
            Console.ReadLine();
        }
    }
}
