using System;
using System.Collections.Generic;

class MainClass
{
    static TestCase testCase = new TestCase(0);

    public static void Main(string[] args)
    {

    }
}

class TestCase
{
    string[] input;
    string[] output;

    int input_i;
    int output_i;

    public TestCase(int num)
    {
        input = new[] {
@"",

@"",

@"",
            }[num].Split('\n');

        output = new[] {
@"",

@"",

@"",
            }[num].Split('\n');
    }

    public string ReadLine()
    {
        var str = input[input_i++];
        Console.WriteLine(str);
        return str;
    }

    public void WriteLine(object o)
    {
        var s = o.ToString();
        Console.WriteLine(s);
        var t = output[output_i++];
        if (s != t) throw new Exception($"{t} but {s}");
    }
}
