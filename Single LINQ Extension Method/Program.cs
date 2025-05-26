// See https://aka.ms/new-console-template for more information

using Single_LINQ_Extension_Method;
using System.ComponentModel.DataAnnotations;
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

Console.WriteLine("=========== Problem No.9 =============");
//9. Write a program in C# Sharp to find the number of elements in an array that are greater than 80 and display them in ascending order.

int[] conNumber = { 1,2,3,4, 55, 200, 740, 76, 230, 482, 95 };
var conditionalNumber = conNumber.Where(x =>x>80)
    .OrderBy(x => x)
    .ToList();

foreach (var x in conditionalNumber)
{
    Console.Write(" "+x );
}
Console.WriteLine();
Console.WriteLine("=========== Problem No.11 =============");
//11. Write a program in C# Sharp to find the top three numbers from an array.

var topThree = conNumber.OrderByDescending(x => x)
    .Take(3);


foreach (var x in topThree)
{
    Console.Write(" " + x);
}
Console.WriteLine();


string st = "Eakub";
var y = st.Any(i => char.IsLower(i)) ? st.ToLower()
    : st.ToUpper();

Console.WriteLine(y);

Console.WriteLine("=========== Problem No.12 =============");
//12. C# Sharp to find uppercase words in a string.

string line = " this IS a STRING";
var words = line.Split(' ')
    .Select(upWord => upWord.Any(i => char.IsLower(i)) ? "" : upWord)
    .Where(x => x!= "")  //Where(x => !string.IsNullOrEmpty(x))  -- or use it
    .ToList();

foreach (var x in words)
{
    Console.WriteLine(x);
}

Console.WriteLine("============= Problem No.14 ===============");
//14.C# Sharp to find the n-th maximum grade point achieved by the students

List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Eakub", Address = "Dhaka", CGPA = 3.5 },
    new Student { Id = 2, Name = "Rafiq", Address = "Chittagong", CGPA = 3.8 },
    new Student { Id = 3, Name = "Sadia", Address = "Sylhet", CGPA = 3.9 },
    new Student { Id = 4, Name = "Rahim", Address = "Rajshahi", CGPA = 3.6 },
    new Student { Id = 5, Name = "Karim", Address = "Khulna", CGPA = 3.7 },
    new Student { Id = 6, Name = "Sakib", Address = "Barisal", CGPA = 3.4 },
    new Student { Id = 7, Name = "Rafi", Address = "Comilla", CGPA = 3.2 },

};

var sta = students.Where(x => x.CGPA >= 3.5)
    .Select(chatro => new {chatro.Id,chatro.Name,chatro.Address,chatro.CGPA});
foreach (var x in sta)
{
    Console.WriteLine(x);
}


Console.WriteLine("=========== Problem No.15 =============");
//15. C# Sharp to count file extensions and group it using LINQ.

string[] filearr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

var ff = filearr1.GroupBy(x => x.Split('.').Last().ToLower())
    .Select(g => new { Extention = g.Key, Count = g.Count() })
    .OrderBy(x => x.Count);
foreach (var x in ff)
{
    Console.WriteLine($"File Extension: {x.Extention}, Count: {x.Count}");
}

Console.WriteLine("=========== Problem No.16 =============");

//16. show file size and dile name
string[] dirFile = Directory.GetFiles(@"E:\Backgroud Pic");
var fileSize = dirFile.Select(file => new {name = Path.GetFileName(file), size =new FileInfo(file).Length });

var fileSizeKB = dirFile.Select(file => new
{
    FileName = Path.GetFileName(file),
    SizeKB =Math.Round( new FileInfo(file).Length / 1024.0) // Convert bytes to kilobytes
});

foreach (var x in fileSizeKB)
{
    Console.WriteLine(x);
}

Console.WriteLine("=========== Problem No.17 =============");
// C# Sharp to remove items from list without using remove function
//C# Sharp to remove a range of items from a list by passing the start index and number of elements to remove.
//List<string> listOfString = new List<string>();
// Add strings to the list
List<string> listOfString = ["man", "name", "opp", "p", "q"];
listOfString.Add("r");
listOfString.Add("s");
listOfString.Add("t");
listOfString.Add("u");
listOfString.Add("v");
listOfString.Add("w");

listOfString.RemoveRange(6, 3); // This will remove 3 items starting from index 1

var ss = listOfString.Select(x => x.Length > 1 ? x.Remove(1, 1) : x)
    .Where((x, index) => index != 3)
    .ToList();

  // This will remove 3 items starting from index 1
foreach (var x in ss)
{
    Console.WriteLine(x);
}


Console.WriteLine("=========== Problem No.18 =============");
List<int>? Skill = [1, 2, 3, 4, 5, 6];
var s1 = Skill.Any() ? "Eakub" : "Rafiq";
var s2 = Skill.Count() > 0 ? "Eakub" : "Rafiq";
var s3 = Skill is null ? "Eakub" : "Rafiq";

Console.WriteLine(s1 + s2 + s3);