// See https://aka.ms/new-console-template for more information

Dictionary<char, int> alphabetNumbers = new Dictionary<char, int>();
List<string> sortedList;
string lettersInAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

for (var i = 0; i < 26; i++)
{
    alphabetNumbers.Add(lettersInAlphabet[i],i+1);
}

int index;
Dictionary<int, string> names = new Dictionary<int, string>();
try
{
    string[]? lines = File.ReadAllLines("..\\..\\..\\data\\names.txt");
    index = 0;
    string[] col = [""];
    foreach (var line in lines)
    {
        col = line.Split(',');
    }

    sortedList = sortList(col);
    

    for(int i = 0; i < sortedList.Count; i++)
    {
        var sumChars = nameSum(sortedList[i], alphabetNumbers);

        Console.WriteLine($"The characters for the name {sortedList[i]} add up to {sumChars} \n");

        var sum = getNameAndPositionSum(i, sumChars);

        Console.WriteLine($"The sum total the position {i+1} + sum of characters for the name {sortedList[i]} is {sum} \n");
    }


}

catch(Exception e )
{
    Console.WriteLine("Exception : " + e.Message);
}
finally { Console.WriteLine("Finito"); }

static int nameSum(string name, Dictionary<char, int> alphabetNumbers)
{
    int sum = 0;
    
    for(var i = 0; i < name.Length;i++)
    {
        if (name[i] != '"')
        {
            Console.WriteLine(name[i]);
            sum = alphabetNumbers[name[i]] + sum;
            Console.WriteLine(sum);
        }

    }

    return sum;
}

static List<string> sortList(string[] names)
{
    List<string> temp = [.. names];

    temp.Sort();
    return temp;
}

static int getNameAndPositionSum(int position, int sumChars)
{
    var sum = position + sumChars;
    return sum + 1;
}
