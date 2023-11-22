using System;
using System.Collections.Generic;

namespace PracticalWork2
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
            Console.Write("Введите размерность массива: ");
            short size = short.Parse(Console.ReadLine());

            short[] numbers = new short[size];

            short number = 1;
            for (int i = 0; i < size; i++)
            {
                numbers[i] = number;
                number += 2;
            }

            Console.WriteLine("\nВывод массива:");
            foreach (short el in numbers)
            {
                Console.Write(el + " ");
            }*/


            /*//Задание №3
            Console.Write("Введите размер квадратной матрицы: ");
            short size = short.Parse(Console.ReadLine());
            
            short[,] numbers = new short[size, size];
            
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
                        numbers[i, j] = (short)(numbers[i - 1, j] + numbers[i, j - 1]);
                    }
                }
            }
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", numbers[i, j]);
                }
                Console.WriteLine();*/


            /*//Задание №4
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
            }

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
                Console.WriteLine("{0}: {1}", months[i], Math.Round(averageTemps[i], 2));
            }

            float[] sortedArray = (float[])averageTemps.Clone();

            Array.Sort(sortedArray);

            Console.WriteLine("\nОтсортированный массив средних температур:");
            foreach (float element in sortedArray)
            {
                Console.Write("{0}  ", Math.Round(element, 2));
            }*/


            /*//Задание №5
            Dictionary<string, float> CalculateAverageTemperature(Dictionary<string, short[]> dictionary)
            {
                Dictionary<string, float> avrgTemp = new Dictionary<string, float>();

                foreach (var month in dictionary)
                {
                    float sum = 0;
                    short[] temperatureArray = month.Value;

                    foreach (var temp in temperatureArray)
                    {
                        sum += temp;
                    }

                    float averageTemperature = sum / temperatureArray.Length;
                    avrgTemp.Add(month.Key, averageTemperature);
                }

                return avrgTemp;
            }

            Dictionary<string, short[]> temperatureDictionary = new Dictionary<string, short[]>();

            List<string> months = new List<string>()
            {
                "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };

            short numberDays = 30;
            short[,] temperature = new short[months.Count, numberDays];

            Random random = new Random();

            for (int i = 0; i < months.Count; i++)
            {
                for (int j = 0; j < numberDays; j++)
                {
                    temperature[i, j] = (short)random.Next(-15, 21);
                }
            }

            for (int i = 0; i < months.Count; i++)
            {
                short[] numbers = new short[numberDays];
                for (int j = 0; j < numberDays; j++)
                {
                    numbers[j] = (short)(random.Next(-15, 21));
                }

                temperatureDictionary.Add(months[i], numbers);
            }

            short[] monthTemperature;
            for (int i = 0; i < months.Count; i++)
            {
                monthTemperature = temperatureDictionary[months[i]];
                Console.WriteLine("Температура за {0}:", months[i]);
                for (int j = 0; j < monthTemperature.Length; j++)
                {
                    if (j == 6 || j == 12 || j == 18 || j == 24)
                    {
                        Console.WriteLine();
                    }

                    Console.Write("{0, 5}", monthTemperature[j]);
                }

                Console.WriteLine("\n");
            }

            Dictionary<string, float> averageTemp = CalculateAverageTemperature(temperatureDictionary);
            Console.WriteLine("Средняя температура за каждый месяц:");
            foreach (var element in averageTemp)
            {
                Console.WriteLine("{0}: {1}", element.Key, Math.Round(element.Value, 2));
            }*/
        }
    }
}