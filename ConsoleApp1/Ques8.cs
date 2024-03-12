using System;
 
namespace Ques8; 
public class Class1
{
	public string name;
	public Class1() { }
	public Class1(string name) {
		Console.WriteLine($"Passed name: {name}");
		this.name = name;
	}
	public Class1(Class1 c1)
	{
        this.name = c1.name;
		Console.WriteLine($"Copied name {name} to new object");
    }
}

public class Ques8Demo
{
	public static void Run()
	{
		Class1 c11 = new Class1();
		Class1 c12 = new Class1("Sujal");
		Class1 c13 = new Class1(c12);
	}
}
