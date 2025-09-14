using System;
public class Person
{
    private string name;
    private int age;

    // Властивість для доступу до поля name
    public string Name
    {
        get { return name; } // повертає значення
        set { name = value; } // встановлює значення
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person()
    {
        name = "NoName";
        age = 0;
    }
    public Person(string name, int age)
    {
        // this. використовується, щоб відрізнити поле класу від параметра
        this.name = name;
        this.age = age;
    }
}
class Program
{
    static void Main()
    {
        Person person1 = new Person();
        person1.Name = "Pesho";
        person1.Age = 20;
        Person person2 = new Person("Gosho", 18);
        Person person3 = new Person("Stamat", 43);
        Console.WriteLine($"{person1.Name} {person1.Age}");
        Console.WriteLine($"{person2.Name} {person2.Age}");
        Console.WriteLine($"{person3.Name} {person3.Age}");
    }
}

