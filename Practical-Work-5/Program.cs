namespace Practical_Work_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                /*//Задание №1
                string path = "numsTask1.txt";

                string numbersFromFile;
                using (StreamReader reader = new StreamReader(path))
                {
                    numbersFromFile = reader.ReadToEnd();
                }

                char[] separators = { ' ', ',', '.', '?', '!', '\n', '\t', '\r', ';', ':' };
                string[] stringNumbers = numbersFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                List<int> numbers = new List<int>();

                Console.WriteLine("Массив чисел, взятых из файла:");
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    if (int.TryParse(stringNumbers[i], out int number))
                    {
                        numbers.Add(number);
                        Console.Write(number + " ");
                    }
                    else
                    {
                        Console.WriteLine(stringNumbers[i] + "некорректное число");
                    }
                }

                Console.WriteLine();

                int minNumber = numbers[0];
                int minIndex = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < minNumber)
                    {
                        minNumber = numbers[i];
                        minIndex = i;
                    }
                }

                Console.WriteLine("\nМинимальное число в массиве: " + minNumber);
                Console.WriteLine("Номер минимального числа: " + (minIndex + 1));

                float product = 1;
                for (int i = minIndex + 1; i < numbers.Count; i++)
                {
                    product *= numbers[i];
                }

                Console.WriteLine("\nПроизведение чисел, расположенных после минимального: " + product);*/


                /*//Задание №2
                string path = "numsTask2.txt";

                string numbersFromFile;
                using (StreamReader reader = new StreamReader(path))
                {
                    numbersFromFile = reader.ReadToEnd();
                }

                char[] separators = { ' ', '\n', '\t', '\r', ';' };
                string[] stringNumbers = numbersFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                List<float> numbers = new List<float>();

                Console.WriteLine("Массив вещественных чисел, взятых из файла:");
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    float number;
                    if (float.TryParse(stringNumbers[i], out number))
                    {
                        numbers.Add(number);
                        Console.Write(number + "  ");
                    }
                    else
                    {
                        Console.WriteLine(stringNumbers[i] + "некорректное число");
                    }
                }

                Console.WriteLine();

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    for (int j = 0; j < numbers.Count - i - 1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    string newNumbers = string.Join("  ", numbers);
                    writer.WriteLine(newNumbers);
                }

                Console.WriteLine("\nОтсортированная последовательность чисел перезаписана в файл");*/


                /*//Задание №3
                string path = "numsTask3.txt";

                string numbersFromFile;
                using (StreamReader reader = new StreamReader(path))
                {
                    numbersFromFile = reader.ReadToEnd();
                }

                char[] separators = { ' ', ',', '.', '?', '!', '\n', '\t', '\r', ';', ':' };
                string[] stringNumbers = numbersFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                List<short> numbers = new List<short>();

                Console.WriteLine("Массив целых чисел, взятых из файла:");
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    short number;
                    if (short.TryParse(stringNumbers[i], out number))
                    {
                        numbers.Add(number);
                        Console.Write(number + "  ");
                    }
                    else
                    {
                        Console.WriteLine(stringNumbers[i] + "некорректное число");
                    }
                }

                Console.WriteLine();

                short minNumber = numbers[0];
                short minIndex = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < minNumber)
                    {
                        minNumber = numbers[i];
                        minIndex = (short)i;
                    }
                }

                Console.WriteLine("\nМинимальное число в массиве: " + minNumber);
                Console.WriteLine("Номер минимального числа: " + (minIndex + 1));

                float sum = 0;
                for (int i = 0; i < minIndex + 1; i++)
                {
                    sum += numbers[i];
                }

                float average = sum / (minIndex + 1);
                Console.WriteLine("\nСреднее арифметическое элементов до минимального: " + Math.Round(average, 2));*/


                /*//Задание №4
                string path = "numsTask4.txt";

                string numbersFromFile;
                using (StreamReader reader = new StreamReader(path))
                {
                    numbersFromFile = reader.ReadToEnd();
                }

                char[] separators = { ' ', ',', '.', '?', '!', '\n', '\t', '\r', ';', ':' };
                string[] stringNumbers = numbersFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                List<short> numbers = new List<short>();

                Console.WriteLine("Массив целых чисел, взятых из файла:");
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    short number;
                    if (short.TryParse(stringNumbers[i], out number))
                    {
                        numbers.Add(number);
                        Console.Write(number + "  ");
                    }
                    else
                    {
                        Console.WriteLine(stringNumbers[i] + "некорректное число");
                    }
                }

                Console.WriteLine();

                short maxNumber = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > maxNumber)
                    {
                        maxNumber = numbers[i];
                    }
                }

                Console.WriteLine("\nМаксимальное число в массиве: " + maxNumber);

                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == maxNumber - 1)
                    {
                        sum += numbers[i];
                    }
                }

                Console.WriteLine("\nСумма чисел, отличающихся от максимального на 1: " + sum);*/


                /*//Задание №5
                string path = "numsTask5.txt";

                string numbersFromFile;
                using (StreamReader reader = new StreamReader(path))
                {
                    numbersFromFile = reader.ReadToEnd();
                }

                char[] separators = { ' ', ',', '.', '?', '!', '\n', '\t', '\r', ';', ':' };
                string[] stringNumbers = numbersFromFile.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                List<int> numbers = new List<int>();

                Console.WriteLine("Массив целых чисел, взятых из файла:");
                for (int i = 0; i < stringNumbers.Length; i++)
                {
                    if (int.TryParse(stringNumbers[i], out int number))
                    {
                        numbers.Add(number);
                        Console.Write(number + "  ");
                    }
                    else
                    {
                        Console.WriteLine(stringNumbers[i] + "некорректное число");
                    }
                }

                Console.WriteLine();

                int maxNumber = numbers[0];
                int maxIndex = 0;

                int minNumber = numbers[0];
                int minIndex = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > maxNumber)
                    {
                        maxNumber = numbers[i];
                        maxIndex = i;
                    }

                    if (numbers[i] < minNumber)
                    {
                        minNumber = numbers[i];
                        minIndex = i;
                    }
                }

                Console.WriteLine("\nМинимальное число в массиве: " + minNumber);
                Console.WriteLine("Номер минимального числа: " + (minIndex + 1));

                Console.WriteLine("\nМаксимальное число в массиве: " + maxNumber);
                Console.WriteLine("Индекс максимального числа: " + (maxIndex + 1));

                if (maxIndex - minIndex > 1)
                {
                    float sum = 0;
                    for (int i = minIndex + 1; i < maxIndex; i++)
                    {
                        sum += numbers[i];
                    }

                    float average = sum / (maxIndex - minIndex - 1);
                    Console.WriteLine("\nСреднее арифметическое чисел между минимальным и максимальным: " + average);
                }
                else
                {
                    Console.WriteLine("\nМежду минимальным и максимальным числом нет чисел");
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}