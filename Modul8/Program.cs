// See https://aka.ms/new-console-template for more information

using Modul8;

Console.WriteLine("Hello, World!");

Midtvejsopgaver opg = new Midtvejsopgaver();
List<Item> all = opg.GetAll();
Console.WriteLine("All:");
opg.PrintItems(all);

Console.WriteLine();
Console.WriteLine("In stock:");
List<Item> itemsInStock = opg.ItemsInStock(all);
opg.PrintItems(itemsInStock);

Console.WriteLine();
Console.WriteLine("By color - only green and red:");
List<Item> itemsByColor = opg.ItemsWithColor(all, new[] { "green", "red" });
opg.PrintItems(itemsByColor);

