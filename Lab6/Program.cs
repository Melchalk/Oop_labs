using oop6;

Product product = new()
{
    Title = "Молоко",
    Quantity = 140,
};

Product product1 = new()
{
    Manufacturer = "Домик в деревне",
    Price = 63,
};

//Не nullable будут проиндексированы стандартными значениями, для Title это null
Console.WriteLine(product.GetInfo());
Console.WriteLine(product1.GetInfo());

// ! - Non-Nullable, без него предупреждение о присваении null
product1.Title = null!;

//С значимыми типами ! не помогает
//product.Discount = null!;

//Без предпреждения, так как названия не должно иметь значение null
int count = product.Title.Length;
//int count2 = product1.Title.Length; //Выдаст исключение

Product? product2 = null;

Console.WriteLine(Product.GetManufacturer(product));
Console.WriteLine(Product.GetManufacturer(product1));
Console.WriteLine(Product.GetManufacturer(product2));
Console.WriteLine();

Product.IfNull(product);
Console.WriteLine(product.GetInfo());