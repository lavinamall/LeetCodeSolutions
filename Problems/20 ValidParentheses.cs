using System.Collections;

public class ValidParentheses
{
    private bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in s)
        {
            if (ch == '(' || ch == '{' || ch == '[')
                stack.Push(ch);
            else if (stack.Count == 0)
                return false;
            else
            {
                if (stack.Peek() == '(' && ch == ')')
                    stack.Pop();
                else if (stack.Peek() == '{' && ch == '}')
                    stack.Pop();
                else if (stack.Peek() == '[' && ch == ']')
                    stack.Pop();
                else
                    stack.Push(ch);
            }
        }
        return stack.Count > 0 ? false : true;
    }
    
    public void Test_ValidParentheses()
    {
        string s = "";
        
        s = "({[]})";
        System.Console.WriteLine($"Input string = '{s}', is valid = {IsValid(s)}");

        System.Console.WriteLine();

        s = "(])";
        System.Console.WriteLine($"Input string = '{s}', is valid = {IsValid(s)}");
    }
}