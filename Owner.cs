using System;

public class Owner : Person
{
    public int money;
    public Owner(string _job, int _money) : base(_job)
    {
        this.money = _money;
    }

    public void receiveMoney(Server server, int daymoney)
    {
        this.money += daymoney;
        System.Console.WriteLine(this.job + " receives {0} won from {1}.", daymoney, server.job);
    }
    public void paySalary(int salary, int num)
    {
        var total = salary * num;
        this.money -= total;
        System.Console.WriteLine(this.job + " pays a total salary of {0} won to the worker.", total);
    }
    public void leftMoney()
    {
        System.Console.WriteLine(this.job + " has " + this.money + " won.");
    }
}