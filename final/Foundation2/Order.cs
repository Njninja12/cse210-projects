public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = products.Sum(product => product.GetPrice());
        totalCost += customer.IsInUSA() ? 5 : 35; // Shipping cost
        return totalCost;
    }

    public string GetPackingLabel()
    {
        return string.Join("\n", products.Select(product => product.ToString()));
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress()}";
    }
}