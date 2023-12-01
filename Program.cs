
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
    int totalSum = 0;

    foreach(string line in input)
    {
        char charOne = '1';
        string stringOne = "one";

        char charTwo = '2';
        string stringTwo = "two";

        char charThree = '3';
        string stringThree = "three";

        char charFour = '4';
        string stringFour = "four";

        char charFive = '5';
        string stringFive = "five";

        char charSix = '6';
        string stringSix = "six";

        char charSeven = '7';
        string stringSeven = "seven";

        char charEight = '8';
        string stringEight = "eight";

        char charNine = '9';
        string stringNine = "nine";

        string stringNinEight = "nineight"; //98
        string stringEighThree = "eighthree"; //83
        string stringEighTwo = "eightwo"; //82
        string stringSeveNine = "sevenine"; //79
        string stringFiveIght = "fiveight"; //58
        string stringThreEight = "threeight"; //38
        string stringTwOne = "twone"; //21
        string stringOnEight = "oneight"; //18

        string newLine = line;

        newLine = newLine.Replace(stringNinEight, "98");
        newLine = newLine.Replace(stringEighThree, "83");
        newLine = newLine.Replace(stringEighTwo, "82");
        newLine = newLine.Replace(stringSeveNine, "79");
        newLine = newLine.Replace(stringFiveIght, "58");
        newLine = newLine.Replace(stringThreEight, "38");
        newLine = newLine.Replace(stringTwOne, "21");
        newLine = newLine.Replace(stringOnEight, "18");

        newLine = newLine.Replace(stringOne, Convert.ToString(charOne));
        newLine = newLine.Replace(stringTwo, Convert.ToString(charTwo));
        newLine = newLine.Replace(stringThree, Convert.ToString(charThree));
        newLine = newLine.Replace(stringFour, Convert.ToString(charFour));
        newLine = newLine.Replace(stringFive, Convert.ToString(charFive));
        newLine = newLine.Replace(stringSix, Convert.ToString(charSix));
        newLine = newLine.Replace(stringSeven, Convert.ToString(charSeven));
        newLine = newLine.Replace(stringEight, Convert.ToString(charEight));
        newLine = newLine.Replace(stringNine, Convert.ToString(charNine));
        Console.WriteLine(newLine);

        char firstNumber = newLine.First(c => Char.IsDigit(c));
        char lastNumber = newLine.Last(c => Char.IsDigit(c));

        Console.WriteLine("first digit in line: " + firstNumber);
        Console.WriteLine("last digigt in line: " + lastNumber);

        string sumNumbers = firstNumber.ToString() + lastNumber.ToString();
        Console.WriteLine(sumNumbers);

        totalSum += Convert.ToInt32(sumNumbers);
        Console.WriteLine(totalSum);
    }
}
