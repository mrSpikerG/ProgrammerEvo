using System;

namespace ProgrammerEvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            int check;
            do
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1 - Игры");
                Console.WriteLine("2 - Мобильные приложения");
                Console.WriteLine("3 - Компьютерные приложения");
                Console.WriteLine("4 - Сайты");
                Console.WriteLine("0 - Выход");

                Console.Write("Ваш выбор: ");
                check = int.Parse(Console.ReadLine());

                if (check != 0)
                {
                    Console.Clear();
                    menu.printInfo(check);

                }
            } while (check != 0);
        }
    }
}
