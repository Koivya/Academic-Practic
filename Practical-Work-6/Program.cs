using System;
using System.IO;
using System.Text;

namespace PracticalWork6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*//Задание №1
            string path = "numsTask1.txt";
            try
            {
                string textFromFile;
                using (StreamReader reader = new StreamReader(path))
                {
                    textFromFile = reader.ReadToEnd();
                    Console.WriteLine("Текст из файла: \n{0}", textFromFile);
                }

                char[] separators = { ' ', ',', '.', '?', '!', ':', ';', '-', '\t' };
                string[] words = textFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("\nСлова из текста нечётной длины:");
                foreach (string word in words)
                {
                    if (word.Length % 2 != 0)
                    {
                        Console.Write(word + ", ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*//Задание №2
            string path = "numsTask2.txt";
            try
            {
                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    char[] separators = { ' ', ',', '.', '!', '?', '\n', '\t', '\r' };
                    string[] wordsFromFile =
                        reader.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    string text = string.Join(" ", wordsFromFile);
                    Console.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*//Задание №3
            try
            {
                Console.Write("Введите число: ");
                int number = 0;
                if (int.TryParse(Console.ReadLine(), out int parsedNumber))
                {
                    number = parsedNumber;
                }

                if (number % 2 == 0 && number % 10 == 0)
                {
                    Console.WriteLine("Число чётное и кратное 10");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Число чётное, но не кратное 10");
                }
                else if (number % 10 == 0)
                {
                    Console.WriteLine("Число не чётное, но кратное 10");
                }
                else
                {
                    Console.WriteLine("Число не чётное и не кратное 10");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*//Задание №4 (длинный вариант)
            try
            {
                Console.Write("Введите положительное число a: ");
                if (uint.TryParse(Console.ReadLine(), out uint a))
                {
                    if (a != 0)
                    {
                        uint sum = 0;

                        bool isPositive = true;
                        while (isPositive)
                        {
                            Console.Write("\nВведите число (чтобы закончить, введите отрицательное число): ");
                            if (uint.TryParse(Console.ReadLine(), out uint parsedNumber))
                            {
                                if (parsedNumber % a == 0)
                                {
                                    sum += parsedNumber;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nНекорректный ввод или введённое число отрицательное.");
                                Console.WriteLine("Итоговая сумма чисел, делящихся на число a нацело: " + sum);
                                isPositive = false;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введённое число a равно нулю.");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод или введённое число a отрицательное.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*//Задание №4
            try
            {
                Console.Write("Введите положительное число a: ");
                uint a = Convert.ToUInt32(Console.ReadLine());

                uint sum = 0;
                while (true)
                {
                    Console.Write("Введите положительное число (чтобы завершить, введите отрицательное число): ");
                    uint number = Convert.ToUInt32(Console.ReadLine());

                    if (number % a == 0)
                    {
                        sum += number;

                        if (sum > number)
                        {
                            Console.WriteLine("\nСумма чисел, делящихся на число a нацело: " + sum + "\n");
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка. Введён некорректный формат.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nЗавершение программы Введено отрицательное число.");
            }*/

            /*//Задание №5
            try
            {
                Console.Write("Введите количество строк в массиве: ");
                short n = Convert.ToInt16(Console.ReadLine());

                Console.Write("Введите количество столбцов в массиве: ");
                short m = Convert.ToInt16(Console.ReadLine());

                int[,] a = new int[n, m];

                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[i, j] = random.Next(0, 2);
                    }
                }

                Console.WriteLine("\nИсходный массив:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0, 3}", a[i, j]);
                    }

                    Console.WriteLine();
                }

                int[,] newMatrix = new int[n, m + 1];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        newMatrix[i, j] = a[i, j];
                    }
                }

                int[] newColumn = new int[n];

                for (int i = 0; i < n; i++)
                {
                    int count = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (a[i, j] == 1)
                        {
                            count++;
                        }
                    }

                    if (count % 2 == 0)
                    {
                        newColumn[i] = 0;
                    }
                    else
                    {
                        newColumn[i] = 1;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    newMatrix[i, m] = newColumn[i];
                }

                Console.WriteLine("\nМассив с новым столбцом:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m + 1; j++)
                    {
                        Console.Write("{0, 3}", newMatrix[i, j]);
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*//Задание №6
            try
            {
                Random random = new Random();

                int numberOfNumbers = random.Next(1, 50);
                float[] numbers = new float[numberOfNumbers];

                int positiveCount = 0;
                int negativeCount = 0;

                Console.WriteLine("Массив дробных чисел:");
                for (int i = 0; i < numberOfNumbers; i++)
                {
                    numbers[i] = (float)Math.Round(random.NextDouble() * (1 - -1) + -1, 2);
                    if (numbers[i] > 0)
                    {
                        positiveCount++;
                    }
                    else
                    {
                        negativeCount++;
                    }

                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine();

                float[] positiveNumbers = new float[positiveCount];
                float[] negativeNumbers = new float[negativeCount];

                int countP = 0;
                int countN = 0;
                for (int i = 0; i < numberOfNumbers; i++)
                {
                    if (numbers[i] > 0)
                    {
                        positiveNumbers[countP] = numbers[i];
                        countP++;
                    }
                    else
                    {
                        negativeNumbers[countN] = numbers[i];
                        countN++;
                    }
                }

                Console.WriteLine("\nМассив положительных чисел:");
                foreach (float number in positiveNumbers)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();

                Console.WriteLine("\nМассив отрицательных чисел:");
                foreach (float number in negativeNumbers)
                {
                    Console.Write(number + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}