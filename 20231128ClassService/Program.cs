using _20231128ClassService.Interface;
using _20231128ClassService.Model;
using _20231128ClassService.Services;

ShopItemService shopItemService = new ShopItemService();
Class1 class1 = new Class1(); //kitas servisas

ShopItem shopItem = new ShopItem();
shopItem.Name = "Vardas";
shopItem.Age = 30;

ShopItem shopItem2 = new ShopItem();
shopItem2.Name = "Vardasaaaa";
shopItem2.Age = 35;

class1.ShowAge(shopItem);
class1.ShowAge(shopItem2);
shopItemService.ShowAge(shopItem);
shopItemService.ShowAge(shopItem);