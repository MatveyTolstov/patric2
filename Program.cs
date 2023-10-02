namespace Пракитическая_работа_2
{
    internal class Program
    {

        static void Main()
        {
            Destviya();
        }
        static void Ugaday()
        {


            Random rnd = new Random();
            int mychislo;
            int chislo = rnd.Next(101);
            Console.WriteLine("Привет!Попробуй отгадать число)");
            while (true)
            {
                mychislo = Convert.ToInt32(Console.ReadLine());
                if (mychislo < chislo)
                {
                    Console.WriteLine("Бери больше");
                }
                else if (mychislo > chislo)
                {
                    Console.WriteLine("Бери меньше");
                }
                else if (mychislo == chislo)
                {
                    Console.WriteLine("Красавец,ты уагадал");
                    break;
                }
            }
        }

        static void Tabl()
        {
            int[,] tab = new int[10, 10];
            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(i * j + "\t");
                }
            }

            Console.WriteLine();
        }

        static void Del()
        {
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            int del = 0;
            while (y <= x)
            {
                y++;
                if (chislo % del == 0)
                {
                    Console.Write(y + "\t");
                }

            }
            Console.WriteLine();
        }

        static void Destviya()
        {
            while (true)
            {
                Console.WriteLine("1) Игра угадай число");
                Console.WriteLine("2) Таблица умножения");
                Console.WriteLine("3) Найти делители числа");
                Console.WriteLine("4) Выйти из программы");
                Console.WriteLine("Введите действие: ");
                int dest = Convert.ToInt32(Console.ReadLine());
                if (dest == 1)
                {
                    Ugaday();
                }
                else if (dest == 2)
                {
                    Tabl();
                }
                else if (dest == 3)
                {
                    Del();
                }
                else if (dest == 4)
                {
                    break;
                }
            }
        }

    }
}
    

























                
