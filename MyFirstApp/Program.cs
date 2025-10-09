// See https://aka.ms/new-console-template for more information



using System.Dynamic;
using System.Net.NetworkInformation;




public struct TestClass()
{
    string alpha = "1";
    public int testmethod()
    {

        return 0;
    }

  
  
  //delegates
  public delegate int Greet(int a, int b);

     static int add(int a, int b) => a + b;

    public static void Main()
    {
        TestClass tc = new TestClass();

        TestClass tc1 = tc;

        tc1.alpha = "2";

        Greet gt = add;

        Console.WriteLine(gt(1,6));





        Console.WriteLine(tc1.alpha + tc.alpha);

        data dt = new data("hemanth", 10);


        //dictionary
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "hemanthdata");
        dic.Add(2, "rithu");


        if (dic.Values.Contains("rithu1"))
        {
            Console.WriteLine("contains");
        }
        Console.WriteLine(dic[1]);

        records<int> rcd = new records<int>();


        records<string> rcdf = new records<string>();


        Console.WriteLine(rcd.Add(1));
        Console.WriteLine(rcd.Add("name"));





    }


}

public record data(string name,int age);


//generics
public class records<T>()
{
    public T Add<T>(T items)
    {
        return items;
    }
}

