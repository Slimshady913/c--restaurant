using System;

public class Worker: Person {
    public Worker(string _job): base(_job) {
    }
      
    public void getPaid() {
         System.Console.WriteLine(this.job + " gets paid.");
    }
}