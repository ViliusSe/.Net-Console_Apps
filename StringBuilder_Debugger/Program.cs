using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Text;
using StringBuilder_Debugger.Paveldejimas;


//Example 1

StringBuilder sb = new StringBuilder();
sb.Append("Labas ... ");
sb.Append('(');

string result = sb.ToString();

Console.WriteLine(result);

//End of example 1

//Example 2

Stopwatch sw = Stopwatch.StartNew();
sw.Start();
 Console.WriteLine(result);
sw.Stop();
TimeSpan timeSpan = sw.Elapsed;
Console.WriteLine(timeSpan.TotalMilliseconds);

//End of example 2

Console.WriteLine("ivesti teksta");
string text = Console.ReadLine();

//Teksto apsukimas (paimant po viena simboli)
StringBuilder sb2 = new StringBuilder();

for (int i = text.Length -  1 ; i>= 0; i--)
{
    sb2.Append(text[i]);
}

result = sb2.ToString();
Console.WriteLine(result);


//Random
Random rand  = new Random();

int aRandNum1 = rand.Next();
int aRandNum2 = rand.Next(4); //iki 4 (0,1,2,3)
int aRandNum3 = rand.Next(1, 4); //nuo 1 iki 4 neimtinai (1,2,3)
double aRandNum4 = rand.NextDouble(); //iki 4 (0,1,2,3)

//Random with seed
Random randWithSeed = new Random(5);
int sededInt = randWithSeed.Next(100);

//Task 1

void GenerateNumbers()
{
    Random rnd = new Random();
    Console.WriteLine(rnd.Next(1, 11));
}
GenerateNumbers();

//Randomly generating Bool
void GenerateBool()
{
    Random rnd = new Random();
    int res = rnd.Next(2);
    bool booleanNum = Convert.ToBoolean(res);
    Console.WriteLine(booleanNum);
}

for (int i = 0; i < 10; i++)
{
    GenerateBool();
}

//Abstract and inheritence

Console.WriteLine("Enter dog name");
string dogName = Console.ReadLine();

Dog dog = new Dog();
dog.SetName(dogName);

Console.WriteLine(dog.GetName());
dog.Eat();

