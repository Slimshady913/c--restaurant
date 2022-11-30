using System;

public class Customer : Person
{
    public int payMoney = 0;

    public Customer(string _job) : base(_job)
    {
    }

    public void orderFood(Menu menu, int num, Server server)
    {
        System.Console.WriteLine(this.job + " orders {0} {1} to {2}.", num, menu.menu, server.job);
        for (int i = 0; i < num; i++)
        {
            payMoney += menu.price;    //Menu().menulist[food]
        }
    }
    public void giveMoney(Server server)
    {
        server.receiveMoney(payMoney, this);
        payMoney = 0;
        //System.Console.WriteLine(this.job + " gives {0} won to the server.", payMoney);
    }
}