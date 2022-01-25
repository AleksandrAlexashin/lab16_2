using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace lab16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = string.Empty;
            using (StreamReader sr = new StreamReader("../../Products.json"))
            {
                 jsonString = sr.ReadToEnd();
            }
            Tovar[] tovars = JsonSerializer.Deserialize<Tovar[]>(jsonString);
            Tovar maxTovar = tovars[0];
            foreach(Tovar t in tovars)
            {
                if(t.Price>maxTovar.Price)
                { maxTovar = t; }
            }
            Console.WriteLine($"{maxTovar.Kod} {maxTovar.Name} {maxTovar.Price}");
            Console.ReadKey();
        }
    }
}
