using System;
public class GFG
{
    public static int firstRepeating(string str)
    {
        int[] fi
            = new int[256]; 

        for (int i = 0; i < 256; i++)
            fi[i] = -1;

        for (int i = 0; i < str.Length; i++)
        {
            if (fi[str[i]] != -1)
            {
                fi[str[i]] = i;
            }
            else
            {
                fi[str[i]] = -2;
            }
        }

        int res = Int32.MaxValue;

        for (int i = 0; i < 256; i++)
        {

            if (fi[i] >= 0)
                res = Math.Min(res, fi[i]);
        }

        if (res == Int32.MaxValue)
            return -1;
        else
            return res;
    }

    public static int firstNonRepeating(string str)
    {
        int[] fi
            = new int[256]; 

        for (int i = 0; i < 256; i++)
            fi[i] = -1;

        for (int i = 0; i < str.Length; i++)
        {
            if (fi[str[i]] == -1)
            {
                fi[str[i]] = i;
            }
            else
            {
                fi[str[i]] = -2;
            }
        }

        int res = Int32.MaxValue;

        for (int i = 0; i < 256; i++)
        {

            if (fi[i] >= 0)
                res = Math.Min(res, fi[i]);
        }

        if (res == Int32.MaxValue)
            return -1;
        else
            return res;
    }

    public static void Main()
    {
        Console.Write("Input:");
        string str = Console.ReadLine();
		Console.WriteLine("Output:");
        int first = firstRepeating(str);
        if (first == -1)
            Console.WriteLine(
                "First duplicate charactor is:"+"-"
            );
        else
            Console.WriteLine(
                "First duplicate charactor is:"
                + str[first]);
        

		int firstIndex = firstNonRepeating(str);
        if (firstIndex == -1)
            Console.WriteLine(
                "First not duplicate charactor is:"+"-"
			);
        else
            Console.WriteLine(
                "First not duplicate character is:"
                + str[firstIndex]);
    }
}
