using System;

namespace My_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> kisiler = new MyList<string>();
            kisiler.Add ("Göksal");
            kisiler.Add("Gökçe");
            kisiler.Add("Hatice");

            foreach (var isim in kisiler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
