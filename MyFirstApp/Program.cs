// See https://aka.ms/new-console-template for more information



using System.Net.NetworkInformation;



public struct TestClass()
{
    string alpha = "1";
    public int testmethod()
    {

        return 0;
    }

    public static void Main()
    {
        TestClass tc = new TestClass();

        TestClass tc1 = tc;

        tc1.alpha = "2";

        Console.WriteLine(tc1.alpha + tc.alpha);

        data dt = new data("hemanth", 10);


//dictionary
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "hemanthdata");
        Console.WriteLine(dic[1]);


        

    }


}

public record data(string name,int age);


