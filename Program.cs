Day1Part2();

static void Day1Part1()
{
    string[] input = File.ReadAllLines("input.txt");
    int totalSum = 0;

    foreach (string line in input)
    {
        char firstNumber = line.First(c => Char.IsDigit(c));
        char lastNumber = line.Last(c => Char.IsDigit(c));

        Console.WriteLine("first digit in line: " + firstNumber);
        Console.WriteLine("last digigt in line: " + lastNumber);

        string sumNumbers = firstNumber.ToString() + lastNumber.ToString();
        Console.WriteLine(sumNumbers);

        totalSum += Convert.ToInt32(sumNumbers);
        Console.WriteLine(totalSum);
    }
}

static void Day1Part2()
{
    string[] input = File.ReadAllLines("input.txt");
    string[] letteralNumbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    int[] numberArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int totalSum = 0;

    foreach(string line in input)
    {
        char firstNumber = line.First(c => Char.IsDigit(c));
        char lastNumber = line.Last(c => Char.IsDigit(c));

        for (int i = 0; i < letteralNumbers.Length; i++)
        {
            if (line.Contains(letteralNumbers[i]))
            {
                firstNumber = Convert.ToChar(numberArr[i]);
                Console.WriteLine("FOUND IT " + Convert.ToInt32(firstNumber));
                
                string sumNumber = firstNumber.ToString() + lastNumber.ToString();
                totalSum += Convert.ToInt32(sumNumber);
            }
        }
    }
}