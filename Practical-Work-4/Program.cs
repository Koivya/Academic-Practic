using System;
using System.Collections.Generic;
using System.IO;

namespace PracticalWork4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*//Задание №1
            try
            {
                Console.Write("Введите целое положительное число n: ");
                ushort n = ushort.Parse(Console.ReadLine());

                short result = 1;

                for (short i = 3; i <= n; i += 3)
                {
                    if (i % 3 == 0)
                    {
                        result *= i;
                    }
                }

                Console.WriteLine("Результат: {0}", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            /*//Задание №2
            string path = "numsTask2.txt";

            try
            {
                string line;
                using (StreamReader reader = new StreamReader(path))
                {
                    line = reader.ReadLine();
                    Console.WriteLine("Данные в файле:");
                    Console.WriteLine(line + "\n");
                }

                string[] nums = line.Split(';');

                List<float> numbers = new List<float>();

                Console.WriteLine("Массив чисел(до 0), собранный из файла:");
                for (int i = 0; i < nums.Length; i++)
                {
                    if (float.Parse(nums[i]) == 0)
                    {
                        break;
                    }

                    numbers.Add(float.Parse(nums[i]));
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine("\n");

                float sum = 0;
                foreach (float number in numbers)
                {
                    if (number > 0)
                    {
                        sum += number;
                    }
                }

                Console.WriteLine("Сумма положительных элементов массива: " + Math.Round(sum, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            /*//Задание №3
            string path = "numsTask3.txt";

            try
            {
                string line;
                using (StreamReader reader = new StreamReader(path))
                {
                    line = reader.ReadLine();
                    Console.WriteLine("Данные в файле:");
                    Console.WriteLine(line + "\n");
                }

                string[] nums = line.Split(',');

                List<short> numbers = new List<short>();

                Console.WriteLine("Массив чисел(до 0), собранный из файла:");
                for (int i = 0; i < nums.Length; i++)
                {
                    if (short.Parse(nums[i]) == 0)
                    {
                        break;
                    }

                    numbers.Add(short.Parse(nums[i]));
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine("\n");

                short minElement = numbers[0];
                short maxElement = numbers[0];
                foreach (short element in numbers)
                {
                    if (element > maxElement)
                    {
                        maxElement = element;
                    }

                    if (element < minElement)
                    {
                        minElement = element;
                    }
                }

                Console.WriteLine("Минимальный элемент массива: " + minElement);
                Console.WriteLine("Максимальный элемент массива: " + maxElement);

                float ratio = minElement / maxElement;
                Console.WriteLine("\nСоотношение минимального и максимального элементов друг к другу = " + ratio);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            /*//Задание №4
            string path = "numsTask4.txt";

            try
            {
                string line;
                using (StreamReader reader = new StreamReader(path))
                {
                    line = reader.ReadLine();
                    Console.WriteLine("Данные в файле:");
                    Console.WriteLine(line + "\n");
                }

                string[] nums = line.Split(' ');

                List<short> numbers = new List<short>();

                Console.WriteLine("Массив чисел, собранный из файла:");
                for (int i = 0; i < nums.Length; i++)
                {
                    numbers.Add(short.Parse(nums[i]));
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine("\n");

                short count = 0;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        count++;
                    }
                }

                Console.WriteLine("Количество одинаковых рядом стоящих чисел: " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            /*//Задание №5
            try
            {
                Console.WriteLine("Введите вещественные числа a и b");

                Console.Write("a =  ");
                float a = float.Parse(Console.ReadLine());

                Console.Write("b =  ");
                float b = float.Parse(Console.ReadLine());

                short x1 = -1, x2 = 3;
                short y1 = -2, y2 = 4;

                if (a >= x1 && a <= x2 && b >= y1 && b <= y2)
                {
                    Console.WriteLine("Точка, с координатами (a; b), принадлежит заштрихованной области");
                }
                else
                {
                    Console.WriteLine("Точка, с координатами (a; b), не принадлежит заштрихованной области");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            /*//Задание №6
            try
            {
                Console.WriteLine("Введите вещественные числа a и b");

                Console.Write("a =  ");
                float a = float.Parse(Console.ReadLine());

                Console.Write("b =  ");
                float b = float.Parse(Console.ReadLine());

                short x1 = -2, x2 = 0, x3 = 2;
                short y1 = -3, y2 = 2, y3 = -3;

                float orientation1 = (x2 - x1) * (b - y1) - (a - x1) * (y2 - x1);
                float orientation2 = (x3 - x2) * (b - y2) - (a - x2) * (y3 - x2);
                float orientation3 = (x1 - x3) * (b - y3) - (a - x3) * (y1 - x3);

                Console.WriteLine("{0}, {1}, {2}", orientation1, orientation2, orientation3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}