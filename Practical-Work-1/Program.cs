using System;
using System.Collections.Generic;

namespace PracticalWork1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*//Задание №1
            short size = 10;
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
            short minIndex = 0;
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                    minIndex = (short)i;
                }
            }

            Console.WriteLine("\nНомер минимального элемента: {0}", minIndex + 1);*/



            /*//Задание №2
            List<short> numbers = new List<short>();

            while (true)
            {
                Console.Write("Введите число в список (чтобы завершить, введите 0): ");
                short number = short.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);
            }

            Console.WriteLine("\nСписок с числами:");
            foreach (short element in numbers)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            float sum = 0;
            ulong product = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
                product *= (ulong)numbers[i];
            }

            Console.WriteLine("\nСумма всех элементов = {0}", sum);
            Console.WriteLine("Произведение всех элементов = {0}", product);
            
            float average = sum / numbers.Count;
            Console.WriteLine("Среднее значение в списке: {0}", average);*/



            /*//Задание№3
            List<short> numbers = new List<short>();
            
            while (true)
            {
                Console.Write("Введите число в список (чтобы завершить, введите пустую строку): ");
                string number = Console.ReadLine();
                if (string.IsNullOrEmpty(number))
                {
                    break;
                }
                numbers.Add(short.Parse(number));
            }
            
            Console.WriteLine("\nСписок с числами:");
            foreach (short element in numbers)
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
            
            Console.WriteLine("\nСамый длинный элемент списка: {0}", maxLengthResult);
            Console.WriteLine("Самый короткий элемент списка: {0}", minLengthResult);*/



            /*//Задание №4
            short[] RandomizeList(short start, short end)
            {
                short size = 20;

                short[] result = new short[size];
                
                Random random = new Random();
                
                for (int i = 0; i < size; i++)
                {
                    result[i] = (short)random.Next(start, end);
                }
            
                return result;
            }
            
            Console.WriteLine("Введите диапазон случайных чисел");
            
            Console.Write("От: ");
            short startRange = short.Parse(Console.ReadLine());
            
            Console.Write("До: ");
            short endRange = short.Parse(Console.ReadLine());
            
            short[] numbers = RandomizeList(startRange, endRange);
            
            Console.WriteLine("\nМассив случайных чисел:");
            foreach (short element in numbers)
            {
                Console.Write(element + "  ");
            }*/
            
            
            
            /*//Задание №5
            short GetNumberOfWords(string someText)
            {
                char[] separators = {' ', ',', '.', '!', '?', ';', ':', '\t', '\n'};
            	
                string[] wordsFromText = someText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            	
                return (short)wordsFromText.Length;
            }
            
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            
            short words = GetNumberOfWords(text);
            Console.WriteLine("Количество слов в строке: {0}", words);
            
            string result = "Start - " + text + " - End";
            Console.WriteLine(result);*/
        }
    }
}