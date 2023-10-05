
using System.Text.RegularExpressions;

Product product = new Product(() => new ProductOptions() { ProductNamePattern = @"\b[F]\w+" });

// will be throw exception for value that "furkan" because "furkan" isn't started with "F" letter.
product.ProductName = "furkan";
System.Console.WriteLine(product.ProductName);


delegate T ConfigurationOptionsHandler<T>() where T : class, new();
record ProductOptions
{
    //Create a pattern for a word that starts with the letter "M"
    public string ProductNamePattern { get; init; } = @"\b[M]\w+";
}

class Product
{
    private readonly ProductOptions _productOptions;
    private string productName = string.Empty;
    public string ProductName
    {
        get => productName;
        set
        {
            Regex rg = new Regex(_productOptions.ProductNamePattern);
            if (!rg.Match(value).Success)
                throw new Exception(message: "Product name isn't matched to regex pattern");

            productName = value;
        }
    }

    public Product(ConfigurationOptionsHandler<ProductOptions> configurationOptionsHandler)
    {
        _productOptions = configurationOptionsHandler.Invoke();
    }
}
