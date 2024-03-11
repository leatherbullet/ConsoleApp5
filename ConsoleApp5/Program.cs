using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeArray;
            
            string userIput;
            
            Console.Write("введите размер массива: ");
            sizeArray = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write($"введите {i + 1} число: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool canCycleWork = true;

            while (canCycleWork)
            { 
                Console.Clear();
                Console.Write("введенные числа: ");

                for (int i = 0;i < numbers.Length;i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine("\nузнать сумму всех чисел введите: sum");
                Console.WriteLine("для выхода введите: exit");
                userIput = Console.ReadLine();

                if (userIput == "sum")
                {
                    int sum = 0;
                    
                    for (int i = 0; i < numbers.Length;i++)
                    {
                        sum += numbers[i];
                    }
                    
                    Console.WriteLine("сумма массива: " + sum);
                    Console.ReadKey();
                }
                else if (userIput == "exit")
                {
                    canCycleWork = false;
                }
                else 
                {
                    int[] tempUserInput = new int [numbers.Length + 1];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        tempUserInput[i] = numbers[i];
                    }

                    tempUserInput[tempUserInput.Length - 1 ] = Convert.ToInt32(userIput);
                    numbers = tempUserInput;
                }
            }
        }
    }
}
