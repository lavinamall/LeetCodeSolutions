public class MakeTheStringGreat
{
    private string MakeGood(string s)
    {
        if (s == "")
            return s;

        Stack<char> stack = new Stack<char>();
        foreach (char ch in s)
        {
            if (stack.Count > 0 && Math.Abs(stack.Peek() - ch) == 32)
                stack.Pop();
            else
                stack.Push(ch);
        }
        if(stack.Count > 0)
        {
            char[] result = new char[stack.Count];

            for (int i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }
            return new string(result);
        }
        else
            return new string("");
    }

    public void Test()
    {
        System.Console.WriteLine();
        string s = "";

        s = "LeEeetcode"; //output = Leetcode
        System.Console.WriteLine($"input = {s}, result = {MakeGood(s)}");

        s = "leEeetcode"; //output = leetcode
        System.Console.WriteLine($"input = {s}, result = {MakeGood(s)}");

        s = "abBAcC"; //output = ""
        System.Console.WriteLine($"input = {s}, result = {MakeGood(s)}");

        s = "Pp"; //output = ""
        System.Console.WriteLine($"input = {s}, result = {MakeGood(s)}");

        s = "pP"; //output = ""
        System.Console.WriteLine($"input = {s}, result = {MakeGood(s)}");
        System.Console.WriteLine();
    }
}