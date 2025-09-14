using System;
using System.Collections.Generic; // Потрібно для використання List<T>
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
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
public class Family
{
    private List<Person> members = new List<Person>();
    public void AddMember(Person member)
    {
        members.Add(member); // додає Person у список
    }

    public Person GetOldestMember()
    {
        Person eldest = members[0];
        for (int i = 0; i < members.Count; i++)
        {
            // Якщо поточний вік більше, ніж у "найстаршого"
            if (members[i].Age > eldest.Age)
            {
                eldest = members[i];
            }
        }
        return eldest;

    }
}
class Program
{
    static void Main()
    {
        Family family = new Family();
        Console.WriteLine("Enter people: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();  

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            // Створюємо новий об'єкт Person
            Person person = new Person(name, age);
            family.AddMember(person);
        }
        // Отримуємо найстаршого члена сім'ї
        Person eldest = family.GetOldestMember();
        Console.WriteLine($"{eldest.Name} {eldest.Age}");
    }
}

