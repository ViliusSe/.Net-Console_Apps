// Delegates

using _20231130HomeWork;
using _20231130HomeWork.LINQ;

_20231130HomeWork.Person person1 = new _20231130HomeWork.Person("Jhon", 12);
_20231130HomeWork.Person person2 = new _20231130HomeWork.Person("Steve", 25);
_20231130HomeWork.Person person3 = new _20231130HomeWork.Person("Mark", 17);
_20231130HomeWork.Person person4 = new _20231130HomeWork.Person("Antonio", 75);
_20231130HomeWork.Person person5 = new _20231130HomeWork.Person("Sandra", 32);

List<_20231130HomeWork.Person> personslist = new List<_20231130HomeWork.Person> { person1, person2, person3, person4, person5 };

Filters f = new Filters();
FilterFunction functionIsChild = new FilterFunction(PersonService.IsChild);
FilterFunction functionIsAdult = new FilterFunction(PersonService.IsAdult);
FilterFunction functionIsSenior = new FilterFunction(PersonService.IsSenior);

f.DisplayPeople("Children", personslist, functionIsChild);
f.DisplayPeople("Adult", personslist, functionIsAdult);
f.DisplayPeople("Senior", personslist, functionIsSenior);


//LINQ

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("LINQ");
Console.BackgroundColor = ConsoleColor.Black;

LinqStarter linqStarter = new LinqStarter();
linqStarter.innerLinqMethod();

IEnumerable<string> GetText(string txt)
{
    string[] words = txt.Split(" ");
    var capitalWords = words.Where(words => words.All(char.IsUpper));
    return capitalWords;
}
Console.WriteLine("Enter text with words consist just of capital or just of lowercase letters");
string txt = Console.ReadLine();
IEnumerable<string> upper = GetText(txt);
Console.WriteLine("in given phrase words in capital letters are: ");

foreach (var i in upper)
{
    Console.WriteLine(i);
};