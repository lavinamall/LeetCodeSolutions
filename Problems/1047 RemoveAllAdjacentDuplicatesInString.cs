using System.Data;

public class RemoveAllAdjacentDuplicatesInString {
    private string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();
        
        foreach (char ch in s)
        {
            if (stack.Count > 0 && stack.Peek() == ch)
                stack.Pop();
            else
                stack.Push(ch);
        }
        char[] result = new char[stack.Count];
        
        for (int i = stack.Count - 1; i >= 0; i--) {
            result[i] = stack.Pop();
        }
        return new string(result);
    }


    public void Test(){
        string s = "";

        s = "abbaca";
        System.Console.WriteLine($"input = {s}, result = {RemoveDuplicates(s)}");

        s = "azxxzy";
        System.Console.WriteLine($"input = {s}, result = {RemoveDuplicates(s)}");
    }
}