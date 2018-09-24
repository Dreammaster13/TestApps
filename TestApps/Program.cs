using System;
class emp
{
    public string name;
    public string address;
    public void display()
    {
        Console.WriteLine("{0} is in city {1}", name, address);
    }
}
class Program
{
    static void Main(string[] args)
    {
        emp obj = new emp();
        obj.name = "Akshay";
        obj.address = "new delhi";
        obj.display();
        Console.ReadLine();
    }
}