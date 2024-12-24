// See https://aka.ms/new-console-template for more information
using TaskCalculatorFunctions.Models;

Console.WriteLine("Hello, World!");

int x, y, z, workhours, hourrate, basic;
double u;
Addition addition = new Addition();

Console.WriteLine("Enter number X = ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number Y = ");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total is = " + addition.Add(x, y));
Console.WriteLine("------------------------");

Console.WriteLine("Enter number Z = ");
z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total is = " + addition.Add(x, y, z));
Console.WriteLine("------------------------");

Console.WriteLine("Enter number Z = ");
u = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total is = " + addition.Add(u, y, z));
Console.WriteLine("------------------------");

Console.WriteLine("Enter basic salary : ");
basic = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter extra work hours :  ");
workhours = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Hourly rate : ");
hourrate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total Salary This Month = " + addition.Salary(basic, workhours, hourrate));    

