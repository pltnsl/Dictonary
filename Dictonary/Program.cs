using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> Book = new MyDictonary<int, string>();
            Book.Add(1, "Bir Ömür Nasıl Yaşanır?");
            Book.Add(2, "Pia Matter");
            Book.Add(3, "Kardeşimin Hikayesi");

            Console.WriteLine(Book.Count);

        }
    }
}
