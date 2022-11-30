using System;

public class Cook : Worker
{
    public Cook(string _job) : base(_job)
    {
    }

    public void giveFood(Server server)
    {
        System.Console.WriteLine(this.job + " gives food to " + server.job + ".");
    }
}