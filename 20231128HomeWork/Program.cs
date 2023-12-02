using _20231128HomeWork.Interfaces;
using _20231128HomeWork.Models;
using _20231128HomeWork.Services;
using System;
using System.IO;

IFileService _fileService = new FileService();
_fileService.ReadFile();

ShopItemService shopItemService = new ShopItemService();
FileService fileService = new FileService();
double balance = 20;

shopItemService.MakeShoppingItemsList();

shopItemService.DisplayItems();

while (true)
{
    Console.WriteLine("Iveskite komanda:");
    string input = Console.ReadLine();

    string command = (input.Split(" ")[0]).Trim().ToLower();
    string[] fullCommand = input.Split(" ");
 
    //String payload = input.Split(" ");
    switch (command)
    {
        case "add":
            if (fullCommand.Length == 3)
            {
                fullCommand[1].Trim().ToLower();
                double price = double.Parse(fullCommand[2].Trim().ToLower());
                shopItemService.Add(fullCommand[1], price);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("!!!!!!!!!!!\n Product added Successfully \n!!!!!!!! ");
                Console.BackgroundColor = ConsoleColor.Black;
                shopItemService.DisplayItems();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorect input format to add data");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            break;
        case "remove":
            if (fullCommand.Length == 2)
            {
                shopItemService.Remove(fullCommand[1]);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("!!!!!!!!!!!\n Product removed Successfully \n!!!!!!!! ");
                Console.BackgroundColor = ConsoleColor.Black;
                shopItemService.DisplayItems();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorect input format to remove data");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            break;
        case "buy":
            if (fullCommand.Length == 2)
            {
                shopItemService.Buy(fullCommand[1]);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("!!!!!!!!!!!\n Product bought Successfully \n!!!!!!!! ");
                Console.BackgroundColor = ConsoleColor.Black;
                shopItemService.DisplayItems();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorect input format to buy product");
                Console.BackgroundColor = ConsoleColor.Black;
            }
           
            break;
        case "show":
            if (fullCommand[1].Trim().ToLower() == "balance")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"{balance.ToString("0.00")} EUR");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("komanda neatpazinta");
            }
            break;
        case "topup":
            if (fullCommand.Length == 2)
            {
                string ammount = fullCommand[1].Replace(".", ",");
                balance += Double.Parse(ammount);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Balance topedUp to {balance.ToString("0.00")} EUR");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            break;
        case "displayitems":
            shopItemService.DisplayItems();
            break;
        case "exit":
            fileService.WriteToFile(shopItemService.GetAllItems());
            break;
        default:
            Console.WriteLine("komanda neatpazinta");
            break;
    }
}


//try
//{
//    StreamReader sr = new StreamReader();
//    String line = sr.ReadLine();

//    while (line != null)
//    {
//        Console.WriteLine(line);
//        line = sr.ReadLine();
//    }
//    sr.Close();
//}
//catch (Exception e)
//{
//    Console.WriteLine("Exception: " + e.Message);
//}
//finally
//{
//    Console.WriteLine("Executing finally block.");
//}