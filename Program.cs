using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Chris"},
            {"age", "41"}
            });

            myFamily.Add("wife", new Dictionary<string, string>(){
            {"name", "Beth"},
            {"age", "39"}
            });

            myFamily.Add("daughter", new Dictionary<string, string>(){
            {"name", "Raleigh"},
            {"age", "7"}
            });

            myFamily.Add("son", new Dictionary<string, string>(){
            {"name", "Parkes"},
            {"age", "5"}
            });

            // iterate over dictionary and print out details of each family member
            
            // this is refactored code, which is not dependend on the order of the inner dictionary of details. 
            foreach (KeyValuePair<string, Dictionary<string, string>> person in myFamily) 
            {
                string name = "";
                string age = ""; 
                
                foreach (KeyValuePair<string, string> details in person.Value) {
                    if (details.Key == "name") {
                        name = details.Value;
                    } else {
                        age = details.Value;
                    }
                }

                Console.WriteLine($"{name} is my {person.Key} and is {age} years old");
            }
            
            
            
            
            // this is my first idea for how to do this. This only works if the inner dictionary will always be interated over at the same order, with name being the first property. I don't think defaul dictionaries are ordered, you can use OrderedDictionary but it works differently with foreach iterations.
            // foreach (KeyValuePair<string, Dictionary<string, string>> person in myFamily) 
            // {
            //     List<string> info = new List<string>(); 
                
            //     foreach (KeyValuePair<string, string> details in person.Value) {
            //         info.Add(details.Value);
            //     }
            //     Console.WriteLine($"{info[0]} is my {person.Key} and is {info[1]} years old");
            // }


        }

    }
}
