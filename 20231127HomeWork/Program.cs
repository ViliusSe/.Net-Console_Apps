using _20231127HomeWork;

ShopItem shopItem1 = new ShopItem();
ShopItem shopItem2 = new ShopItem();

shopItem1.Name = "Candies";
shopItem1.Description = "very sweet";
Tag item1Tag1 = new Tag("unhealhy");
Tag item1Tag2 = new Tag("food");
shopItem1.Tags.Add(item1Tag1);
shopItem1.Tags.Add(item1Tag2);
shopItem1.Price = 2.22;

shopItem2.Name = "Soda";
shopItem2.Price = 2.22;
shopItem2.Description = "very sweet";
Tag item2Tag1 = new Tag("beverage");
Tag item2Tag2 = new Tag("food");
shopItem2.Tags.Add(item2Tag1);
shopItem2.Tags.Add(item2Tag2);

Console.WriteLine(shopItem1.ToString());
Console.WriteLine(shopItem2.ToString());



List<ShopItem> shopItemsList = new List<ShopItem>();
shopItemsList.Add(shopItem1);
shopItemsList.Add(shopItem2);


//Writing to file
foreach (ShopItem item in shopItemsList)
{
    File.AppendAllText(@"C:/Users/v.senkus/Desktop/ShopItems.txt", item.ToString());
}

//Compearing Tags
string CompareShopItemsTags(List<Tag> firstList, List<Tag> secondList)
{
    List<string> tags1 = new List<string>();
    foreach (Tag obj in firstList)
    {
        tags1.Add(obj.Name);
    }
    List<string> tags2 = new List<string>();
    foreach (Tag obj in secondList)
    {
        tags2.Add(obj.Name);
    }
    List<string> commonTags = new List<string>();
    foreach (string item1 in tags1)
    {
        foreach (string item2 in tags2)
        {
            if (item1.Equals(item2))
            {
                commonTags.Add(item1);
            }
        }
    }
    string text = "";
    foreach (string item in commonTags)
    {
        text += item;
    }
    return text;
}

string CompareTags(Tag tag1, Tag tag2)
{
    return tag1.Name == tag2.Name ? $" Tags {tag1.Name} are the same" : "Tags are different";
    
}

//Creating object with constructor
string[] arr = { "food", "sweet" };
ShopItem shopitem3 = new ShopItem(arr, "Product3", "very good product", 2.35);


Tag compareTag1 = new Tag("eatable");
Tag compareTag2 = new Tag("drink");
Tag compareTag3 = new Tag("drink");

Console.WriteLine("Comparing Tags");
Console.WriteLine(CompareTags(compareTag1, compareTag2));
Console.WriteLine(CompareTags(compareTag3, compareTag2));

Console.WriteLine("Comparing products");
Console.WriteLine(CompareShopItemsTags(shopItem1.Tags, shopItem2.Tags));

