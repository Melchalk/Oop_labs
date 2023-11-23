namespace oop6;

internal class Product
{
    //подавление серьезности
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public string Title { get; set; }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public double Price { get; set; }
    public int Discount { get; set; }
    public string? Manufacturer { get; set; }
    public int? Quantity { get; set; }
    public double? Code { get; set; }

    readonly static string _isNull = "Не задано";

    public string GetInfo()
    {
        string _info = $"Название продукта - {Title}\n" +
            $"Стоимость - {Price}\n" +
            $"Скидка - {Discount}\n" +
            $"Производитель - {Manufacturer ?? _isNull}\n";

        string _countInfo = "Количество - {0}\n";
        string _codeInfo = $"Код продукта - {_isNull}\n";

        _info += Quantity is null
            ? string.Format(_countInfo, _isNull)
            : string.Format(_countInfo, Quantity);

        _info += Code is null
            ? string.Format(_codeInfo, _isNull)
            : string.Format(_codeInfo, Code);

        return _info;
    }

    public static void IfNull(Product product)
    {
        product.Manufacturer ??= _isNull;
        product.Quantity ??= 0;
        product.Code ??= 0;
    }

    public static string GetManufacturer(Product? product)
    {
        return product?.Manufacturer ?? _isNull;
    }
}