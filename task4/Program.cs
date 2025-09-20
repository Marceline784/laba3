using System;
using System.Collections.Generic;
public class Employee
{
    private string name;
    private float salary;
    private string position;
    private string department;
    private string email;
    private int age;
    public string Name { get; set; }
    public float Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public Employee(string name, float salary, string position, string department,
                   string email = "N/A", int age = -1)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Email = email;
        Age = age;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"{name} {salary:F2} {email} {age}");
    }
    public static float AverageSalary(List<Employee> employees, string department)
    {
        float sum = 0;
        int count = 0;
        for (int i = 0; i < employees.Count; i++)
        {
            if (employees[i].Department == department)
            {
                sum += employees[i].Salary;
                count++;
            }
        }
        if (count == 0) return 0; 
        return sum / count;
    }

}
class Program
    {
        static void Main()
        {
        //Console.Write("Enter number: ");
        //int n = int.Parse(Console.ReadLine());

        //List<Employee> employees = new List<Employee>();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Enter name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Enter salary: ");
        //    float salary = float.Parse(Console.ReadLine());

        //    Console.Write("Enter position: ");
        //    string position = Console.ReadLine();

        //    Console.Write("Enter department: ");
        //    string department = Console.ReadLine();

        //    Console.Write("Enter email (or leave empty): ");
        //    string email = Console.ReadLine();
        //    if (email == null || email == "")
        //    {
        //        email = "n/a";
        //    }
        //    Console.Write("Enter age (or leave empty): ");
        //    string ageInput = Console.ReadLine();
        //    int age;
        //    if (ageInput == null || ageInput == "")
        //    {
        //        age = -1;
        //    }
        //    else
        //    {
        //        age = int.Parse(ageInput);
        //    }

        //    Employee emp = new Employee(name, salary, position, department, email, age);
        //    employees.Add(emp);
        //}
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Pesho", 120.00f, "Dev", "Development", "pesho@abv.bg", 28),
            new Employee("Toncho", 333.33f, "Manager", "Marketing", "n/a", 33),
            new Employee("Ivan", 840.20f, "ProjectLeader", "Development", "ivan@ivan.com"),
            new Employee("Gosho", 0.20f, "Freeloader", "Nowhere", "n/a", 18)
        };

        List<Employee> topEmployees = new List<Employee>();
        float highestAvgSalary = 0;
        for (int i = 0; i < employees.Count; i++)
        {
            string current = employees[i].Department;
            float avgSalary = Employee.AverageSalary(employees, current);
            if (avgSalary > highestAvgSalary)
            {
                highestAvgSalary = avgSalary; 
                topEmployees.Clear();

                for (int j = 0; j < employees.Count; j++)
                {
                    if (employees[j].Department == current)
                        topEmployees.Add(employees[j]);
                }
            }
        }
        for (int i = 0; i < topEmployees.Count - 1; i++)
        {
            for (int j = 0; j < topEmployees.Count - i - 1; j++)
            {
                if (topEmployees[j].Salary < topEmployees[j + 1].Salary)
                {
                    Employee temp = topEmployees[j];
                    topEmployees[j] = topEmployees[j + 1];
                    topEmployees[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nEmployees in the department with highest average salary:");
        for (int i = 0; i < topEmployees.Count; i++)
        {
            topEmployees[i].PrintInfo();
        }
    }
    }