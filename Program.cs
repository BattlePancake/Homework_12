//---------------------------- Task 1 -------------------------------

// var words = new List<string>() {"aa","b","cc","d","ee","f","gg","h"};

// var search = words.FirstOrDefault(s => s.Length == 1);

// Console.WriteLine(search);

//---------------------------- Task 2 -------------------------------

// var words = new List<string>() {"aaee","b","ccee","d","ee","f","ggee","h"};

// var search = words.LastOrDefault(s => s.Contains("ee"));

// Console.WriteLine(search);

//---------------------------- Task 3 -------------------------------

// var words = new List<string>() {"aaee","b","ccee","dttyyeeccbb","eerrttyy","f","ggee","h"};

// int minLength = words.Min(s => s.Length);
// int maxLength = words.Max(s => s.Length);


// var search = words.Where(s => s.Length > minLength).Where(s1 => s1.Length < maxLength).LastOrDefault();

// if (search != null)
// {
//     Console.WriteLine(search);
// }

//---------------------------- Task 4 -------------------------------

// var words = new List<string>() {"ggee","b","ccee","ggee","eerrttyy","f","ggee","ggee"};

// var search = words.Distinct().Count();

// Console.WriteLine(string.Join(",", search - 1));

//---------------------------- Task 5 -------------------------------

// var words = new List<string>() {"5ggee2","b","5ccee4","ggee","5eerrttyy3","f","ggee","5ggee1"};

// var search = words.Where(s => s.StartsWith("5")).Where(s1 => s1.EndsWith("3")).ToArray();

// Console.WriteLine(string.Join(",", search));

//---------------------------- Task 6 -------------------------------

// var words = new List<string>() {"ggee","b","ccee","ggee","eerrttyy","ffgfgfgfgf","ggee","ggee"};

// int minLength = words.Min(m => m.Length);

// Console.WriteLine(minLength);

//---------------------------- Task 7 -------------------------------

//using System.Runtime.Intrinsics.Arm;
//using Homework_12;

//var dict = new Dictionary<int, string>()
//{
//    {1, "1Vit"},
//    {2, "2Vita"},
//    {3, "3Vital"},
//    {4, "4Vitaliy"},
//};

//// var search = dict.Select(s => s = new KeyValuePair< int, string >(s.Key,s.Value)).ToList();
//// тут не получилось поменять местами ключ и значение

//var sortList = new List<KeyValuePair<string, int>>()
//{
//};

//foreach (var a in dict)
//{
//    sortList.Add(new KeyValuePair<string, int>(a.Value, a.Key));
//}

//Console.WriteLine(string.Join(" , ", sortList));

//---------------------------- Task 8 -------------------------------

using Homework_12;

var users = new List<User>()
{
    new User()
    {
        FirstName = "Vlados",
        MiddleName = "Vladosovich",
        LastName = "Vladosov"
    },
    new User()
    {
        FirstName = "Gleb",
        LastName = "Glebov"
    },
    new User()
    {
        FirstName = "Max",
        LastName = "Maximov"
    },
    new User()
    {
        FirstName = "Vitaly",
        MiddleName = "Vitalevich",
        LastName = "Vitaliev"
    },
};

// var search = users.Select(s => new {Name = s.FirstName, Middle = s.MiddleName, Last = s.LastName}).ToArray();

// foreach(var a in search)
// {
//     Console.WriteLine($"{a.Name} {a.Middle} {a.Last}");
// }

//---------------------------- Task 9 -------------------------------

var newSearch = users.OrderByDescending(s => s.LastName).Select(s => s).ToArray();

foreach (var a in newSearch)
{
    Console.WriteLine($"{a.LastName} {a.FirstName} {a.MiddleName}");
}