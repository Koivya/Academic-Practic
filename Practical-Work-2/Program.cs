namespace Practical_Work_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                /*//Задание №1
                byte size = 100;
                List<short> numbers = new List<short>();

                Random random = new Random();

                short number = (short)random.Next(500);
                for (int i = 0; i < size; i++)
                {
                    number -= 3;
                    numbers.Add(number);
                }

                Console.WriteLine("Вывод массива:");
                foreach (short el in numbers)
                {
                    Console.Write(el + " ");
                }*/


                /*//Задание №2
                while (true)
                {
                    Console.Write("Введите размерность массива: ");
                    if (int.TryParse(Console.ReadLine(), out int size))
                    {
                        int[] numbers = new int[size];

                        int number = 1;
                        for (int i = 0; i < size; i++)
                        {
                            numbers[i] = number;
                            number += 2;
                        }

                        Console.WriteLine("\nВывод массива:");
                        foreach (int el in numbers)
                        {
                            Console.Write(el + " ");
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                    }
                }*/


                /*//Задание №3
                while (true)
                {
                    Console.Write("Введите размер квадратной матрицы: ");
                    if (int.TryParse(Console.ReadLine(), out int size))
                    {
                        int[,] numbers = new int[size, size];
                
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {   
                                if (i == 0 || j == 0)
                                {
                                    numbers[i, j] = 1;
                                }
                                else
                                {
                                    numbers[i, j] = numbers[i - 1, j] + numbers[i, j - 1];
                                }
                            }
                        }

                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                Console.Write("{0, 7}", numbers[i, j]);
                            }

                            Console.WriteLine("\n");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.\n");
                    }
                }*/
                


                /*//Задание №4
                List<string> months = new List<string>()
                {
                    "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                    "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
                };
    
                short numberMonths = 12, numberDays = 30;
                short[,] temperature = new short[numberMonths, numberDays];
    
                Random random = new Random();
    
                for (int i = 0; i < numberMonths; i++)
                {
                    for (int j = 0; j < numberDays; j++)
                    {
                        temperature[i, j] = (short)random.Next(-15, 21);
                    }
                }
    
                for (int i = 0; i < numberMonths; i++)
                {
                    Console.WriteLine("Температура за {0}: ", months[i]);
                    for (int j = 0; j < numberDays; j++)
                    {
                        if (j == 6 || j == 12 || j == 18 || j == 24)
                        {
                            Console.WriteLine();
                        }
    
                        Console.Write("{0, 5}", temperature[i, j]);
                    }
    
                    Console.WriteLine("\n");
                }
    
                float[] averageTemps = GetAverageTemp(temperature);
    
                Console.WriteLine("\nСредняя температура за каждый месяц:");
                for (int i = 0; i < averageTemps.Length; i++)
                {
                    Console.WriteLine($"{months[i]}: {Math.Round(averageTemps[i], 2)}");
                }
    
                float[] sortedArray = (float[])averageTemps.Clone();
    
                Array.Sort(sortedArray);
    
                Console.WriteLine("\nОтсортированный массив средних температур:");
                foreach (float element in sortedArray)
                {
                    Console.Write($"{Math.Round(element, 2)}\t");
                }
                
                float[] GetAverageTemp(short[,] array)
                {
                    short numMonths = 12, numDays = 30;
                    float[] averageTemp = new float[numMonths];
    
                    for (int i = 0; i < numMonths; i++)
                    {
                        float sum = 0;
                        for (int j = 0; j < numDays; j++)
                        {
                            sum += array[i, j];
                        }
    
                        averageTemp[i] = (sum / numDays);
                    }
    
                    return averageTemp;
                }*/


                /*//Задание №5
                Dictionary<string, short[]> temperatureDictionary = new Dictionary<string, short[]>();
    
                List<string> months = new List<string>
                {
                    "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                    "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
                };
    
                short numberDays = 30;
    
                Random random = new Random();

                for (int i = 0; i < months.Count; i++)
                {
                    short[] numbers = new short[numberDays];
                    for (int j = 0; j < numberDays; j++)
                    {
                        numbers[j] = (short)random.Next(-15, 21);
                    }
    
                    temperatureDictionary.Add(months[i], numbers);
                }
    
                foreach (var month in temperatureDictionary)
                {
                    Console.WriteLine($"Температура за {month.Key}:");
                    for (int j = 0; j < numberDays; j++)
                    {
                        if (j == 6 || j == 12 || j == 18 || j == 24)
                        {
                            Console.WriteLine();
                        }
    
                        Console.Write("{0, 5}", month.Value[j]);
                    }
    
                    Console.WriteLine("\n");
                }
    
                Dictionary<string, float> averageTemp = CalculateAverageTemperature(temperatureDictionary);
                Console.WriteLine("Средняя температура за каждый месяц:");
                foreach (var element in averageTemp)
                {
                    Console.WriteLine("{0}: {1}", element.Key, Math.Round(element.Value, 2));
                }
                
                Dictionary<string, float> CalculateAverageTemperature(Dictionary<string, short[]> dictionary)
                {
                    Dictionary<string, float> result = new Dictionary<string, float>();
    
                    foreach (var month in dictionary)
                    {
                        float sum = 0;
                        short[] temperatureArray = month.Value;
    
                        foreach (var temp in temperatureArray)
                        {
                            sum += temp;
                        }
    
                        float averageTemperature = sum / temperatureArray.Length;
                        result.Add(month.Key, averageTemperature);
                    }
    
                    return result;
                }*/
            }
        }
    }
}
