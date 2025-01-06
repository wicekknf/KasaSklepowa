// See https://aka.ms/new-console-template for more information
using KasaSklepowa;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

Display.WelcomeDisplay();
// stworzenie koszyka-listy użytkownika
List<Product> productsUser = new List<Product>();

//ścieżka do pliku JSON z bazą produktów
var path = $"{Directory.GetCurrentDirectory()}\\ProductsFile.json";
Console.WriteLine(Directory.GetCurrentDirectory());

// odczytywanie produktów do listy products
string json = File.ReadAllText(path);
List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

Console.WriteLine("Dostępne produkty:");
foreach (var product in products)
{
    Console.WriteLine($"{product.ProductName}; {product.Price}zł - kod towaru {product.ProductNumber}");
}

//stworzenie zmiennej do wyboru użytkownika
string choiceUser = null;

//pętla do obsługi zakupu
while (choiceUser != "x")
{
    Display.AskForNumber();
    choiceUser = Console.ReadLine();
    var item = products.FirstOrDefault(i => i.ProductNumber == choiceUser);
    
    if (item != null)
    {
        productsUser.Add(item);
        Display.AddedProduct();
    } else
    {
        Display.WrongProductNumber();
    }
}
double shoppingCart = 0;

foreach (var product in productsUser)
{
    shoppingCart += product.Price;
}

Console.WriteLine("Zakupiłeś:");

foreach (var product in productsUser)
{
    Console.WriteLine($"{product.ProductName}, {product.Price}");
}

Console.WriteLine($"Suma do zapłacenia: {shoppingCart}zł");







//zapisywanie do pliku JSON kolejnych produktów
//string serializedProducts = JsonConvert.SerializeObject(products1);
//File.WriteAllText(path, serializedProducts);




