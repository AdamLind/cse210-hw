using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // ========================= Order #1 =========================
        Address a1 = new Address("123 North Main St", "New York City", "NY", "USA");
        Customer c1 = new Customer("Andrew", a1);
        Product p11 = new Product("Plastic Cups", 123132, 1, 20);
        Product p12 = new Product("Fancy Chocolate", 234432, 25, 2);
        Order o1 = new Order(c1);
        o1.AddProduct(p11);
        o1.AddProduct(p12);

        o1.PrintPackingLabel();
        o1.PrintShippingLabel();

        // ========================= Order #2 =========================
        Address a2 = new Address("432 South Bridge", "Amsterdam", "AMS", "NL");
        Customer c2 = new Customer("Frankie", a2);
        Product p21 = new Product("1oz Gold Bullion", 879574, 3017, 50);
        Product p22 = new Product("25 KG Dumbbells", 844847, 50, 2);
        Product p23 = new Product("Stainless Steel Baseball Bat", 947476, 40, 1);
        Order o2 = new Order(c2);
        o2.AddProduct(p21);
        o2.AddProduct(p22);
        o2.AddProduct(p23);

        o2.PrintPackingLabel();
        o2.PrintShippingLabel();
    }
}