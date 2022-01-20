struct Article
{
    public string ProductName { get; set; }

    public decimal ProductCode { get; set; }

    public double Price { get; set; }
}

struct Client
{
    public decimal ClientCode { get; set; }

    public string FullName { get; set; }

    public string Address { get; set; }

    public long Telephone { get; set; }

    public Article[] NumberOfOrdersByTheClient { get; set; }

    public double TotalAmontOfOrders { get; set; }
}