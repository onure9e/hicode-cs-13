using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
           string var1 = "Lorem ipsum dolor sit amet, consectetur adipiscing.";
           string var2 = "Lorem ipsum dolor sit.";

           Console.WriteLine(var1.Length);

           Console.WriteLine(var1.ToLower());
           Console.WriteLine(var2.ToUpper());

           Console.WriteLine(String.Concat(var1," Merhaba!"));

           Console.WriteLine(var1.CompareTo(var2));
           Console.WriteLine(string.Compare(var1,var2,true));
           Console.WriteLine(string.Compare(var1,var2,false));

           Console.WriteLine(var1.Contains(var2));
           Console.WriteLine(var1.EndsWith("Hoşgeldiniz!"));
           Console.WriteLine(var1.StartsWith("Merhaba!"));

           Console.WriteLine(var1.IndexOf("Lorem"));
           Console.WriteLine(var1.IndexOf("Mici"));
           Console.WriteLine(var1.LastIndexOf("s"));

           Console.WriteLine(var1.Insert(0,"Merhaba!"));

           Console.WriteLine(var1.PadRight(40) + var2);
           Console.WriteLine(var1.PadRight(40, '*') + var2);
           Console.WriteLine(var1 + var2.PadLeft(40));
           Console.WriteLine(var1 + var2.PadLeft(40, '-'));

           Console.WriteLine(var1.Remove(10));
           Console.WriteLine(var1.Remove(5,3));
           Console.WriteLine(var1.Remove(0,1));

           Console.WriteLine(var1.Replace("amet","ahmet"));
           Console.WriteLine(var1.Replace(" ","+"));

           Console.WriteLine(var1.Split(' ')[1]);

           Console.WriteLine(var1.Substring(4));
           Console.WriteLine(var1.Substring(4,6));


    }
}
}