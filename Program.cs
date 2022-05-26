using System;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя первого игрока");
            string player1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите имя второго игрока");
            string player2 = Console.ReadLine();
            Console.WriteLine();

            Random random = new Random();

            int randomNumber = random.Next(12, 120);

            Console.WriteLine($"Число {randomNumber}, ваша цель добраться до 0 используя 1, 2, 3 или 4");

            int player1Number = 0;
            int player2Number = 0;

            while (randomNumber != 0)
            {
                Console.WriteLine($"Ход игрока {player1}");
                player1Number = int.Parse(Console.ReadLine());
                if (player1Number < 0 || player1Number > 5)
                {
                    Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку");
                    continue;
                }
                randomNumber = randomNumber - player1Number;
                Console.WriteLine();
                Console.WriteLine($"Остаток = {randomNumber}");
                if (randomNumber == 0)
                {
                    Console.WriteLine($"Поздравляем {player1} с победой. {player2} может реванш?");
                    break;
                }

                Console.WriteLine($"Ход игрока {player2}");
                player2Number = int.Parse(Console.ReadLine());
                if (player2Number < 0 || player2Number > 5)
                {
                    Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку");
                    continue;
                }
                randomNumber = randomNumber - player2Number;
                Console.WriteLine();
                Console.WriteLine($"Остаток = {randomNumber}");
                if (randomNumber == 0)
                {
                    Console.WriteLine($"Поздравляем {player2} с победой. {player1} может реванш?");
                    break;
                }

            }

        }
    }
}
