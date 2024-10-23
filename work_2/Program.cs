using System;
using System.Threading.Channels;


namespace work_2
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
                    Console.WriteLine("error! Это не целое число, введите целое число");
                }
            }
            return intNum;
        }
        public static int inputLevel()
        {
            int intLevel;
            while (true)
            {
                string stringLevel = Console.ReadLine();

                if(int.TryParse(stringLevel, out intLevel))
                {
                    if (intLevel<4 & intLevel>0 )
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("error! Это не число не подходит, введите целое число от 1 до 3");
                    }

                }
                else 
                {
                    Console.WriteLine("error! Это не целое число, введите целое число");
                }
            }
            return intLevel;
        }
    }
    class work_2
    {

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Выберите уровень");
                Console.WriteLine("1 - от 1 до 100");
                Console.WriteLine("2 - от 1 до 1000");
                Console.WriteLine("3 - от 1 до 10000");

                int level = input.inputLevel();
             
                Random random = new Random();
                int randomNumber = 0;

                int a_try = 0;

                int range = 0;

                switch (level)
                {
                    case 1:
                        randomNumber = random.Next(1, 101);
                        Console.WriteLine("Выбран уровень 1. Загадано число от 1 до 100, отгадайте!");
                        range = 100;
                        break;
                    case 2:
                        randomNumber = random.Next(1, 1001);
                        Console.WriteLine("Выбран уровень 2. Загадано число от 1 до 1000, отгадайте!");
                        range = 1000;
                        break;
                    case 3:
                        randomNumber = random.Next(1, 10001);
                        Console.WriteLine("Выбран уровень 3. Загадано число от 1 до 10000, отгадайте!");
                        range = 10000;
                        break;
                }
                string temp_answer = "отсутсвует";
                int temp_difference = 0;
                while (true)
                {
                    a_try++;
                    string answer;
                    string deviation;
                    int number = input.inputNum();
                    int difference = Math.Abs(number - randomNumber);
                    if (number == randomNumber)
                    {
                        Console.WriteLine($"Вы угадали с {a_try}-ой попытки, загаданное число - {randomNumber}!");
                        break;
                    }
                    else
                    {
                        if (difference > 0.7 * range)
                        {
                            answer = "бррр, Антарктида";
                        }
                        else if (difference > 0.4 * range)
                        {
                            answer = "мороз";
                        }
                        else if (difference > 0.2 * range)
                        {
                            answer = "холодно";
                        }
                        else if (difference > 0.1 * range)
                        {
                            answer = "тепло";
                        }
                        else if (difference > 0.05 * range)
                        {
                            answer = "горячо";
                        }
                        else
                        {
                            answer = "уфф, кипяток";
                        }

                        if (answer == temp_answer)
                        {
                            if (difference > temp_difference)
                            {
                                deviation = "холоднее";
                            }
                            else if (difference < temp_difference)
                            {
                                deviation = "теплее";
                            }
                            else
                            {
                                deviation = "всё, как прежде";
                            }
                            Console.WriteLine($"{answer}, но {deviation}");
                        }
                        else
                        {
                            Console.WriteLine(answer);
                        }
                       
                        temp_answer = answer;
                        temp_difference = difference;
                    }
                }   
                Console.WriteLine("Если хотите остановить игру, введите no. Если хотите продолжить, введите любой другой символл");
                if ("no" == Console.ReadLine())
                {
                    break;
                }
            }
        }
    }
}