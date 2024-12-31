using ClassLibrary1_tms;
using OOPPhone;

namespace ConsoleApp1_tms;

class Program
{
    static void Main(string[] args)
    {
        Class1 class1 = new Class1();
        //class1.Foo();
        //Console.WriteLine(class1.GetRandomVerses(new List<string>() { "hello", "class", "hi", "one", "two" }));
        //class1.TestQuest();
       // class1.StoreSimulator();
       var phone = new Phone("asda", "asdsa");
       Console.WriteLine(phone.Wight);
    }
}