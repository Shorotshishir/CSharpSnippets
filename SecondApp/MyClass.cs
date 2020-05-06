using System;
using System.Collections.Generic;
using System.IO;

public class MyClass //class name
{
    public string MyMessage()
    {
        return $"I am from a different class, named {this}";
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
    
    // public string home = "Earth";
    
    public IEnumerable<string> ReadFrom(string file)
    {
        string line;
        using (var reader = File.OpenText(file))
        {
            while ((line = reader.ReadLine()) != null)
            {
                var words = line.Split(' ');
                var linelength = 0;
                foreach (var word in words)
                {
                    yield return word;
                    linelength += word.Length + 1;
                    if (linelength>0){
                        yield return Environment.NewLine;
                        linelength=0;
                    }
                }
            }

        }
    }
}