using System;
//using System.Collections.Generic;

public class Menu
{
    public string menu;
    public int price;

    public Menu(string _menu, int _price)
    {
        menu = _menu;
        price = _price;
    }
    ~Menu()
    {
        System.Console.WriteLine("Instance removed.");
    }
}