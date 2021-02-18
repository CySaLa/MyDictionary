using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1- Dictionary sınıfı içinde sizin belirleyeceğiniz bir keye uygun olarak değer saklar.
            Zorunluluğu Var:
            2- Key türünü belirlememiz şarttır (string,  int vs...)
             */

            Dictionary<string, int> Hgwrts = new Dictionary<string, int>();
            //veri ekleme ozelligi
            Hgwrts.Add("Harry",  14);
            Hgwrts.Add("Draco",  14);
            Hgwrts.Add("Cedric",  17);
            Hgwrts.Add("Cho",  15);

            foreach (var stu in Hgwrts)
            {
                Console.WriteLine(stu);
            }
            
            //deger sayma ozelligi

            var student = Hgwrts.Count();
            Console.WriteLine();
            Console.WriteLine("Number of the Student in Hogwarts: " +student);

            //silme ozellgi

            Hgwrts.Remove("Cho");
            Console.WriteLine();
            foreach (var stu in Hgwrts)
            {
                Console.WriteLine(stu);
            }

            Console.ReadLine();
        }
    }
}
