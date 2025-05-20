// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var lowNums = numbers.Where(num => num < 5);


foreach (var x in lowNums)
{
    Console.WriteLine(x);
}

Console.WriteLine("=============== LinQ ==================="); // W3Resource Practice Problem
//3. Write a program in C# Sharp to find the number of an array and the square of each number.
var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

var sqNo3 = arr1.Where(j => j * j > 20);


var SqNO = arr1.Select(Number => new { Number, SqrNO = Number * Number })
              .Where(x => x.SqrNO > 20);

var SqNO1 = arr1.Select((Number, x) => new { Number, SqrNO = Number * Number, x })
              .Where(x => x.SqrNO > 20)
              .OrderBy(x => x.Number);


foreach (var x in sqNo3)
{
    Console.WriteLine(x);
}

//4. Write a program in C# Sharp to display the number and frequency of a given number from an array.

int[] frequencyArr = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

var frequency = frequencyArr.GroupBy(x => x)
    .Select(g => new { Number = g.Key, Frequency = g.Count() })
    .OrderBy(x => x.Number);

foreach (var x in frequency)
{
    Console.WriteLine($"Number: {x.Number}, Frequency: {x.Frequency}");
};

//5. Write a program in C# Sharp to display the characters and frequency of each character in a given string

string str = "Assalamu Alaikum";

var frequencyCount = str.GroupBy(c => char.ToLower(c))
    .Select(g => new {ch = g.Key, count = g.Count() })
    .OrderBy(x => x.ch);
foreach (var x in frequencyCount)
{
    Console.WriteLine($"Character: {x.ch}, Frequency: {x.count}");
}
Console.WriteLine("**** 7.display numbers, multiplication of numbers with frequency and the frequency of a number in an array ***");
//7.display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
int[] arr = { 5, 5, 2, 5, 2,3,5,3,3};

var multiply = arr.GroupBy(x => x)
    .Select(g => new { Number = g.Key, Result = g.Key * g.Count(), Frequency = g.Count() })
    .OrderBy(x => x.Number);
  
    

foreach (var x in multiply)
{
    Console.WriteLine($"Number: {x.Number}, Result: {x.Result} , Frequency: {x.Frequency}");
}

//8. Write a program in C# Sharp to find a string that starts and ends with a specific character
Console.WriteLine("=========== Problem No.8 =============");

string[] city = { "ArambagM", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };


var taregetCityName = city.Where(x => x.StartsWith("A"))
            .Where(x => x.EndsWith("M"))
            .Select( Name => new { Name, Length = Name.Length }).ToList(); // simply use ToList() 

foreach (var x in taregetCityName)
{
    Console.WriteLine(x);
}



