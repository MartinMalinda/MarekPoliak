using System;
using System.Collections.Generic;

namespace Telephonebook
{
    class Telephonebook
    {
        public static void main()
        {
            Dictionary<string, string> telephonebook = new Dictionary<string, string>()
            {
                {"William A. Lathan", "405-709-1865"},
                { "John K. Miller" ,  "402-247-8568"},
                {"Hortensia E. Foster", "606-481-6467"},
                { "Amanda D. Newland" ,  "319-243-5613"},
                { "Brooke P. Askew" ,  "307-687-2982"}
            };

            Console.WriteLine( telephonebook.TryGetValue("John K. Miller"));
            foreach (var item in telephonebook)
            {
                if(item.Value== "307-687-2982")
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
            //telephonebook.ContainsKey("Chris E. Myers");
        }
        
        
    }
}