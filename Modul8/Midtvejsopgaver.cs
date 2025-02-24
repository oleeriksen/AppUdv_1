namespace Modul8;

public class Midtvejsopgaver
{
    private List<Item> mItems;


    public Midtvejsopgaver()
    {
        mItems = new List<Item>()
        {
            new Item { Name = "c# for architects", Price = 200, Stock = 4, Color = "White" },
            new Item { Name = "Phyton smells", Price = 150, Stock = 200, Color = "green" },
            new Item { Name = "c++ disaster", Price = 100, Stock = 0, Color = "red" },
            new Item { Name = "Programming Pearls", Price = 1500, Stock = 2, Color = "black" },
            new Item { Name = "Really Bad Loops", Price = 450, Stock = 0, Color = "red" }
        };
    }

    public void PrintItems(List<Item> items)
    {
        foreach (Item item in items)
            Console.WriteLine($"Navn: {item.Name}, pris: {item.Price}, farve: {item.Color}, stock:{item.Stock} ");
    }

    public List<Item> GetAll()
    {
        return mItems;
    }

    public List<Item> ItemsInStock(List<Item> items)
    {
        List<Item> result = new();
        foreach (Item item in items)
            if (item.Stock > 0)
                result.Add(item);
        return result;
    }

    public List<Item> ItemsWithColor(List<Item> items, string[] colors)
    {
        List<Item> result = new();
        foreach (Item item in items)
            if (colors.Contains(item.Color))
                result.Add(item);
        return result;
    }

}