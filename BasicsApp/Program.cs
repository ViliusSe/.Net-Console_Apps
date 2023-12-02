using BasicsApp;

    // See https://aka.ms/new-console-template for more information

    //VARIABLES DECLARATION
    using BasicsApp;
    using System.Reflection.Metadata.Ecma335;

    int num1 = 0;
    double price = 2.2;
    string text = "some text here"; //butinai "", nenaudojama ''
    char letter = 'a';
    bool isTrue = true;

    var anything1 = 5;
    var anything2 = "ghghgh";

    //OUTPUT/INPUT

    Console.WriteLine(text);
    Console.WriteLine("ggg \n ggg");
    Console.WriteLine(Double(5, 4));
    String tekstas = Console.ReadLine();
    Console.WriteLine("ivestas tekstas, {0} pakartojam {1}", tekstas, tekstas + "fgj");
    String formatuotas = String.Format("ivestas tekstas, {0} pakartojam {1}", tekstas, tekstas + "fgj");
    Console.WriteLine(formatuotas);

    //PARSING

    string sk = "2";
    int number = int.Parse(sk);

    //FUNCTIONS
    int Double(int number1, int number2) {
        return number1 + number2;
    }

    //BOOLEAN LOGIC
    if (true) Console.WriteLine("tiesa");

    if (2 > 3)
    {
        Console.WriteLine("2>3");
    }
    else if (3 > 4)
    {
        Console.WriteLine("3>4");
    }
    else
    {
        Console.WriteLine("one more option");
    }

    switch (sk)
    {
        case "1":
            Console.WriteLine("switch - 1");
            break;
        case "2":
            Console.WriteLine("switch - 2");
            break;
        default: Console.WriteLine("switch none");
            break;
    }


    /*
     * TASK 1
     */
    void CanBuy()
    {
        Console.WriteLine("enter your age");
        String agetext = Console.ReadLine();

        int age = int.Parse(agetext);

        if (age >= 20)
        {
            Console.WriteLine("Allowed to buy");
        } else if (age < 12)
        {
            Console.WriteLine("Call parrents");
        } else
        {
            Console.WriteLine("too young to buy");
        }
    }


    //ARRAY

    int[] masyvas = { 1, 2, 3, };
    int[] array = new int[4];
    array[0] = 1;
    array[1] = 2;
    array[2] = 3;
    array[3] = 4;

    for (int i = 0; i < array.Length; i++) {
        array[i] += 2;
        Console.WriteLine(array[i]);
    }

    int j = 0;
    while (j < 2)
    {
        Console.WriteLine(j++);
        j++;
    }

    List<int> skaiciai = new List<int>();   //dar vadinama collection
    skaiciai.Add(5);
    skaiciai.Add(7);

    foreach (int skaicius in skaiciai)
    {
        Console.WriteLine(skaicius);
    }

    //OBJECTS 
    Item daiktas = new Item();
    daiktas.Name = "Masina";
    daiktas.Description = "gera masina";

    Console.WriteLine(daiktas.Name);

    List<Item> items = new List<Item>();

    items.Add(daiktas);


    // FILES

    File.WriteAllText("NaujasFailas.txt", "tekstas einanatis i faila");
    var failoTurinys = File.ReadAllLines("NaujasFailas.txt");  // grazina eiluciu masyva.

    Console.WriteLine(failoTurinys[0]);


ShopItem shopItem1 = new ShopItem();
ShopItem shopItem2 = new ShopItem();


shopItem2.Name = "Konservai";
shopItem2.Description = "Uzdarytas ir paruo6tas vartoti saldainiai";
shopItem2.SetTag("eatable");
shopItem2.SetTag("food");
shopItem2.ExpiryDate = DateTime.Now;

shopItem1.Name = "Saldainiai";
shopItem1.Description = "Labai skanus saldainiai";
shopItem1.SetTag("sweets");
shopItem1.SetTag("food");
shopItem1.ExpiryDate = DateTime.Now;


File.WriteAllText("Produktai.txt", shopItem1.ToString());
File.WriteAllText("Produktai.txt", shopItem2.ToString());

var txt = File.ReadAllLines("Produktai.txt");

Console.WriteLine;

