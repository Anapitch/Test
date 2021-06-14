using System;
using System.Linq;

public class Homework05
{
    public static void Main()
    {
        string[] led = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        string[] number = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        foreach (var x in led)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine("");
        foreach (var n in number)
        {
            Console.Write(" " + n + "  ");
        }
        Console.WriteLine("");

        while (true)
        {
            int i = 0;
            Console.Write("Please choose LED to turn On/Off:");
            string num = Console.ReadLine();

            foreach (var m in number)
            {
                if (num == m && led[i] == "[ ]")
                {
                    led[i] = "[!]";
                    foreach (var x in led)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine("");
                    foreach (var n in number)
                    {
                        Console.Write(" " + n + "  ");
                    }
                    Console.WriteLine("");
                }else if (num == m && led[i] == "[!]"){
                    led[i] = "[ ]";
                    foreach (var x in led)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine("");
                    foreach (var n in number)
                    {
                        Console.Write(" " + n + "  ");
                    }
                    Console.WriteLine("");
                }
                i++;
            }

        }

    }


}