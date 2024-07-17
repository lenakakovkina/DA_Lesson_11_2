using System.Diagnostics.CodeAnalysis;

List<int> marks = new List<int>();
int userInputtoInt;
string userInput="";
int minMark;
int maxMark;
double sumOfMarks;
int countMarks;
double averedgeMark;
while (true)
{
    Console.WriteLine("Input marks per lesson");
    userInput = Console.ReadLine();

    //userInputtoInt = int.Parse(userInput);
    //marks.Add(userInputtoInt);
    try

    {
        userInputtoInt = int.Parse(userInput);
        marks.Add(userInputtoInt);

    }
    catch (FormatException)
    {
    Console.WriteLine($"Error occurs! As mark only interger number could be entered. Update!!!");
        continue;
    }
    minMark = marks.Min();
    Console.WriteLine($"The min mark is:{minMark}");
    maxMark = marks.Max();
    Console.WriteLine($"The max mark is:{maxMark}");
    countMarks = marks.Count();
    sumOfMarks = marks.Sum();
    averedgeMark = sumOfMarks/countMarks;
    Console.WriteLine($"The averege mark is:{averedgeMark}");
}

