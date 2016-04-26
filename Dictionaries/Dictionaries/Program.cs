using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            CodingLanguage Language1 = new CodingLanguage()
            {
                ID = 1,
                Name = "C#"
            };

            CodingLanguage Language2 = new CodingLanguage()
            {
                ID = 2,
                Name = "Java Script"
            };
            CodingLanguage Language3 = new CodingLanguage()
            {
                ID = 3,
                Name = "ASP.Net"
            };

            Dictionary<int, CodingLanguage> dictionarylanguage = new Dictionary<int, CodingLanguage>();
            dictionarylanguage.Add(Language1.ID, Language1);
            dictionarylanguage.Add(Language2.ID, Language2);
            dictionarylanguage.Add(Language3.ID, Language3);

            foreach (var  kvp in dictionarylanguage)
            {
                Console.WriteLine("ID is {0} and Value is {1}",kvp.Key,kvp.Value);
            }

        }
    }

    public class CodingLanguage
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
