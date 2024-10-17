using System;
using System.Collections.Generic;
public class TupleToDict
{
    static void Main(string[] args)
    {
        Tuple<int, string, int> tuple = new Tuple<int, string, int>(23,"hii",24);
        Console.WriteLine("item1:"+tuple.Item1);
        Console.WriteLine("Item2:" + tuple.Item2);
        Console.WriteLine("Item3:" + tuple.Item3);
        
        Dictionary<int,string> dict = new Dictionary<int,string>();
        dict.Add(tuple.Item1, tuple.Item2);
        dict.Add(tuple.Item1, tuple.Item2);
        foreach(var i in dict)
        {
            Console.WriteLine($"{i.Key}:{i.Value}");
        }


    }
}
