string someProducts = "kartoshka, sosiska, bagato hliba, slabo-solenii ogurchik, yakiis tortik/pirog";
Console.WriteLine(someProducts);

// прибирає знаки між словами
string result = someProducts
    .Replace(" ", "")
    .Replace(",", "")
    .Replace("-", "")
    .Replace(", ", "")
    .Replace(".", "")
    .Replace("/", "");

Console.WriteLine(result);