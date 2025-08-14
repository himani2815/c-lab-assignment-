using ConsoleApp4;
using System;
namespace ConsoleApp4
{
    class employee
    {
        public String name = "hina";
        public int  age = 22;
        public double salary = 170000;
      /
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);


        }

    }
}
 class Program
{
    static void Main(String[] args)
    {
        employee emp = new employee();
        emp.display();
    }
}
    
      

