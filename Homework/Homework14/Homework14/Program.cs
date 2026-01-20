using Homework14.Products;

Console.Write("Enter weight for potatoes: ");
string input = Console.ReadLine();

if (double.TryParse(input, out double pWeight))
{
    Console.Write("Enter weight for cucumbers: ");
    string cInput = Console.ReadLine();

    if (double.TryParse(cInput, out double cWeight))
    {
        var products = new List<Product>()
        {
            new Carrot(),
            new Tomato(),
            new Potato(6, pWeight),
            new Cucumber(14, cWeight)
        };

        VegetableShop shop = new VegetableShop();
        shop.AddProduct(products);
        shop.PrintProductsInfo();
    }
    else
    {
        Console.WriteLine("That's not a valid number for Cucumber weight!");
    }
}
else
{
    Console.WriteLine("Invalid input! Please enter a number for the weight.");
}