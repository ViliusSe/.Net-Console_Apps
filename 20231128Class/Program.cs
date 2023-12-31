﻿using _20231128Class;
using _20231128Class.Array;
using _20231128Class.Extention;
using _20231128Class.Paveldejimas;


Console.WriteLine("Kelimas kvadratu");
List<int> skaiciai = new List<int> { 1, 2, 3, 4, };

skaiciai.Select(sk => sk * sk).ToList().ForEach(sk => Console.WriteLine(sk));


Console.WriteLine("neigiamu atrinkimas");
List<int> numbers = new List<int> { 1, 2, -3, -4, 5, -6 };

numbers.Where(sk => sk < 0).ToList().ForEach(sk => Console.WriteLine(sk));






//1Task
int number = 5;
Console.WriteLine(number.IsPositive());

//4Task
string tekstas = "asdk asdkl";
Console.WriteLine(tekstas.HasSpace());

//5 
int[,] masyvas = { { 1, 2, 3 }, { 2, 4, 1 } };
DvigubasMasyvas dvigubasMasyvas = new DvigubasMasyvas();
dvigubasMasyvas.RepeatingNumbers(masyvas);
Console.WriteLine();

//Inheritance

Car masina = new Car();
masina.Name = "tutu";
masina.Drive();


//Dictionarry

Dictionary<string, int> sarasas = new Dictionary<string, int>();
sarasas.Add("Jonas", 35);
sarasas.Add("Petras", 20);
sarasas.Add("Antanas", 24);

foreach(var irasas in sarasas) { Console.WriteLine(irasas); }

Dictionary <string, string> countries = new Dictionary<string, string>();
countries.Add("Lietuva", "Vilnius");
countries.Add("Madagaskaras", "Antanarivas");
countries.Add("Lenkija", "Varsuva");

Console.WriteLine("Duok Valstybe");
string valst = Console.ReadLine();

foreach(var item in countries)
{
    if (valst == item.Key)
    {
        Console.WriteLine(item.Value);
    }
}