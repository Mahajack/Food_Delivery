using System;

class Details
{
    private int _id;
    private string _name;
    private int _age;
    private int _salary;
    
    public void SetId(int Id)
    {
        if(Id <= 0)
        {
            throw new Exception("Student ID cannot be Negative");
        }
        this._id = Id;
    }
    public int GetId()
    {
        return this._id;
    }
    public void SetName(string Name)
    {
        if(string.IsNullOrEmpty(Name))
        {
            throw new Exception("Student Name cannot be Null");
        }
        this._name = Name;
    }
    public string GetName()
    {
        return this._name;
    }
    public void SetAge(int Age)
    {
        if(Age <= 0)
        {
            throw new Exception("Enter a valid Age");
        }
        this._age = Age;
    }
    public int GetAge()
    {
        return this._age;
    }
    public void SetSalary(int Salary)
    {
        this._salary = Salary;
    }
    public int GetSalary()
    {
        return this._salary;
    }
    
    public class Students
    {
       static void Main()
       {
           Details s1 = new Details();
           s1.SetId(100);
           s1.SetName("Maha");
           s1.SetAge(22);
           s1.SetSalary(15000);
          Console.WriteLine("Employee ID = {0}", s1.GetId());
          Console.WriteLine("Employee Name = {0}", s1.GetName());
          Console.WriteLine("Employee Age = {0}", s1.GetAge());
          Console.WriteLine("Employee Salary = {0}", s1.GetSalary());
       }
    }
}
