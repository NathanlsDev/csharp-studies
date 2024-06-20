namespace ProductManager
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Qtd;

        public Product(string name, double price, int qtd) 
        { 
            Name = name;
            Price = price;
            Qtd = qtd;
        }

        public double TotalValueStock(double price, int qtd) 
        {
            return price * qtd;
        }

        public override string ToString()
        {
            return $"Name: {Name} | Price: ${Price.ToString("F2")} | Quantity: {Qtd} | Total value stock: {TotalValueStock(Price, Qtd).ToString("F2")}.";
        }


        public void AddProduct(int units) 
        {
            Qtd += units;
        }

        public void RemoveProduct(int units)
        {
            Qtd -= units;
        }
    }
}
