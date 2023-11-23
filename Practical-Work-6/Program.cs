using System.Text;

namespace Practical_Work_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            { 
                /*//Задание №1
                string path = "numsTask1.txt";
            
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
                }*/

                /*//Задание №2
                string path = "numsTask2.txt";
                
                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    char[] separators = { ' ', ',', '.', '!', '?', '\n', '\t', '\r' };
                    string[] wordsFromFile =
                        reader.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    string text = string.Join(" ", wordsFromFile);
                    Console.WriteLine(text);
                }*/

                /*//Задание №3
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
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
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                }*/

                /*//Задание №4
                Console.Write("Введите положительное число a: ");
                if (float.TryParse(Console.ReadLine(), out float a) && a > 0)
                {
                    float sum = 0;
                    while (true)
                    {
                        Console.Write("Введите число (чтобы закончить введите отрицательное число): ");
                        if (float.TryParse(Console.ReadLine(), out float number))
                        {
                            if (number < 0)
                            {
                                Console.WriteLine($"Сумма чисел, делящихся на a нацело: {sum}");
                                break;
                            }

                            if (number % a == 0)
                            {
                                sum += number;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }*/

                /*//Задание №5
                Console.Write("Введите количество строк в массиве: ");
                if (short.TryParse(Console.ReadLine(), out short n))
                {
                    Console.Write("Введите количество столбцов в массиве: ");
                    if (short.TryParse(Console.ReadLine(), out short m))
                    {
                        int[,] a = new int[n, m];

                        Random random = new Random();

                        Console.WriteLine("\nИсходный массив:");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                a[i, j] = random.Next(0, 2);
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

                        Console.WriteLine("\nМассив с новым столбцом:");
                        for (int i = 0; i < n; i++)
                        {
                            newMatrix[i, m] = newColumn[i];
                            for (int j = 0; j < m + 1; j++)
                            {
                                Console.Write("{0, 3}", newMatrix[i, j]);
                            }

                            Console.WriteLine();
                        }
                    }
                }*/
                

                /*//Задание №6
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
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}