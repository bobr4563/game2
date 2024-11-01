using System;

namespace game2;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int score = 0;
        int attempts = 5;

        Console.WriteLine("Добро пожаловать в игру 'Рыбалка'!");
        Console.WriteLine($"У вас {attempts} попыток поймать рыбу.");

        for (int i = 0; i < attempts; i++)
        {
            Console.WriteLine($"\nПопытка {i + 1}:");
            Console.Write("Введите число от 1 до 10, чтобы закинуть удочку: ");

            if (int.TryParse(Console.ReadLine(), out int cast))
            {
                if (cast < 1 || cast > 10)
                {
                    Console.WriteLine("Пожалуйста, введите число от 1 до 10.");
                    i--; // Уменьшаем счетчик попыток
                    continue;
                }

                // Генерируем случайный результат ловли
                int fishCaught = random.Next(1, 11);

                if (cast == fishCaught)
                {
                    Console.WriteLine("Поздравляем! Вы поймали рыбу!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Вы не поймали рыбу. Рыба была на позиции {fishCaught}.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите допустимое число.");
                i--; // Уменьшаем счетчик попыток
            }
        }

        Console.WriteLine($"\nИгра окончена! Ваш счет: {score}");
    }
}
