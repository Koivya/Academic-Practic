using System.Text;

namespace Practical_Work_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                /*//Задание №1
                string inputPath = "input.txt";
                string outputPath = "output.txt";

                string[] lines = File.ReadAllLines(inputPath);
                int[] winningNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();
                int n = int.Parse(lines[1]);
                int[][] tickets = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    tickets[i] = lines[i + 2].Split(' ').Select(int.Parse).ToArray();
                }

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    foreach (var ticket in tickets)
                    {
                        int matchingNumbers = ticket.Count(number => winningNumbers.Contains(number));
                        string result;
                        if (matchingNumbers >= 3)
                        {
                            result = "Lucky";
                        }
                        else
                        {
                            result = "Unlucky";
                        }

                        writer.WriteLine(result);
                    }
                }*/


                /*//Задание №2
                string path = "nums.txt";

                string numbersLine;
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    numbersLine = sr.ReadToEnd();
                }

                string[] numbers = numbersLine.Split(' ', '\n', '\t');

                List<short> oddNumbers = new List<short>();

                foreach (var number in numbers)
                {
                    if (short.TryParse(number, out short parsedNumber))
                    {
                        if (parsedNumber % 2 != 0)
                        {
                            oddNumbers.Add(parsedNumber);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    string newNumbers = string.Join(" ", oddNumbers);
                    writer.WriteLine(newNumbers);
                }*/


                /*//Задание №3
                string path = "numbers.txt";

                string[] numbersLine;
                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    char[] separators = { ' ', ',', '.', '\n', '\t' };
                    numbersLine = reader.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                }

                short[] height = new short[numbersLine.Length];
                for (short i = 0; i < numbersLine.Length; i++)
                {
                    height[i] = short.Parse(numbersLine[i]);
                }

                short maxArea = 0;
                byte left = 0;
                byte right = (byte)(height.Length - 1);

                while (left < right)
                {
                    short area = (short)((right - left) * Math.Min(height[left], height[right]));
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }

                    if (height[left] < height[right])
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

                string result = Convert.ToString(maxArea);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine("\n" + result);
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
