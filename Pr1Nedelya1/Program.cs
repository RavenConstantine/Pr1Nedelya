using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1Nedelya1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int exchange = 10;
            int gold = 0;
            int crystal = 0;
            int NewCr = 0;

            Console.WriteLine("Вы подходите к подозрительному торговцу. Он предлагает вам кристалы по выгодному курсу: "+exchange);
            do
            {
                Console.Write("Перед тем как заести разговор вы проверете свой кошелек. Там вы видете несколько золотых монет, а именно: ");
                string str = Console.ReadLine();
                int.TryParse(str, out gold);
            }
            while (gold <= 0);
            do
            {
                Console.Write("Подойдя поближе, вы неуверенно произносите.\n-Я хотел бы приобрести кристалы. Мне должно хватить на ");
                string str = Console.ReadLine();
                int.TryParse(str, out NewCr);
            }
            while (NewCr <= 0);
            while (gold> NewCr * exchange)
            {
                gold -= NewCr * exchange;
                crystal = NewCr;
                Console.WriteLine("Торговец берет ваши деньги, пересчитав, он сует вам " + crystal + " кристалов");
                break;
            }
            Console.WriteLine("Посмотрев на вас, торговец уходит быстрым шагом. После чего вы проверяете свои финансы");
            Console.WriteLine("Кристалов: "+crystal+"\nЗолота: "+gold);
            Console.ReadLine();
        }
    }
}
