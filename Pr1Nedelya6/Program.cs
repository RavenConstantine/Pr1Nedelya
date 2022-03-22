using System;

namespace Pr1Nedelya6
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Journal[] fullNames = new Journal [100];
            string[] posts = new string [100];
            char action = ' ';
            int count = 0;

            while (action != '5')
            {
                Console.Clear();
                Console.WriteLine("Журнал:\n" +
                    "1 - добвить запись\n" +
                    "2 - удалить запись\n" +
                    "3 - вывести все записи\n" +
                    "4 - поиcк по фамилии\n" +
                    "5 - закрыть журнал\n");
                action = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (action)
                {
                    case '1':
                        AddRecording(fullNames, posts, &count);
                        break;
                    case '2':
                        RemoveRecordings(fullNames, posts, &count);
                        break;
                    case '3':
                        ShowRecordings(fullNames, posts, &count);
                        break;
                    case '4':
                        SearchRecordings(fullNames, posts, &count);
                        break;
                    case '5':
                        Console.WriteLine("Журнал был закрыт");
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static unsafe void AddRecording(Journal[] fullNames, string[] posts, int *count)
        {
            string firstName;
            string lastName;
            string patronymic;
            string post;
            do
            {
                Console.WriteLine("Введите фамилию: ");
                lastName = Console.ReadLine();
                Console.Write("Введите имя: ");
                firstName = Console.ReadLine();
                Console.Write("Введите отчество: ");
                patronymic = Console.ReadLine();
                Console.Write("Введите должность: ");
                post = Console.ReadLine();
            } while (string.IsNullOrEmpty(firstName)||string.IsNullOrEmpty(lastName) ||string.IsNullOrEmpty(patronymic) ||string.IsNullOrEmpty(post));
                var newJournal = new Journal(lastName, firstName, patronymic);
                fullNames[*count] = (newJournal);
                posts[*count] = (post);
                *count=*count+1;
            Console.ReadKey();
        }
        static unsafe void RemoveRecordings(Journal[] fullNames, string[] posts, int *count)
        {
            if (*count > 0)
            {
                Console.Write("Ведите номрер записи для удаления: ");
                string dossierNum = Console.ReadLine();
                if (int.TryParse(dossierNum, out int i))
                {
                    if ((i < *count + 1) && (i > 0))
                    {
                        for (int j = i - 1; j < *count; j++)
                        {
                            fullNames[j] = fullNames[j + 1];
                            posts[j] = posts[j + 1];
                        }
                        fullNames[*count] = new Journal();
                        posts[*count] = "";
                        *count=*count-1;
                    }
                    else
                        Console.WriteLine("Запись с таким номером отсутствует");
                }
                else
                    Console.WriteLine("Введено неверное значение");
            }
            else
                Console.WriteLine("Отсутствуют какие-либо записи");
            Console.ReadKey();
        }
        static unsafe void ShowRecordings(Journal[] fullNames, string[] posts, int *count)
        {
            if (*count > 0)
                for (int i = 0; i < *count; i++)
                    Console.WriteLine($"{i + 1}. {fullNames[i].ShowData()} - {posts[i]}");
            else
                Console.WriteLine("Отсутствуют какие-либо записи");
            Console.ReadKey();
        }
        static unsafe void SearchRecordings(Journal[] fullNames, string[] posts, int *count)
        {
            if (*count > 0)
            {
                Console.Write("Ведите фамилию для поиска: ");
                string nameToSearch = Console.ReadLine();

                int quant = 0;
                for (int i = 0; i < *count; i++)
                {
                    if (fullNames[i].TakeLName() == nameToSearch)
                    {
                        quant++;
                        Console.WriteLine($"{quant}.     {fullNames[i].ShowData()} - {posts[i]}");
                    }
                }
                if (quant == 0)
                    Console.WriteLine("Никого с фамилией " + nameToSearch + " нет");
                else
                    Console.WriteLine("Количество записи с фамилией " + nameToSearch + " - " + quant);
            }
            else
                Console.WriteLine("Отсутствуют какие-либо записи");
            Console.ReadKey();
        }
    }
}
