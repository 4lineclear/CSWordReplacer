using System;
namespace CSWordReplacer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Replacer replacer = new Replacer("onetwothreeonethreeo");
            Console.WriteLine(replacer.wordReplace("one", "two"));
            Console.WriteLine(Replacer.StaticWordReplace("onetwothreeonethreeo", "one", "two"));
        }
    }
}
