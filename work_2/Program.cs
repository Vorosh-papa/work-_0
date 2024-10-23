using System;
using System.Threading.Channels;


namespace work_2
{
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

                int level = input.inputNum();
             
                Random random = new Random();
                int randomNumber = 0;

                int a_try = 0;

                int range = 0;

                switch (level)
                {
                    case 1:
                        randomNumber = random.Next(1, 100);
                        Console.WriteLine("Выбран уровень 1. Загадано число от 1 до 100, отгадайте!");
                        range = 100;
                        break;
                    case 2:
                        randomNumber = random.Next(1, 1000);
                        Console.WriteLine("Выбран уровень 2. Загадано число от 1 до 1000, отгадайте!");
                        range = 1000;
                        break;
                    case 3:
                        randomNumber = random.Next(1, 10000);
                        Console.WriteLine("Выбран уровень 3. Загадано число от 1 до 10000, отгадайте!");
                        range = 10000;
                        break;
                }

                while (true)
                {
                    a_try++;
                    string answer;
                    string temp_answer = "отсутсвует";
                    string deviation;
                    int number = input.inputNum();
                    int difference = Math.Abs(number - randomNumber);
                    int temp_difference = 0;
                    if (number == randomNumber)
                    {
                        Console.WriteLine($"Вы угадали с {a_try} попытки, загаданное число - {randomNumber}!");
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
                            Console.WriteLine(deviation);
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