using System;
using System.Threading.Channels;


namespace lesson2
{
    class input
    {
        public static int inputNum()
        {
            int intNum;
            while (true)
            {
                string stringNum = Console.ReadLine();

                if (int.TryParse(stringNum, out intNum))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Вы ввели не число, попробуйте снова");
                }
            }
            return intNum;
        }
        public static bool inputBool()
        {
            bool b;
            while (true)
            {
                string q = Console.ReadLine();
                if (q == "1")
                {
                    b = true;
                    break;
                }
                else if (q == "0")
                {
                    b = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите 1 или 0");
                }
            }
            return b;
        }

    }
    class lesson2
    {

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Это игра Угадай число");
                Console.WriteLine("Для начала выберите уровень сложности");
                Console.WriteLine("1 - от 1 до 10");
                Console.WriteLine("2 - от 1 до 100");
                Console.WriteLine("3 - от 1 до 1000");

                int difficulty = input.inputNum();

                Console.WriteLine("Хотите ли вы получать подсказки (больше/меньше) при угадовании числа? Если да введите - 1, если не - 0");
                bool help = input.inputBool();

                Random random = new Random();
                int randomNumber = 0;

                int attemp = 0;

                switch (difficulty)
                {
                    case 1:
                        randomNumber = random.Next(1, 10);
                        Console.WriteLine("Вы выбрали уровень сложности 1. Отгадайте число от 1 до 10. Давайте начнем!");
                        break;
                    case 2:
                        randomNumber = random.Next(1, 100);
                        Console.WriteLine("Вы выбрали уровень сложности 2. Отгадайте число от 1 до 100. Давайте начнем!");
                        break;
                    case 3:
                        randomNumber = random.Next(1, 1000);
                        Console.WriteLine("Вы выбрали уровень сложности 3. Отгадайте число от 1 до 1000. Давайте начнем!");
                        break;
                }

                while (true)
                {
                    attemp++;
                    string h;
                    int num = input.inputNum();
                    if (num == randomNumber)
                    {
                        Console.WriteLine($"Вы угадали, было загаданно число {randomNumber}! Число попыток -  {attemp}");
                        break;
                    }
                    else if (help)
                    {
                        if (randomNumber > num)
                        {
                            h = "Больще";
                        }
                        else
                        {
                            h = "Меньше";
                        }

                        Console.WriteLine($"Вы не угадали, загаданное число {h} {num}");
                    }
                    else
                    {
                        Console.WriteLine("Вы не угадали, попробуйте еще");
                    }

                }
                Console.WriteLine("Если хотите выйти из игры введите 1, если хотите сыграть еще раз введите любой другой символл");
                if ("1" == Console.ReadLine())
                {
                    break;
                }
            }
        }
    }
}
