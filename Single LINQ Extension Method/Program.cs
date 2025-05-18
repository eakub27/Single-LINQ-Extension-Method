// See https://aka.ms/new-console-template for more information

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


