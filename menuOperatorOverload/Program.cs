using System;

public class MenuItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public MenuItem(string name, int quantity, decimal price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public static bool operator ==(MenuItem item1, MenuItem item2)
    {
        return item1.Name == item2.Name && item1.Price == item2.Price;
    }

    public static bool operator !=(MenuItem item1, MenuItem item2)
    {
        return !(item1 == item2);
    }

    public static MenuItem operator *(MenuItem item, int quantity)
    {
        item.Quantity *= quantity;
        return item;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Quantity: {Quantity}, Price: {Price:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MenuItem menuItem1 = new MenuItem("The Townie", 5, 9.99m);
        MenuItem menuItem2 = new MenuItem("Brunch Burger", 3, 12.99m);

        Console.WriteLine("Original Menu Items:");
        menuItem1.Display();
        menuItem2.Display();
        Console.WriteLine();

        Console.WriteLine("Using Comparison Operators:");
        Console.WriteLine($"menuItem1 == menuItem2: {menuItem1 == menuItem2}");
        Console.WriteLine($"menuItem1 != menuItem2: {menuItem1 != menuItem2}");
        Console.WriteLine();

        Console.WriteLine("Using Binary Operator *:");
        menuItem2 = menuItem2 * 2;
        menuItem2.Display();
    }
}