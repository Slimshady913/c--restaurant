using System;

public class Person {
    public string job;

    public Person(string _job) {
        job = _job;        
    }

    ~Person() {
        System.Console.WriteLine("Instance removed.");
    }
}
