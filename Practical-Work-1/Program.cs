namespace Practical_Work_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Задание №1
                /*short size = 10;
                List<short> numbers = new List<short>();
    
                Random random = new Random();
    
                Console.WriteLine("Список случайных чисел:");
                for (int i = 0; i < size; i++)
                {
                    numbers.Add((short)random.Next(100));
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
    
                short minNumber = numbers[0];
                short minNumbersIndex = 0;
                for (int i = 0; i < size; i++)
                {
                    if (numbers[i] < minNumber)
                    {
                        minNumber = numbers[i];
                        minNumbersIndex = (short)i;
                    }
                }
    
                Console.WriteLine("\nНомер минимального элемента: {0}", minNumbersIndex + 1);*/


                /*//Задание №2
                List<int> numbers = new List<int>();

                while (true)
                {
                    Console.Write("Введите число в список (чтобы завершить, введите 0): ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        if (number == 0)
                        {
                            break;
                        }

                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                }

                Console.WriteLine("\nСписок с числами:");
                if (numbers.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    foreach (int element in numbers)
                    {
                        Console.Write(element + " ");
                    }

                    Console.WriteLine();

                    float sum = 0;
                    float product = 1;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                        product *= numbers[i];
                    }

                    Console.WriteLine("\nСумма всех элементов = {0}", sum);
                    Console.WriteLine("Произведение всех элементов = {0}", product);

                    float average = sum / numbers.Count;
                    Console.WriteLine("Среднее значение в списке: {0}", average);
                }*/


                /*//Задание №3
                List<int> numbers = new List<int>();
                
                while (true)
                {
                    Console.Write("Введите число в список (чтобы завершить, введите пустую строку): ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }
                    if (int.TryParse(input, out int number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                }
                
                Console.WriteLine("\nСписок с числами:");
                if (numbers.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    foreach (int element in numbers)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine();
                
                    short minLength = (short)numbers[0].ToString().Length;
                    short minLengthResult = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i].ToString().Length < minLength)
                        {
                            minLength = (short)numbers[i].ToString().Length;
                            minLengthResult = (short)i;
                        }
                    }
                
                    short maxLength = (short)numbers[0].ToString().Length;
                    short maxLengthResult = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i].ToString().Length > maxLength)
                        {
                            maxLength = (short)numbers[i].ToString().Length;
                            maxLengthResult = (short)i;
                        }
                    }
                
                    Console.WriteLine("\nСамый длинный элемент списка под номером: {0}", maxLengthResult + 1);
                    Console.WriteLine("Самый короткий элемент списка под номером: {0}", minLengthResult + 1);
                }*/


                /*//Задание №4
                while (true)
                {
                    Console.WriteLine("Введите диапазон случайных чисел");
                    Console.Write("От: ");
                    if (int.TryParse(Console.ReadLine(), out int startRange))
                    {
                        Console.Write("До: ");
                        if (int.TryParse(Console.ReadLine(), out int endRange))
                        {
                            int[] numbers = RandomizeList(startRange, endRange + 1);

                            Console.WriteLine("\nМассив случайных чисел:");
                            foreach (int element in numbers)
                            {
                                Console.Write(element + "  ");
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                    }
                }

                int[] RandomizeList(int start, int end)
                {
                    int size = 20;

                    int[] result = new int[size];

                    Random random = new Random();

                    for (int i = 0; i < size; i++)
                    {
                        result[i] = random.Next(start, end);
                    }

                    return result;
                }*/


                /*//Задание №5
                Console.WriteLine("Введите текст: ");
                string text = Console.ReadLine();

                int words = GetNumberOfWords(text);
                Console.WriteLine("Количество слов в строке: {0}", words);

                string result = "Start - " + text + " - End";
                Console.WriteLine(result);
                
                int GetNumberOfWords(string someText)
                {
                    char[] separators = {' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r'};
                    
                    string[] wordsFromText = someText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    
                    return wordsFromText.Length;
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}