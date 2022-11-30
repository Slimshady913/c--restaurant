// 교수님은 list에 tuple로 받으심

using System;

public class Server : Worker
{
    public int ownerMoney = 0;
    public List<String> menulist = new List<String>();
    public Server(string _job) : base(_job)
    {
    }

    public void getOrder(Menu menu, int num, Customer customer)
    {
        for (int i = 0; i < num; i++)
        {
            menulist.Add(menu.menu);
        }
        System.Console.WriteLine(this.job + " gets order from " + customer.job + ".");
    }
    public void passOrder(Cook cook)
    {
        System.Console.WriteLine(this.job + " passes order to the Cook.");
        cook.giveFood(this);
    }
    public void serveFood(Customer customer)
    {
        System.Console.WriteLine(this.job + " gives food to " + customer.job + ".");
    }
    public void receiveMoney(int csmoney, Customer customer)
    {
        ownerMoney += csmoney;
        System.Console.WriteLine(this.job + " receives {0} won from {1}.", csmoney, customer.job);
    }
    public void giveMoney(Owner owner)
    {
        System.Console.WriteLine(this.job + " gives " + ownerMoney + "won to the owner.");
        owner.receiveMoney(this, ownerMoney);
        ownerMoney = 0;
    }
}
