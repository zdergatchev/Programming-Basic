using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            phonebook["John Smith"] = "+1-555-8976";
            phonebook["Lisa Smith"] = "+1-555-1234";
            phonebook["Sam Doe"] = "+1-555-5030";
            phonebook["Nakov"] = "+359-899-555-592";
            phonebook["Nakov"] = "+359-2-981-9819";
            Console.WriteLine(phonebook.ContainsKey("Nakov"));
            foreach (var item in phonebook)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
