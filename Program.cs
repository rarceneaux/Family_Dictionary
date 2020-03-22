using System;
using System.Collections.Generic;

namespace Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });*/
           var famMembers = new Dictionary<string,int>();

           famMembers.Add("Master P", 8);
           famMembers.Add("Chan", 5);
           /*famMembers.Add("Super Chan", new Dictionary<string, string>() { { "name", "Chan" }, { "age", "5" } });*/
            foreach (var (name, age) in famMembers)
           {
               Console.WriteLine($"{name} is my son and is {age} years old.");
           }
        }
    }
}
