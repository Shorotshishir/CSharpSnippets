using System;
using System.Collections.Generic;
using System.IO;

public class MyClass //class name
{
    public string MyMessage()
    {
        return $"{this} is a non-static method";
    }
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    private string home;
    public string Home
    {
        get { return home; }
        set { home = value; }
    }
}