class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.Name} (ID: {product.ProductId})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {customer.Name}\nAddress: {customer.CustomerAddress.GetFullAddress()}";
    }
}